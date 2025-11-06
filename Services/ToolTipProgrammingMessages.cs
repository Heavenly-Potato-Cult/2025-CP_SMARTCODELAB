using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Services
{
    public class ToolTipProgrammingMessages
    {
        public static readonly Dictionary<string, string> javaExplanations = new Dictionary<string, string>()
{
    // ========== MAINTAINABILITY ==========
    { "NestedForDepth", "Too many loops inside each other make code hard to follow and maintain. Try breaking parts into smaller functions." },
    { "NestedIfDepth", "Deeply nested 'if' statements are hard to read and debug. Use early returns or helper methods instead." },
    { "NestedTryDepth", "Many nested 'try-catch' blocks make error handling messy. Handle errors in one place if possible." },
    { "BooleanExpressionComplexity", "Complex conditions are confusing. Split them into smaller parts or use helper functions for clarity." },
    { "UnusedLocalVariable", "Unused variables take up space and confuse readers. Remove them to keep code clean." },
    { "ParameterNumber", "Methods with too many parameters are hard to use and remember. Group related ones into objects or use fewer parameters." },
    { "ReturnCount", "Having too many return statements can make it unclear how a function ends. Use one or two clear return points." },
    { "OverloadMethodsDeclarationOrder", "Keep overloaded methods together so it's easier to find related versions of a function." },
    { "ParameterAssignment", "Changing the value of a parameter inside a method can cause confusion. Use a new variable instead." },
    { "RequireThis", "Using 'this.' helps make it clear you’re referring to a class field, not a local variable." },
    { "DefaultComesLast", "Always put 'default' last in a 'switch' to make it predictable and easier to understand." },
    { "MultipleVariableDeclarations", "Declaring several variables in one line makes errors harder to spot. Write each variable on its own line." },
    { "UnusedCatchParameterShouldBeUnnamed", "Don’t name a variable you won’t use—it keeps your code cleaner and clearer." },

    // ========== READABILITY ==========
    { "SimplifyBooleanReturn", "Returning true or false directly is simpler and easier to read. Example: use 'return a > b;' instead of 'if (a > b) return true;'." },
    { "SimplifyBooleanExpression", "Simplify logic when possible. For example, use 'a == b' instead of 'not a != b'." },
    { "GenericWhitespace", "Consistent spacing makes code cleaner and easier to read." },
    { "MethodParamPad", "Add spaces around parameters to improve readability." },
    { "NoWhitespaceAfter", "Extra spaces after symbols can make code look messy. Keep spacing consistent." },
    { "NoLineWrap", "Avoid breaking code lines in random places—it makes code flow easier to follow." },
    { "NoWhitespaceBefore", "Don’t add unnecessary spaces before punctuation (like commas or semicolons)." },
    { "NoWhitespaceBeforeCaseDefaultColon", "Keep spacing consistent in switch statements to make them clear." },
    { "OperatorWrap", "Keep operators (like +, -, &&) on the same line for easier reading." },
    { "ParenPad", "Don’t add spaces just inside parentheses. It looks cleaner as 'if (x > y)' not 'if ( x > y )'." },
    { "SeparatorWrap", "Keep separators like commas or pipes in consistent positions for better readability." },
    { "SingleSpaceSeparator", "Use only one space between words or tokens for a clean look." },
    { "TypecastParenPad", "Don’t put spaces between type casts and variables, e.g., '(int)x' not '(int) x'." },
    { "Indentation", "Proper indentation helps others understand which code belongs to which block." },
    { "CommentsIndentation", "Align comments with the code they describe for clarity." },
    { "AbbreviationAsWordInName", "Don’t use short or confusing abbreviations in names. Use full words so others understand easily." },
    { "CatchParameterName", "Use clear names for exception variables (like 'e' or 'ex') to show what’s being caught." },
    { "ConstantName", "Write constants in ALL_CAPS to show they never change." },
    { "InterfaceTypeParameterName", "Keep type parameter names consistent so your code is predictable." },
    { "LambdaParameterName", "Use clear names in lambda expressions to show what the variable means." },
    { "LocalFinalVariableName", "Follow naming rules for local constants to keep code consistent." },
    { "LocalVariableName", "Use descriptive names like 'count' or 'total', not single letters." },
    { "MemberName", "Keep field names consistent so others can quickly understand class structure." },
    { "MethodName", "Use meaningful verbs for method names, like 'calculateTotal()' instead of 'ct()'." },
    { "ParameterName", "Parameters should describe what data they hold, like 'age' or 'name'." },
    { "PatternVariableName", "Choose variable names that explain what’s being matched." },
    { "StaticVariableName", "Follow consistent naming so it’s clear which variables are shared across all objects." },
    { "UnusedImports", "Remove imports you don’t use—they clutter your file." },
    { "OneStatementPerLine", "Each line should do one thing—makes code easier to follow." },
    { "EmptyStatement", "Empty code blocks can confuse others. Remove them if they do nothing." },
    { "UnnecessaryParentheses", "Remove extra parentheses that don’t change meaning—they make code look more complicated." },
    { "UnnecessarySemicolonAfterTypeMemberDeclaration", "Extra semicolons don’t do anything and look untidy." },
    { "UnnecessarySemicolonInTryWithResources", "Avoid useless semicolons—they can confuse beginners reading your code." },

    // ========== ROBUSTNESS ==========
    { "BrokenNullCheck", "Avoid checking for null incorrectly. A broken null check can cause your program to crash unexpectedly if the order or logic is wrong." },
    { "CompareObjectsWithEquals", "When comparing objects, use .equals() instead of '=='. The '==' operator checks if two objects are the same in memory, not if they have the same value." },
    { "EqualsNull", "Never call .equals() on a variable that might be null. It can cause a NullPointerException. Instead, check 'if (variable == null)' first." },
    { "MisplacedNullCheck", "Make sure your null checks happen before using the variable. Doing it after using the variable makes the check useless." },
    { "UnusedNullCheckInEquals", "Avoid unnecessary null checks inside equals() methods. They can make the code confusing and don’t actually prevent errors." },
    { "ReturnEmptyCollectionRatherThanNull", "Instead of returning null from a method that returns a collection, return an empty list or set. This prevents NullPointerExceptions when iterating." },
    { "UseEqualsToCompareStrings", "When comparing strings, always use .equals() instead of '=='. The '==' operator only checks if they are the same object, not if their text is the same." }
};

        public static readonly Dictionary<string, string> pythonRuffRules = new Dictionary<string, string>()
        {
            // 🟨 READABILITY RULES
            { "RET504", "Unnecessary assignment before return. Return the value directly for simpler code." },
            { "PLR6104", "Use augmented assignments (+=, *=, etc.) instead of full assignments for clarity." },
            { "RUF018", "Avoid assignment expressions in assert statements; it makes tests harder to read." },
            { "FURB187", "Avoid assigning reversed() to a variable. Use it directly for clarity." },
            { "E301", "Expected blank line between functions or classes to visually separate code sections." },
            { "SIM102", "Combine nested if statements into one for easier-to-read logic." },
            { "SIM202", "Use 'a == b' instead of 'not a != b' for better readability." },
            { "PLR2044", "Avoid empty comments. They add no value and clutter the code." },
            { "B033", "Avoid duplicate values in a set; it’s redundant and confusing." },
            { "SIM101", "Merge multiple isinstance() calls into one for cleaner type checking." },
            { "PLR2004", "Avoid magic numbers in comparisons. Use constants for clearer meaning." },
            { "E201", "Avoid extra space after an opening bracket (like '(' or '['). Extra spaces make code look uneven. [E201]" },
            { "E202", "Avoid space before a closing bracket (like ')' or ']'). It should be right next to the last item. [E202]" },
            { "E203", "Avoid adding spaces before punctuation such as commas or colons. [E203]" },
            { "E211", "Avoid placing a space before the opening parenthesis when calling a function. Example: use 'func(x)' not 'func (x)'. [E211]" },
            { "E225", "Add spaces around operators (like =, <, >) to make expressions easier to read. [E225]" },
            { "E226", "Add spaces around arithmetic operators (+, -, *, /) to improve readability. [E226]" },
            { "E227", "Add spaces around bitwise or shift operators (<<, >>, |) to make code clearer. [E227]" },
            { "E228", "Add spaces around modulo operators (%) to keep formatting consistent. [E228]" },
            { "E231", "Add a space after commas or colons to separate items clearly. [E231]" },
            { "E252", "Add spaces around the '=' sign in function parameters for readability. [E252]" },
            { "E275", "Add a space after Python keywords like 'if', 'for', or 'while'. [E275]" },
            { "E306", "Leave one blank line before defining a nested function to make code sections clearer. [E306]" },
            { "E114", "Comment indentation should align properly; use multiples of the standard indent width. [E114]" },
            { "E115", "Indented blocks should include properly indented comments, not ones aligned to the margin. [E115]" },
            { "E116", "Comment indentation should match the surrounding code block level. [E116]" },
            { "W291", "Remove spaces or tabs at the end of a line — they serve no purpose and clutter code. [W291]" },
            { "W293", "Remove spaces on blank lines. Blank lines should be truly empty. [W293]" },
            { "E702", "Avoid writing multiple statements on one line separated by a semicolon (;). Each statement should be on its own line for clarity. [E702]" },
            { "E701", "Avoid writing multiple statements on one line after a colon (:). Put each statement on its own line so it’s easier to read. [E701]" },
            { "N801", "Class names should use CapitalizedWords (also called CapWords). Example: use 'StudentRecord', not 'studentrecord' or 'student_Record'. [N801]" },
            { "N802", "Function names should be written in lowercase with underscores if needed. Example: use 'calculate_total()', not 'CalculateTotal()'. [N802]" },
            { "N803", "Argument names should be lowercase. Example: use 'price' instead of 'Price'. [N803]" },
            { "N804", "The first argument of a class method should always be named 'cls'. This helps show it refers to the class itself. [N804]" },
            { "N805", "The first argument of an instance method should always be named 'self'. This refers to the object the method is called on. [N805]" },
            { "N806", "Variables inside functions should be lowercase. Example: use 'count', not 'Count'. [N806]" },
            { "N807", "Avoid naming functions with double underscores at the start and end (like '__init__'). These are reserved for Python’s special methods. [N807]" },
            { "N811", "Constants (ALL_CAPS) should not be imported using a different naming style. Keep the uppercase to show it’s a constant. [N811]" },
            { "N812", "Lowercase names should stay lowercase when imported. Don’t rename them to uppercase or CamelCase. [N812]" },
            { "N813", "CamelCase names (like 'StudentData') should not be imported as lowercase. Keep their original format for clarity. [N813]" },
            { "N814", "CamelCase names should not be renamed to look like constants (ALL_CAPS). That causes confusion about what they are. [N814]" },
            { "N815", "Variables defined inside a class should not use mixedCase (like 'myVariable'). Use lowercase_with_underscores instead. [N815]" },
            { "N816", "Global variables should not use mixedCase. Stick to lowercase_with_underscores for consistency. [N816]" },
            { "N817", "CamelCase names should not be imported as acronyms (like 'MyClass' as 'MC'). It hides meaning and reduces clarity. [N817]" },
            { "N818", "Exception class names should end with 'Error'. Example: 'InputError' or 'FileNotFoundError'. This shows it’s an exception. [N818]" },
            { "N999", "Module (file) names should be all lowercase. Example: use 'student_data.py', not 'StudentData.py'. [N999]" },

            // 🟦 MAINTAINABILITY RULES
            { "F823", "Variable used before assignment. Always assign a variable before using it." },
            { "PLW0642", "Avoid reassigning 'self' or 'cls' inside class methods; it breaks expected behavior." },
            { "F406", "Avoid 'from module import *'; it hides where names come from and complicates debugging." },
            { "B014", "Avoid handling the same exception twice in a try block; it’s redundant." },
            { "B025", "Avoid duplicate exception types in try-except blocks; duplicates are ignored." },
            { "PIE794", "Class field is defined multiple times. Later definitions overwrite earlier ones." },
            { "PYI062", "Avoid duplicate literal members in classes; it causes confusion and redundancy." },
            { "PLE0241", "Duplicate base class in inheritance; remove redundant base to simplify hierarchy." },
            { "PLR0913", "Too many parameters in function definition; refactor to simplify and improve reusability." },
            { "PLR0911", "Too many return statements in function; simplify logic for easier maintenance." },
            { "PLR0915", "Too many statements in function; break it into smaller, manageable parts." },
            { "ARG001", "Unused function argument detected; remove unused arguments for cleaner code." },
            { "ARG002", "Unused method argument detected; consider removing it for better clarity." },
            { "ARG003", "Unused class method argument; clean it up to improve readability and maintainability." },
            { "ARG004", "Unused static method argument; can be safely removed." },
            { "ARG005", "Unused lambda argument; unused parameters make code harder to follow." },

            // ROBUSTNESS RULES
            { "F632", "Use '==' to compare constant literals instead of 'is'. Using 'is' compares object identity, not value equality." },
            { "E721", "Use 'is' or 'is not' for type checks, or 'isinstance()' when checking variable types. It prevents unexpected behavior." },
            { "E722", "Avoid bare 'except' clauses. Always catch specific exceptions so you don't hide real errors." },
            { "TRY002", "Create your own custom exception classes for clarity and better error handling." },
            { "TRY003", "Avoid putting long error messages outside the exception class. Keep exception messages short and meaningful." },
            { "TRY004", "Prefer raising 'TypeError' when a function receives an argument of the wrong type. It’s the standard in Python." },
            { "TRY201", "When re-raising an exception, just use 'raise' instead of specifying the exception name again." },
            { "TRY203", "Remove exception handler if it immediately re-raises the same error; it serves no purpose." },
            { "TRY300", "Consider moving code that runs only when no exception occurs into an 'else' block for clearer logic." },
            { "TRY301", "Move repeated raise statements into a helper function to make the code cleaner and reduce duplication." }
        };

    }
}
