import ast
import sys
import os

class OperationCounter(ast.NodeVisitor):
    def __init__(self):
        self.total = 0

    # Binary operations
    def visit_BinOp(self, node):
        if isinstance(node.op, (ast.Add, ast.Sub, ast.Mult, ast.Div, ast.Mod, ast.Pow, ast.FloorDiv)):
            self.total += 1
        elif isinstance(node.op, (ast.BitAnd, ast.BitOr, ast.BitXor, ast.LShift, ast.RShift)):
            self.total += 1
        self.generic_visit(node)

    # Unary operations
    def visit_UnaryOp(self, node):
        if isinstance(node.op, (ast.UAdd, ast.USub)):
            self.total += 1
        elif isinstance(node.op, ast.Invert):
            self.total += 1
        elif isinstance(node.op, ast.Not):
            self.total += 1
        self.generic_visit(node)

    # Boolean comparisons
    def visit_Compare(self, node):
        self.total += len(node.ops)  # multiple comparisons count
        self.generic_visit(node)

    # Boolean operations (and/or)
    def visit_BoolOp(self, node):
        self.total += 1
        self.generic_visit(node)

def count_operations_in_file(file_path):
    """Count operations in a Python file"""
    try:
        with open(file_path, 'r', encoding='utf-8') as file:
            code = file.read()
        
        tree = ast.parse(code)
        counter = OperationCounter()
        counter.visit(tree)
        
        return counter.total
        
    except FileNotFoundError:
        print(f"Error: File '{file_path}' not found")
        return -1
    except SyntaxError as e:
        print(f"Error: Syntax error in file - {e}")
        return -1
    except Exception as e:
        print(f"Error: {e}")
        return -1

def main():
    if len(sys.argv) != 2:
        print("Usage: python operation_counter.py <python_file>")
        print("Example: python operation_counter.py my_script.py")
        sys.exit(1)
    
    file_path = sys.argv[1]
    
    if not os.path.exists(file_path):
        print(f"Error: File '{file_path}' does not exist")
        sys.exit(1)
    
    if not file_path.endswith('.py'):
        print(f"Warning: '{file_path}' doesn't appear to be a Python file")
    
    total_operations = count_operations_in_file(file_path)
    
    if total_operations >= 0:
        print(f"Total operations in {file_path}: {total_operations}")
    else:
        sys.exit(1)

if __name__ == "__main__":
    main()
