#!/usr/bin/env python3
"""
Python Code Transformer - Adds operation counter to innermost loops
Usage: python transform_python.py <input_file.py>
"""

import sys
import os
import re
from typing import List, Tuple

class PythonLoopTransformer:
    def __init__(self):
        self.operation_count_var = "operation_count"
    
    def transform_code(self, code: str) -> str:
        """
        Transform Python code to count operations in innermost loops
        """
        lines = code.split('\n')
        
        # Step 1: Add operation_count variable at the beginning
        result_lines = self._add_operation_count_variable(lines)
        
        # Step 2: Add operation_count += 1 to innermost loops
        result_lines = self._add_counters_to_innermost_loops(result_lines)
        
        # Step 3: Add print statement at the end of main execution
        result_lines = self._add_output_statement(result_lines)
        
        return '\n'.join(result_lines)
    
    def _add_operation_count_variable(self, lines: List[str]) -> List[str]:
        """Add operation_count = 0 at the beginning"""
        result = []
        
        # Find where to insert (after imports and before main code)
        insert_index = 0
        for i, line in enumerate(lines):
            stripped = line.strip()
            if stripped.startswith('import ') or stripped.startswith('from '):
                insert_index = i + 1
            elif stripped and not stripped.startswith('#'):
                break
        
        # Add lines up to insert point
        result.extend(lines[:insert_index])
        
        # Add operation count variable
        if insert_index > 0:
            result.append('')
        result.append(f'{self.operation_count_var} = 0')
        result.append('')
        
        # Add remaining lines
        result.extend(lines[insert_index:])
        
        return result
    
    def _add_counters_to_innermost_loops(self, lines: List[str]) -> List[str]:
        """Add operation_count += 1 to innermost loops"""
        result = []
        loop_stack = []
        i = 0
        
        while i < len(lines):
            line = lines[i]
            stripped = line.strip()
            indent_level = self._get_indent_level(line)
            
            # Detect loop starts (for, while)
            if self._is_loop_start(stripped):
                loop_stack.append({
                    'line_index': i,
                    'indent_level': indent_level,
                    'has_counter': False
                })
                result.append(line)
                
                # Check if this is an innermost loop
                current_loop = loop_stack[-1]
                if self._is_innermost_loop(lines, i + 1, current_loop['indent_level']):
                    # Check if next line exists and is the loop body
                    if i + 1 < len(lines):
                        next_line = lines[i + 1]
                        next_stripped = next_line.strip()
                        next_indent = self._get_indent_level(next_line)
                        
                        # If next line is properly indented (loop body), add counter before it
                        if next_indent > indent_level and next_stripped:
                            indent = self._get_indent_string(indent_level + 1)
                            result.append(f'{indent}{self.operation_count_var} += 1')
                            current_loop['has_counter'] = True
            else:
                result.append(line)
            
            # Pop loops that have ended (decrease in indent level)
            while loop_stack and stripped:
                current_indent = self._get_indent_level(line)
                if current_indent <= loop_stack[-1]['indent_level']:
                    if not self._is_loop_start(stripped):
                        loop_stack.pop()
                    else:
                        break
                else:
                    break
            
            i += 1
        
        return result
    
    def _is_loop_start(self, line: str) -> bool:
        """Check if line starts a loop"""
        return (line.startswith('for ') or 
                line.startswith('while ') or
                re.match(r'^for\s+\w+', line) or
                re.match(r'^while\s+', line))
    
    def _is_innermost_loop(self, lines: List[str], start_index: int, loop_indent: int) -> bool:
        """Check if a loop is innermost (no nested loops inside)"""
        for i in range(start_index, len(lines)):
            line = lines[i].strip()
            current_indent = self._get_indent_level(lines[i])
            
            # If we're back to same or less indent, loop body ended
            if current_indent <= loop_indent and line:
                break
            
            # If we find another loop at deeper indent, not innermost
            if current_indent > loop_indent and self._is_loop_start(line):
                return False
        
        return True
    
    def _get_indent_level(self, line: str) -> int:
        """Get indentation level (number of leading spaces / 4)"""
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
        """Get indent string for given level"""
        return '    ' * level
    
    def _add_output_statement(self, lines: List[str]) -> List[str]:
        """Add print statement at the end"""
        result = lines.copy()
        
        # Find the last non-empty, non-comment line
        insert_index = len(result)
        for i in range(len(result) - 1, -1, -1):
            stripped = result[i].strip()
            if stripped and not stripped.startswith('#'):
                insert_index = i + 1
                break
        
        # Add print statement
        result.insert(insert_index, '')
        result.insert(insert_index + 1, f'print(f"Operation Count: {{{self.operation_count_var}}}")')
        
        return result


def main():
    if len(sys.argv) != 3:
        print("Usage: python transform_python.py <input_file.py>")
        sys.exit(1)
    
    input_file = sys.argv[1]
    isTeacher = True if sys.argv[2] == "Teacher" else False
    fileNewName = "BestOperatorsCounter.py" if isTeacher else "OperatorsCounter.py"
    directory = os.path.dirname(input_file)
    fileNewName = os.path.join(directory, fileNewName)

    try:
        with open(input_file, 'r', encoding='utf-8') as f:
            code = f.read()
        
        transformer = PythonLoopTransformer()
        transformed_code = transformer.transform_code(code)
        
        # Write to output file
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
    # Example test if run without arguments
    if len(sys.argv) == 1:
        test_code1 = """import math

def calculate_sum(n):
    total = 0
    for i in range(n):
        for j in range(i):
            total += i * j
    return total

result = calculate_sum(10)
for x in range(5):
    print(x)
"""
        
        test_code2 = """number = input()
count = 0
for digit in number:
    if digit == '2':
        count += 1
print(count)
"""
        
        print("="*60)
        print("EXAMPLE TRANSFORMATION 1: Nested Loops")
        print("="*60)
        print("\nOriginal Code:")
        print("-"*60)
        print(test_code1)
        
        transformer = PythonLoopTransformer()
        transformed1 = transformer.transform_code(test_code1)
        
        print("\nTransformed Code:")
        print("-"*60)
        print(transformed1)
        
        print("\n" + "="*60)
        print("EXAMPLE TRANSFORMATION 2: Single Loop with If")
        print("="*60)
        print("\nOriginal Code:")
        print("-"*60)
        print(test_code2)
        
        transformed2 = transformer.transform_code(test_code2)
        
        print("\nTransformed Code:")
        print("-"*60)
        print(transformed2)
        print("="*60)
        print("\nUsage: python transform_python.py <input_file.py>")
    else:
        main()