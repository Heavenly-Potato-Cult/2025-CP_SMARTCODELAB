#!/usr/bin/env python3
import re
import sys
import os

def remove_comments_and_strings(code):
    """Remove comments and string literals to avoid false positives."""
    code = re.sub(r'//.*', '', code)  # single-line comments
    code = re.sub(r'/\*.*?\*/', '', code, flags=re.DOTALL)  # multi-line comments
    code = re.sub(r'\"(\\.|[^"\\])*\"', '""', code)  # string literals
    code = re.sub(r"\'(\\.|[^'\\])*\'", "''", code)  # char literals
    return code


def remove_cout_shifts(code):
    """
    Remove ONLY << operators used with cout, keep other << operators.
    Example: cout << "Hello" << x;  -> cout  "Hello"  x;
    But: value = a << 2;  -> stays as: value = a << 2;
    """
    # Match cout followed by any number of << sequences
    # Replace only the << operators in cout chains with a placeholder
    def replace_cout_shifts(match):
        # Remove all << from the cout statement
        return re.sub(r'<<', ' ', match.group())
    
    # Pattern matches: cout << anything until semicolon or newline
    pattern = r'\bcout\s*<<[^;]*(?=;|\n|$)'
    return re.sub(pattern, replace_cout_shifts, code)


def count_cin_shifts_once(code):
    """
    Count each cin >> chain as ONE operator (cin >> a >> b; = 1 operator).
    Returns: count and cleaned code with cin chains removed
    """
    # Match cin followed by any number of >> sequences until semicolon
    matches = re.findall(r'\bcin\s*(?:>>\s*[^;]+)+', code)
    cin_count = len(matches)
    
    # Remove cin chains from code (to avoid double-counting >> operators)
    cleaned_code = re.sub(r'\bcin\s*(?:>>\s*[^;]+)+', '', code)
    
    return cin_count, cleaned_code


def count_operators(code):
    """
    Count all operators with special rules:
    - Exclude << ONLY when used with cout
    - Count entire cin >> chain as 1 operator
    - Count && as ONE operator (not as two & operators)
    - Count all other operators normally
    """
    clean_code = remove_comments_and_strings(code)
    
    # Remove cout << operators
    clean_code = remove_cout_shifts(clean_code)
    
    # Count cin >> chains as single operators and remove them from code
    cin_count, clean_code = count_cin_shifts_once(clean_code)
    
    # Define operator patterns (ordered to match longest first)
    # IMPORTANT: Must match compound operators before their single-char components
    operator_patterns = [
        # Compound assignment operators (must match before single operators)
        (r'\+=', '+='),
        (r'-=', '-='),
        (r'\*=', '*='),
        (r'/=', '/='),
        (r'%=', '%='),
        (r'<<=', '<<='),
        (r'>>=', '>>='),
        (r'&=', '&='),
        (r'\|=', '|='),
        (r'\^=', '^='),
        
        # Comparison operators (must match before < and >)
        (r'==', '=='),
        (r'!=', '!='),
        (r'<=', '<='),
        (r'>=', '>='),
        
        # Increment/decrement (must match before + and -)
        (r'\+\+', '++'),
        (r'--', '--'),
        
        # Logical operators (must match before & and |)
        (r'&&', '&&'),  # This will match && as ONE operator
        (r'\|\|', '||'),  # This will match || as ONE operator
        
        # Bitwise shift operators (>> and << that are NOT from cout/cin)
        (r'>>', '>>'),
        (r'<<', '<<'),
        
        # Arithmetic operators
        (r'\+', '+'),
        (r'-', '-'),
        (r'\*', '*'),
        (r'/', '/'),
        (r'%', '%'),
        
        # Relational operators
        (r'<', '<'),
        (r'>', '>'),
        
        # Bitwise operators (single & and | - these won't match && or ||)
        (r'&', '&'),    # This matches single & (not part of &&)
        (r'\|', '|'),   # This matches single | (not part of ||)
        (r'\^', '^'),
        (r'~', '~'),
        
        # Logical NOT
        (r'!', '!'),
        
        # Assignment operator (match last to avoid matching compound assignments)
        (r'=', '='),
    ]
    
    total_count = 0
    operator_details = {}
    
    # Count each operator type and remove matches to avoid double-counting
    for pattern, display_name in operator_patterns:
        matches = re.findall(pattern, clean_code)
        count = len(matches)
        if count > 0:
            operator_details[display_name] = count
            total_count += count
            # CRITICAL: Remove matched operators to prevent double-counting
            # Replace with spaces to maintain positions
            clean_code = re.sub(pattern, ' ' * len(display_name), clean_code)
    
    # Add cin >> count
    if cin_count > 0:
        operator_details['cin >>'] = cin_count
        total_count += cin_count
    
    return total_count, operator_details


def analyze_cpp_file(file_path):
    """Analyze a C++ file and count operators."""
    try:
        with open(file_path, 'r', encoding='utf-8') as file:
            code = file.read()

        lines = code.split('\n')
        user_code_lines = []
        in_user_code = False

        for line in lines:
            line_stripped = line.strip()
            # Skip preprocessor directives and using statements
            if line_stripped.startswith('#include') or line_stripped.startswith('using namespace'):
                continue
            
            # Detect start of user code (function definitions)
            if (line_stripped.startswith('int main') or 
                line_stripped.startswith('void ') or 
                line_stripped.startswith('bool ') or 
                line_stripped.startswith('double ') or
                line_stripped.startswith('float ') or 
                line_stripped.startswith('char ') or
                line_stripped.startswith('string ') or
                re.match(r'^[a-zA-Z_][a-zA-Z0-9_]*\s+[a-zA-Z_][a-zA-Z0-9_]*\s*\(', line_stripped)):
                in_user_code = True
            
            if in_user_code:
                user_code_lines.append(line)

        user_code = '\n'.join(user_code_lines)
        total_ops, operator_details = count_operators(user_code)

        return total_ops, operator_details, user_code

    except Exception as e:
        print(f"Error reading file: {e}", file=sys.stderr)
        return 0, {}, ""


def main():
    if len(sys.argv) != 2:
        print("Usage: python operator_counter.py <cpp_file>")
        sys.exit(1)

    file_path = sys.argv[1]
    if not os.path.exists(file_path):
        print(f"Error: File '{file_path}' not found")
        sys.exit(1)

    total_ops, operator_details, user_code = analyze_cpp_file(file_path)
    
    print(f"File: {file_path}")
    print("=" * 60)
    print("OPERATOR COUNT RESULTS:")
    print(f"Total Operators: {total_ops}")
    print()
    print("Breakdown by operator:")
    print("-" * 60)
    
    # Sort operators by count (descending)
    sorted_ops = sorted(operator_details.items(), key=lambda x: x[1], reverse=True)
    
    for op, count in sorted_ops:
        print(f"  {op:<15} : {count:>3} occurrences")
    
    print("=" * 60)
    print()
    print("Notes:")
    print("  - '<<' operators used with 'cout' are EXCLUDED")
    print("  - 'cin >>' chains count as ONE operator per chain")
    print("  - '&&' counts as ONE logical AND operator")
    print("  - '||' counts as ONE logical OR operator")
    print("  - All other operators are counted normally")
    print("=" * 60)
    
    if user_code and '--show-code' in sys.argv:
        print()
        print("Code analyzed:")
        print("-" * 60)
        print(user_code)
        print("-" * 60)


if __name__ == "__main__":
    main()