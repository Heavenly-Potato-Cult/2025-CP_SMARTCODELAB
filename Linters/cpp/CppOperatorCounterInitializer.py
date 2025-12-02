import sys
import os
import re
from typing import List, Tuple

class CodeLineMerger:
    def __init__(self):
        self.preserve_indentation = True
    
    def merge_multiline_statements(self, code: str) -> str:
        code = self.remove_comments(code)
        lines = code.split('\n')
        result = []
        i = 0
        
        while i < len(lines):
            current_line = lines[i]
            
            # Skip empty lines and keep them as-is
            if not current_line.strip():
                result.append(current_line)
                i += 1
                continue
            
            # Check if this line needs merging
            merged_line, lines_consumed = self._merge_statement(lines, i)
            result.append(merged_line)
            i += lines_consumed
        
        return self.add_newlines_before_return('\n'.join(result))
    
    def add_newlines_before_return(self, code: str) -> str:
        lines = code.splitlines(keepends=True)
        result = []

        for line in lines:
            lower_line = line.lower()
            index = lower_line.find("return")

            if index != -1:  # found 'return'
                new_line = line[:index] + "\n\n" + line[index:]
                result.append(new_line)
            else:
                result.append(line)

        return "".join(result)

    def _merge_statement(self, lines: List[str], start_index: int) -> tuple:
        current_line = lines[start_index]
        base_indent = self._get_leading_whitespace(current_line)
        
        # Check if statement is complete on this line
        if self._is_statement_complete(current_line):
            return (current_line, 1)
        
        # Statement continues on next lines - merge them
        merged_parts = [current_line.rstrip()]
        lines_consumed = 1
        paren_count = self._count_open_parens(current_line)
        has_semicolon = ';' in current_line
        
        # Continue merging until statement is complete
        while start_index + lines_consumed < len(lines):
            next_line = lines[start_index + lines_consumed]
            next_stripped = next_line.strip()
            
            # Stop at empty lines unless we have unclosed parentheses
            if not next_stripped and paren_count == 0:
                break
            
            # Remove leading whitespace from continuation lines
            if next_stripped:
                merged_parts.append(' ' + next_stripped)
            
            paren_count += self._count_open_parens(next_line)
            has_semicolon = has_semicolon or (';' in next_line)
            lines_consumed += 1
            
            # Check if statement is now complete
            if paren_count == 0 and has_semicolon:
                break
            
            # For control structures, stop after opening brace
            if paren_count == 0 and '{' in next_line:
                break
        
        # Combine all parts into one line with base indentation
        merged_line = base_indent + ''.join(merged_parts).strip()
        
        # Clean up extra spaces
        merged_line = self._clean_spacing(merged_line)
        
        return (merged_line, lines_consumed)
    
    def _is_statement_complete(self, line: str) -> bool:
        """Check if a statement is complete on this line"""
        stripped = line.strip()
        
        # Empty lines are complete
        if not stripped:
            return True
        
        # Comments are complete
        if stripped.startswith('//') or stripped.startswith('#'):
            return True
        
        # Lines ending with { are complete (function/block declarations)
        if stripped.endswith('{'):
            return True
        
        # Lines ending with } are complete
        if stripped.endswith('}'):
            return True
        
        # Standalone braces
        if stripped in ['{', '}']:
            return True
        
        # Lines with 'else' followed by '{' are complete
        if stripped == 'else' or stripped.startswith('} else'):
            return True
        
        # Count parentheses
        paren_count = self._count_open_parens(line)
        
        # If parentheses are balanced
        if paren_count == 0:
            # Check for semicolon (statement terminator)
            if ';' in line:
                return True
        
        # Statement is incomplete if parentheses are not balanced
        return False
    
    def _count_open_parens(self, line: str) -> int:
        """
        Count net open parentheses (opening - closing).
        Ignores parentheses in strings and comments.
        """
        # Remove string literals
        cleaned = re.sub(r'"[^"]*"', '', line)
        cleaned = re.sub(r"'[^']*'", '', cleaned)
        
        # Remove comments
        if '//' in cleaned:
            cleaned = cleaned[:cleaned.index('//')]
        
        # Count parentheses
        open_count = cleaned.count('(')
        close_count = cleaned.count(')')
        
        return open_count - close_count
    
    def _get_leading_whitespace(self, line: str) -> str:
        """Extract leading whitespace from a line"""
        match = re.match(r'^(\s*)', line)
        return match.group(1) if match else ''
    
    def _clean_spacing(self, line: str) -> str:
        """Clean up extra spaces in merged line"""
        # Preserve leading whitespace
        leading_ws = self._get_leading_whitespace(line)
        content = line.lstrip()
        
        # Reduce multiple spaces to single space
        content = re.sub(r'\s+', ' ', content)
        
        # Fix spacing around operators and punctuation
        content = re.sub(r'\s*\(\s*', '(', content)
        content = re.sub(r'\s*\)\s*', ') ', content)
        content = re.sub(r'\s*,\s*', ', ', content)
        content = re.sub(r'\s*;\s*', ';', content)
        content = re.sub(r'\s*\{\s*', ' {', content)
        content = re.sub(r'\s*\}\s*', '}', content)
        
        # Remove trailing space before semicolon
        content = content.rstrip()
        
        return leading_ws + content

    def remove_comments(self, code: str) -> str:
        result = []
        i = 0
        n = len(code)

        in_string = False
        in_char = False
        in_single_comment = False
        in_multi_comment = False

        while i < n:
            c = code[i]
            nxt = code[i + 1] if i + 1 < n else ''

            # --- Inside single-line comment ---
            if in_single_comment:
                if c == '\n':  # comment ends at newline
                    in_single_comment = False
                    result.append(c)
                i += 1
                continue

            # --- Inside multi-line comment ---
            if in_multi_comment:
                if c == '*' and nxt == '/':
                    in_multi_comment = False
                    i += 2  # skip */
                else:
                    i += 1
                continue

            # --- Not inside a string or char literal ---
            if not in_string and not in_char:
                # detect //
                if c == '/' and nxt == '/':
                    in_single_comment = True
                    i += 2
                    continue

                # detect /*
                if c == '/' and nxt == '*':
                    in_multi_comment = True
                    i += 2
                    continue

            # --- Detect entering or leaving a string literal ---
            if c == '"' and not in_char:
                result.append(c)
                in_string = not in_string
                i += 1
                continue

            # --- Detect entering or leaving a char literal ---
            if c == "'" and not in_string:
                result.append(c)
                in_char = not in_char
                i += 1
                continue

            # Normal character
            result.append(c)
            i += 1

        return ''.join(result)

