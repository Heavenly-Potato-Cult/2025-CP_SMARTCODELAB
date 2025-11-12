#!/usr/bin/env python3
"""
C++ Code Transformer - Adds operation counter to innermost loops
Usage: python transform_cpp.py <input_file.cpp>
"""

import sys
import os
import re
from typing import List

class CppLoopTransformer:
    def __init__(self):
        self.operation_count_var = "operationCount"
    
    def transform_code(self, code: str) -> str:
        """
        Transform C++ code to count operations in innermost loops
        """
        # Step 1: Add global operation counter variable
        code = self._add_operation_count_variable(code)
        
        # Step 2: Add operationCount++ to innermost loops
        code = self._add_counters_to_innermost_loops(code)
        
        # Step 3: Add output statement at end of main
        code = self._add_output_statement(code)
        
        return code
    
    def _add_operation_count_variable(self, code: str) -> str:
        """Add global long long operationCount = 0;"""
        lines = code.split('\n')
        result = []
        
        # Find position after includes and using statements
        insert_index = 0
        for i, line in enumerate(lines):
            stripped = line.strip()
            if stripped.startswith('#include') or stripped.startswith('using namespace'):
                insert_index = i + 1
            elif stripped and not stripped.startswith('//'):
                break
        
        # Insert up to that point
        result.extend(lines[:insert_index])
        
        # Add operation counter
        if insert_index > 0:
            result.append('')
        result.append(f'long long {self.operation_count_var} = 0;')
        result.append('')
        
        # Add remaining code
        result.extend(lines[insert_index:])
        
        return '\n'.join(result)
    
    def _add_counters_to_innermost_loops(self, code: str) -> str:
        """Add operationCount++ to innermost loops"""
        lines = code.split('\n')
        result = []
        loop_stack = []
        
        i = 0
        while i < len(lines):
            line = lines[i]
            stripped = line.strip()
            indent_level = self._get_indent_level(line)
            
            # Detect loop starts
            if self._is_loop_start(stripped):
                loop_info = {
                    'line_index': i,
                    'indent_level': indent_level,
                    'loop_type': self._get_loop_type(stripped)
                }
                loop_stack.append(loop_info)
                result.append(line)
                
                # Look for opening brace
                brace_line_index = i
                if '{' in stripped:
                    brace_line_index = i
                else:
                    # Check next lines for opening brace
                    for j in range(i + 1, min(i + 3, len(lines))):
                        result.append(lines[j])
                        if '{' in lines[j]:
                            brace_line_index = j
                            i = j
                            break
                
                # Check if innermost loop
                if self._is_innermost_loop(lines, brace_line_index + 1, indent_level):
                    indent = self._get_indent_string(indent_level + 1)
                    result.append(f'{indent}{self.operation_count_var}++;')
            
            else:
                result.append(line)
                
                # Pop loops when we exit their scope
                if '}' in stripped and loop_stack:
                    current_indent = self._get_indent_level(line)
                    while loop_stack and current_indent <= loop_stack[-1]['indent_level']:
                        loop_stack.pop()
                        break
            
            i += 1
        
        return '\n'.join(result)
    
    def _is_loop_start(self, line: str) -> bool:
        """Check if line starts a loop"""
        return (line.startswith('for(') or 
                line.startswith('for (') or
                line.startswith('while(') or
                line.startswith('while (') or
                line.startswith('do') or
                line.startswith('do ') or
                re.match(r'^for\s*\(', line) or
                re.match(r'^while\s*\(', line))
    
    def _get_loop_type(self, line: str) -> str:
        """Get loop type (for, while, do-while)"""
        if line.startswith('for'):
            return 'for'
        elif line.startswith('while'):
            return 'while'
        elif line.startswith('do'):
            return 'do-while'
        return 'unknown'
    
    def _is_innermost_loop(self, lines: List[str], start_index: int, loop_indent: int) -> bool:
        """Check if loop is innermost (no nested loops)"""
        brace_count = 1
        
        for i in range(start_index, len(lines)):
            line = lines[i].strip()
            
            # Count braces
            brace_count += line.count('{') - line.count('}')
            
            # If we exit the loop body
            if brace_count <= 0:
                break
            
            # Check for nested loops
            if self._is_loop_start(line):
                return False
        
        return True
    
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
    
    def _add_output_statement(self, code: str) -> str:
        """Add cout statement at end of main function"""
        # Find main function
        main_pattern = r'int\s+main\s*\([^)]*\)\s*\{'
        match = re.search(main_pattern, code)
        
        if not match:
            return code
        
        # Find the closing brace of main
        main_start = match.end()
        brace_count = 1
        main_end = -1
        
        for i in range(main_start, len(code)):
            if code[i] == '{':
                brace_count += 1
            elif code[i] == '}':
                brace_count -= 1
                if brace_count == 0:
                    main_end = i
                    break
        
        if main_end == -1:
            return code
        
        # Find the last return statement or insert before closing brace
        main_body = code[main_start:main_end]
        
        # Get indentation from the line before closing brace
        lines_before = code[:main_end].split('\n')
        last_line = lines_before[-1] if lines_before else ''
        indent = self._get_indent_string(self._get_indent_level(last_line))
        
        # Create output statement
        output_stmt = f'{indent}cout << "Operation Count:" << {self.operation_count_var} << endl;\n'
        
        # Check if there's a return statement
        return_match = re.search(r'return\s+\d+\s*;', main_body)
        
        if return_match:
            # Insert before return
            return_pos = main_start + return_match.start()
            return code[:return_pos] + output_stmt + indent + code[return_pos:]
        else:
            # Insert before closing brace
            return code[:main_end] + output_stmt + code[main_end:]


def main():
    if len(sys.argv) != 3:
        print("Usage: python transform_cpp.py <input_file.cpp>")
        sys.exit(1)
    
    input_file = sys.argv[1]
    isTeacher = True if sys.argv[2] == "Teacher" else False
    fileNewName = "BestOperatorsCounter.cpp" if isTeacher else "OperatorsCounter.cpp"
    directory = os.path.dirname(input_file)
    fileNewName = os.path.join(directory, fileNewName)

    try:
        with open(input_file, 'r', encoding='utf-8') as f:
            code = f.read()
        
        transformer = CppLoopTransformer()
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
        test_code = """#include <iostream>
using namespace std;

int main() {
    int sum = 0;
    
    for (int i = 0; i < 10; i++) {
        for (int j = 0; j < 5; j++) {
            sum += i * j;
        }
    }
    
    while (sum > 0) {
        sum--;
    }
    
    return 0;
}
"""
        print("="*60)
        print("EXAMPLE TRANSFORMATION:")
        print("="*60)
        print("\nOriginal Code:")
        print("-"*60)
        print(test_code)
        
        transformer = CppLoopTransformer()
        transformed = transformer.transform_code(test_code)
        
        print("\nTransformed Code:")
        print("-"*60)
        print(transformed)
        print("="*60)
        print("\nUsage: python transform_cpp.py <input_file.cpp>")
    else:
        main()