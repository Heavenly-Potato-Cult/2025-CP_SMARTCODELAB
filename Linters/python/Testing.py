#!/usr/bin/env python3
"""
Python Code Transformer - Adds operation counter beside each operation
Usage: python transform_python.py <input_file.py> <Teacher|Student>
"""

import sys
import os
import re
from typing import List, Set

class PythonOperationTransformer:
    def __init__(self):
        self.operation_count_var = "operation_count"
        self.operators = [
            '+=', '-=', '*=', '/=', '//=', '%=', '**=',  # Compound assignment
            '==', '!=', '<=', '>=',  # Comparison
            '<<', '>>',  # Bitwise shift
            '&=', '|=', '^=',  # Bitwise compound
            '**',  # Exponentiation
            '//',  # Floor division
            '+', '-', '*', '/', '%',  # Arithmetic
            '<', '>',  # Relational
            '=',  # Assignment
            '&', '|', '^', '~',  # Bitwise
        ]
        self.conditions = ['==', '!=', '<=', '>=', '>', '<']
    
    def transform_code(self, code: str) -> str:
        """Transform Python code to count operations beside each operator"""
        code = self.flatten_conditions(code)
        lines = code.split('\n')
        
        # Step 1: Add global operation_count variable
        result_lines = self._add_global_operation_count(lines)
        
        # Step 2: Add global declaration in functions
        result_lines = self._add_global_declarations(result_lines)
        # Step 3: Add counters beside operations
        result_lines = self._add_counters_beside_operations(result_lines)
        
        # Step 4: Add print statement at the end
        result_lines = self._add_output_statement(result_lines)
        
        return '\n'.join(result_lines)
    
    def flatten_conditions(self, code: str) -> str:
        lines = code.split("\n")
        output = []

        collecting = False
        buffer = []
        indent = ""
        
        # Matches: if(...), elif(...), while(...), for(...), and assignments like x = (...)
        start_pattern = re.compile(
            r'^(\s*)(if|elif|while|for)\s*\('
            r'|^(\s*)[A-Za-z_]\w*\s*=\s*\('
        )

        for line in lines:
            stripped = line.strip()

            # Start of multi-line condition or boolean assignment
            start_match = start_pattern.match(line)
            if not collecting and start_match:
                collecting = True
                indent = start_match.group(1) or start_match.group(3) or ""
                buffer = [stripped]
                continue

            # Collect continuation lines
            if collecting:
                buffer.append(stripped)

                # End when encountering a line with `)` before a possible `:`
                if re.search(r'\)\s*:?\s*$', stripped):
                    combined = " ".join(buffer)
                    combined = re.sub(r'\s+', ' ', combined)  # clean spacing
                    output.append(indent + combined)
                    collecting = False
                continue

            # Normal line
            output.append(line)

        return "\n".join(output)

    def _add_global_operation_count(self, lines: List[str]) -> List[str]:
        """Add global operation_count = 0 at the beginning"""
        result = []
        
        # Find where to insert (after imports)
        insert_index = 0
        for i, line in enumerate(lines):
            stripped = line.strip()
            if stripped.startswith('import ') or stripped.startswith('from '):
                insert_index = i + 1
            elif stripped and not stripped.startswith('#'):
                break
        
        result.extend(lines[:insert_index])
        
        if insert_index > 0:
            result.append('')
        result.append(f'{self.operation_count_var} = 0')
        result.append('')
        
        result.extend(lines[insert_index:])
        
        return result
    
    def _add_global_declarations(self, lines: List[str]) -> List[str]:
        """Add 'global operation_count' at the start of each function"""
        result = []
        i = 0
        
        while i < len(lines):
            line = lines[i]
            stripped = line.strip()
            
            # Check if this is a function definition
            if stripped.startswith('def ') and '(' in stripped:
                result.append(line)
                
                # Add global declaration on next line
                indent = self._get_indent_level(line)
                global_line = self._get_indent_string(indent + 1) + f'global {self.operation_count_var}'
                result.append(global_line)
            else:
                result.append(line)
            
            i += 1
        
        return result
    
    def _add_counters_beside_operations(self, lines: List[str]) -> List[str]:
        """Add operation counters beside each operation"""
        result = []
        
        for i, line in enumerate(lines):
            stripped = line.strip()
            
            # Skip empty lines, comments, imports, function defs, class defs
            if (not stripped or 
                stripped.startswith('#') or
                stripped.startswith('import ') or
                stripped.startswith('from ') or
                stripped.startswith('def ') or
                stripped.startswith('class ') or
                stripped.startswith(f'{self.operation_count_var}') or
                stripped.startswith('global ')):
                result.append(line)
                continue
            
            # Check if this is a control statement (if, elif, while, for)
            if self._is_control_statement_with_condition(stripped):
                # Add the control statement line
                result.append(line)
                
                # Count operations in the condition
                op_count = self._count_operations_in_condition(line)
                
                if op_count > 0:
                    # Add counter on the next line (inside the block)
                    indent = self._get_indent_string(self._get_indent_level(line) + 1)
                    result.append(f'{indent}{self.operation_count_var} += {op_count}')
                
                continue
            
            # Skip other control keywords
            if self._is_simple_control_keyword(stripped):
                result.append(line)
                continue
            
            # Count operations in this line
            op_count = self._count_operations_in_line(line)
            
            if op_count == 0:
                result.append(line)
            else:
                # Add counter after the line
                result.append(line)
                indent = self._get_indent_string(self._get_indent_level(line))
                result.append(f'{indent}{self.operation_count_var} += {op_count}')
        
        return result
    
    def _is_control_statement_with_condition(self, line: str) -> bool:
        """Check if line is a control statement with a condition"""
        return (line.startswith('if ') or 
                line.startswith('elif ') or 
                line.startswith('while ') or
                line.startswith('for '))
    
    def _is_simple_control_keyword(self, line: str) -> bool:
        """Check if line is a simple control keyword without condition"""
        return (line.startswith('else:') or
                line.startswith('with ') or
                line.startswith('try:') or
                line.startswith('except') or
                line.startswith('finally:') or
                line.startswith('return'))
    
    def _count_operations_in_condition(self, line: str) -> int:
        """Count operations in a control statement condition using patterns"""
        stripped = line.strip()

        # Only handle if, elif, while
        if not stripped.startswith(('if ', 'elif ', 'while ')):
            return 0

        # Extract the condition part (between keyword and colon)
        colon_idx = stripped.find(':')
        if colon_idx == -1:
            return 0

        if stripped.startswith('if '):
            condition = stripped[3:colon_idx]
        elif stripped.startswith('elif '):
            condition = stripped[5:colon_idx]
        elif stripped.startswith('while '):
            condition = stripped[6:colon_idx]
        else:
            return 0

        count = 0
        # Define patterns for conditions
        patterns = [
                r'==',
                r'!=',
                r'<=',
                r'>=',
                r'(?<![<>=])<(?![=])',  # < not part of <=
                r'(?<![<>=])>(?![=])',  # > not part of >=
                r'\bis not\b',           # 'is not' as whole words
                r'\bis\b',               # 'is' as whole word
                r'\bin\b',               # 'in' as whole word
                r'\bnot\s+in\b',         # 'not in' as whole words
            ]

        for pat in patterns:
            matches = re.findall(pat, condition)
            count += len(matches)

        return count
    
    def _count_operations_in_string(self, text: str) -> int:
        """Count operations in a string"""
        # Remove strings and comments
        cleaned = self._remove_strings_and_comments(text)
        
        # Remove logical keywords (and, or, not, in, is) - these are not operators we count
        cleaned = re.sub(r'\band\b', ' ', cleaned)
        cleaned = re.sub(r'\bor\b', ' ', cleaned)
        cleaned = re.sub(r'\bnot\b', ' ', cleaned)
        cleaned = re.sub(r'\bin\b', ' ', cleaned)
        cleaned = re.sub(r'\bis\b', ' ', cleaned)
        
        count = 0
        
        # Count each operator
        temp_text = cleaned
        for op in self.operators:
            escaped_op = re.escape(op)
            matches = re.findall(escaped_op, temp_text)
            count += len(matches)
            # Remove matched operators
            temp_text = re.sub(escaped_op, ' ', temp_text)
        
        return count
    
    def _count_operations_in_line(self, line: str) -> int:
        """Count operations in a line"""
        # Remove strings and comments
        cleaned = self._remove_strings_and_comments(line)
        
        count = 0
        
        temp_line = cleaned
        for op in self.operators:
            escaped_op = re.escape(op)
            matches = re.findall(escaped_op, temp_line)
            count += len(matches)
            # Remove matched operators to avoid double counting
            temp_line = re.sub(escaped_op, ' ', temp_line)
        
        return count
    
    def _remove_strings_and_comments(self, line: str) -> str:
        """Remove string literals and comments"""
        # Remove comments
        if '#' in line:
            line = line[:line.index('#')]
        
        # Remove string literals
        line = re.sub(r'""".*?"""', '""', line)
        line = re.sub(r"'''.*?'''", "''", line)
        line = re.sub(r'"([^"\\]|\\.)*"', '""', line)
        line = re.sub(r"'([^'\\]|\\.)*'", "''", line)
        
        return line
    
    def _get_indent_level(self, line: str) -> int:
        """Get indentation level"""
        spaces = 0
        for char in line:
            if char == ' ':
                spaces += 1
            elif char == '\t':
                spaces += 4
            else:
                break
        return spaces // 4
    
    def _get_indent_string(self, level: int) -> str:
        """Get indent string"""
        return '    ' * level
    
    def _add_output_statement(self, lines: List[str]) -> List[str]:
        """Add print statement at the end"""
        result = lines.copy()
        
        # Find the last non-empty line
        insert_index = len(result)
        for i in range(len(result) - 1, -1, -1):
            stripped = result[i].strip()
            if stripped and not stripped.startswith('#'):
                insert_index = i + 1
                break
        
        result.insert(insert_index, '')
        result.insert(insert_index + 1, f'print(f"Total Operators: {{{self.operation_count_var}}}")')
        
        return result


