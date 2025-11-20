#!/usr/bin/env python3
"""
Python Syntax Checker
Usage: python check_syntax.py <filename>
"""

import sys
import py_compile
import ast

def main():
    if len(sys.argv) != 2:
        print("Usage: python check_syntax.py <filename>")
        sys.exit(1)
    
    filename = sys.argv[1]
    
    try:
        # Method 1: Using py_compile (compiles to bytecode)
        py_compile.compile(filename, doraise=True)
        
        # Method 2: Using ast.parse (more detailed error info)
        with open(filename, 'r', encoding='utf-8') as f:
            code = f.read()
        
        ast.parse(code, filename=filename)
        
        sys.exit(0)
        
    except py_compile.PyCompileError as e:
        error_info = e.exc_value
        
        if hasattr(error_info, 'lineno') and error_info.lineno:
            print(error_info.lineno - 1)
            print(error_info.msg)
        else:
            print("0")  # Default to line 1 if no line info
            print(e.msg)
        
        sys.exit(1)
        
    except SyntaxError as e:
        print(e.lineno - 1)
        print(e.msg)
        sys.exit(1)
        
    except FileNotFoundError:
        print("0")
        print(f"File '{filename}' not found")
        sys.exit(1)
        
    except Exception as e:
        print("0")
        print(f"{type(e).__name__}: {e}")
        sys.exit(1)

if __name__ == "__main__":
    main()