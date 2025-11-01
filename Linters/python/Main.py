class CantBeNegative(Exception):
    def __init__(self, number):
        super().__init__(f"{number} is negative")


def foo(x):
    if x < 0:
        raise CantBeNegative(x)