def main():
    if len(sys.argv) != 3:
        print("Usage: python transform_python.py <input_file.py> <Teacher|Student>")
        sys.exit(1)
    
    input_file = sys.argv[1]
    isTeacher = sys.argv[2] == "Teacher"
    fileNewName = "BestOperatorsCounter.py" if isTeacher else "OperatorsCounter.py"
    directory = os.path.dirname(input_file)
    fileNewName = os.path.join(directory, fileNewName)

    try:
        with open(input_file, 'r', encoding='utf-8') as f:
            code = f.read()
        
        transformer = PythonOperationTransformer()
        transformed_code = transformer.transform_code(code)
        
        with open(fileNewName, 'w', encoding='utf-8') as f:
            f.write(transformed_code)
        
        print(f"Transformed code written to: {fileNewName}")
        print("\n" + "="*60)
        print("TRANSFORMED CODE:")
        print("="*60)
        print(transformed_code)
        
    except FileNotFoundError:
        print(f"Error: File '{input_file}' not found")
        sys.exit(1)
    except Exception as e:
        print(f"Error: {e}")
        sys.exit(1)


if __name__ == "__main__":
    if len(sys.argv) == 1:
        # Example test
        test_code = """import math

def calculate_sum(n):
    total = 0
    for i in range(n):
        total += i
    return total

x = 5
y = 10
sum_val = x + y
result = calculate_sum(sum_val)
print(result)
"""
        
        print("="*60)
        print("EXAMPLE TRANSFORMATION")
        print("="*60)
        print("\nOriginal Code:")
        print("-"*60)
        print(test_code)
        
        transformer = PythonOperationTransformer()
        transformed = transformer.transform_code(test_code)
        
        print("\nTransformed Code:")
        print("-"*60)
        print(transformed)
        print("="*60)
        print("\nUsage: python transform_python.py <input_file.py> <Teacher|Student>")
    else:
        main()