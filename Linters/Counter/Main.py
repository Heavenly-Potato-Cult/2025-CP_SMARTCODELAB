def count_twos_efficient(number_string):
    """Counts the digit '2' in a number string using the fast built-in count() method."""
    
    # Use the highly optimized built-in string method
    return number_string.count('2')

# Example usage:
long_number = "123245678290123452678901234567890123456789012" * 10000

# Expected: 5 twos per small string * 10000 = 50000
print(f"Count (Efficient): {count_twos_efficient(long_number)}")