class CppOperatorCounter:
    def __init__(self):
        self.counter_var = "TOTAL_NUMBER_OF_OPERATORS"
    
    def transform_code(self, code: str) -> str:
        """
        Transform C++ code to count operators in all methods
        """
        # Step 1: Add global static variable
        code = self._add_global_counter(code)
        
        # Step 2: Add operator counting to all statements
        code = self._add_operator_counting(code)
        
        code = self._add_output_statement(code)
        return code
    
    def _add_global_counter(self, code: str) -> str:
        """Add global static long long TOTAL_NUMBER_OF_OPERATORS = 0; after headers and before the first function."""
        lines = code.split('\n')
        result = []
        
        # Find where to insert (after the last #include or using namespace, before first function)
        insert_index = 0
        in_header_section = True
        
        for i, line in enumerate(lines):
            stripped = line.strip()
            
            if in_header_section:
                # Check if this line ends the header section
                if stripped and not (stripped.startswith('#include') or 
                                    stripped.startswith('using namespace') or
                                    stripped.startswith('//') or
                                    stripped.startswith('/*') or
                                    stripped == ''):
                    in_header_section = False
                    insert_index = i
                    break
            
            # If we reach end of file while still in header section
            if i == len(lines) - 1 and in_header_section:
                insert_index = len(lines)
        
        # Add all lines up to insertion point
        result.extend(lines[:insert_index])
        
        # Add a blank line and the counter variable
        if insert_index > 0:
            result.append('')
        result.append(f'static long long {self.counter_var} = 0;')
        result.append('')  # blank line after counter
        
        # Add the rest of the code
        result.extend(lines[insert_index:])
        
        return '\n'.join(result)
    
    def _add_operator_counting(self, code: str) -> str:
        """Add operator counting after each statement"""
        lines = code.split('\n')
        result = []
        
        in_function = True
        brace_depth = 0
        
        i = 0
        while i < len(lines):
            line = lines[i]
            stripped = line.strip()
            
            # Track if we're inside a function
            if self._is_function_definition(stripped):
                in_function = True
            
            # Track brace depth
            if '{' in line:
                brace_depth += line.count('{')
            if '}' in line:
                brace_depth -= line.count('}')
                if brace_depth == 0:
                    in_function = False
            
            # Skip non-statement lines
            if self._should_skip_line(stripped):
                result.append(line)
                i += 1
                continue
            
            # Process statements only if we're inside a function
            if in_function and brace_depth > 0:
                processed = self._process_statement(lines, i)
                if processed:
                    result.extend(processed['lines'])
                    i += processed['lines_consumed']
                    continue
            
            result.append(line)
            i += 1
        
        return '\n'.join(result)
    
    def _process_statement(self, lines: List[str], index: int) -> dict:
        """Process a statement and add operator counting"""
        line = lines[index]
        stripped = line.strip()
        indent = self._get_leading_whitespace(line)
        
        # Skip for loop statements
        if re.match(r'^for\s*\(', stripped):
            return None
        
        # Skip lines that are just braces or control keywords without statements
        if stripped in ['{', '}', 'else', 'else {']:
            return None
        
        # Handle if/while/else if statements
        if self._is_control_statement(stripped):
            return self._process_control_statement(lines, index)
        
        # Handle return statements
        if "return".casefold() in stripped.casefold():
            return self._process_return_statement(lines, index)
        
        # Handle regular statements
        if ';' in stripped:
            return self._process_regular_statement(lines, index)
        
        return None
    
    def _process_control_statement(self, lines: List[str], index: int) -> dict:
        """Process if/while/else if statements"""
        line = lines[index]
        stripped = line.strip()
        indent = self._get_leading_whitespace(line)
        
        # Count operators in the condition
        op_count = self._count_operators(stripped)
        
        result_lines = [line]
        lines_consumed = 1
        
        # Check if opening brace is on the same line
        if '{' in stripped:
            # Add counter after the opening brace
            if op_count > 0:
                result_lines.append(f'{indent}    {self.counter_var} += {op_count};')
        else:
            # Check next line for opening brace
            if index + 1 < len(lines) and lines[index + 1].strip() == '{':
                result_lines.append(lines[index + 1])
                lines_consumed += 1
                if op_count > 0:
                    result_lines.append(f'{indent}    {self.counter_var} += {op_count};')
            elif op_count > 0:
                # No brace, single statement - add counter before next statement
                result_lines.append(f'{indent}    {self.counter_var} += {op_count};')
        
        return {'lines': result_lines, 'lines_consumed': lines_consumed}
    
    def _process_return_statement(self, lines: List[str], index: int) -> dict:
        """Process return statement - add counter BEFORE it"""
        line = lines[index]
        indent = self._get_leading_whitespace(line)
        
        # Count operators in return statement
        op_count = self._count_operators(line)
        
        result_lines = []
        if op_count > 0:
            result_lines.append(f'{indent}{self.counter_var} += {op_count};')
        result_lines.append(line)
        return {'lines': result_lines, 'lines_consumed': 1}
    
    def _process_regular_statement(self, lines: List[str], index: int) -> dict:
        """Process regular statement ending with semicolon"""
        line = lines[index]
        indent = self._get_leading_whitespace(line)
        
        # Count operators
        op_count = self._count_operators(line)
        
        result_lines = [line]
        if op_count > 0:
            result_lines.append(f'{indent}{self.counter_var} += {op_count};')
        
        return {'lines': result_lines, 'lines_consumed': 1}
    
    def _is_function_definition(self, line: str) -> bool:
        """
        Check if a line is a common beginner-friendly C++ function definition.
        """
        pattern = r'''^
            \s*                                # optional leading spaces
            (?:const\s+)?                       # optional 'const'
            (?:unsigned\s+)?                    # optional 'unsigned'
            (?:void|int|float|double|char|bool|long|auto)  # return type
            (\s*[*&]\s*)?                       # optional pointer or reference
            \s+                                 # space before function name
            \w+                                 # function name
            \s*                                 # optional spaces
            \([^)]*\)                           # parameters (empty or not)
            \s*                                 # optional spaces
            (\{)?                               # optional opening brace
            \s*$                                # optional trailing spaces
        '''
        return bool(re.match(pattern, line, re.VERBOSE))

    
    def _is_control_statement(self, line: str) -> bool:
        """Check if line is an if/while/else if statement"""
        return bool(re.match(r'^(if|while|else\s+if)\s*\(', line))
    
    def _should_skip_line(self, line: str) -> bool:
        """Check if line should be skipped"""
        if not line:
            return True
        if line.startswith('//') or line.startswith('#') or line.startswith('/*'):
            return True
        if line.startswith('using namespace'):
            return True
        if line in ['{', '}']:
            return True
        if line.startswith(f'static long long {self.counter_var}'):
            return True
        if line.startswith(f'{self.counter_var} +='):
            return True
        return False
    
    def remove_stream_operators(self, line: str) -> str:
        # Check if the line contains cin or cout
        if 'cin' in line or 'cout' in line:
            new_line = ""
            paren_count = 0

            i = 0
            while i < len(line):
                char = line[i]

                # Track parentheses
                if char == '(':
                    paren_count += 1
                    new_line += char
                elif char == ')':
                    paren_count -= 1
                    new_line += char
                # Remove << for cout or >> for cin if not inside parentheses
                elif line[i:i+2] == '<<' and 'cout' in line and paren_count == 0:
                    i += 1  # skip second <
                elif line[i:i+2] == '>>' and 'cin' in line and paren_count == 0:
                    i += 1  # skip second >
                else:
                    new_line += char

                i += 1

            return new_line
        else:
            return line

    def _count_operators(self, line: str) -> int:
        """Count the number of operators in a line"""
        count = 0
        charOperators = '|'.join(re.escape(op) for op in ['<<=', '>>=', '->*'])
        operators2 = '|'.join(re.escape(op) for op in ['+=', '-=', '*=', '/=', '%=', '&=', '|=', '^=', # Compound assignment
                    '==', '!=', '<=', '>=',                          # Comparison  
                    '&&', '||',                                      # Logical
                    '<<', '>>',                                      # Bitwise shift
                    '++', '--',
                    ])
        singleOperators =  '|'.join(re.escape(op) for op in ['+', '-', '*', '/', '%',# Arithmetic
                            '&', '|', '^', '~',    # Bitwise
                            '<', '>', '=',         # Relational/assignment
                            '!',                   # Logical NOT
                            ])
        # Remove string literals to avoid counting inside strings
        line_clean = re.sub(r'"[^"]*"', '', line)
        line_clean = re.sub(r"'[^']*'", '', line_clean)
        # Remove inline comments to avoid counting inside comments
        if '//' in line_clean:
            line_clean = line_clean[:line_clean.index('//')]
        
        line_clean = self.remove_stream_operators(line_clean)
        # Remove for loop header to exclude it from counting
        if re.match(r'^\s*for\s*\(', line_clean):
            return 0
        
        the_code = line_clean
        count += len(re.findall(charOperators, the_code))
        the_code = re.sub(charOperators, '', the_code)
        count += len(re.findall(operators2, the_code))
        the_code = re.sub(operators2, '', the_code)
        count += len(re.findall(singleOperators, the_code))
        the_code = re.sub(singleOperators, '', the_code)
        # Count function calls (identifier followed by opening paren)
        # Exclude control structures
        # if not re.match(r'^\s*(for|while|if|else\s+if)\s*\(', line):
        #     count += len(re.findall(r'\w+\s*\(', line_clean))
        return count
    
    def _get_leading_whitespace(self, line: str) -> str:
        """Extract leading whitespace from a line"""
        match = re.match(r'^(\s*)', line)
        return match.group(1) if match else ''

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
        """Insert cout before EVERY return inside main()"""
        main_pattern = r'int\s+main\s*\([^)]*\)\s*\{'
        match = re.search(main_pattern, code)
        if not match:
            return code

        # Identify main block boundaries
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

        # Extract the main function body
        main_body = code[main_start:main_end]

        # Find all return statements inside main
        return_positions = [
            m.start() for m in re.finditer(r'return\s+[^;]*;', main_body)
        ]

        # Determine indentation
        lines_before = code[:main_end].split('\n')
        last_line = lines_before[-1] if lines_before else ''
        indent = self._get_indent_string(self._get_indent_level(last_line))

        output_stmt = f'{indent}std::cout << "Operation Count:" << {self.counter_var} << std::endl;\n'

        # Insert output before each return, processing in reverse order
        new_body = main_body
        for pos in reversed(return_positions):
            new_body = new_body[:pos] + output_stmt + indent + new_body[pos:]

        # If no return statements found → add before closing brace
        if not return_positions:
            new_body = new_body + output_stmt

        # Rebuild full code
        return code[:main_start] + new_body + code[main_end:]

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
        
        multi_line_cleaner = CodeLineMerger()
        transformed_code = multi_line_cleaner.merge_multiline_statements(code) #make multi line statements into one line statement first
        
        operator_counter = CppOperatorCounter()
        transformed_code = operator_counter.transform_code(transformed_code)

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
        
        transformer = CodeLineMerger()
        transformed = transformer.merge_multiline_statements(test_code)
        
        print("\nTransformed Code:")
        print("-"*60)
        print(transformed)
        print("="*60)
        print("\nUsage: python transform_cpp.py <input_file.cpp>")
    else:
        main()