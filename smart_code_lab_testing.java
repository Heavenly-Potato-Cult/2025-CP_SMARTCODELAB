public class LengthOfLastWord {
    public static void main(String[] args) {
        String  input   =   "Hello World"  ;   // ❌ Extra spaces (GenericWhitespace, SingleSpaceSeparator)
        int result= getLengthOfLastWord( input ) ;  // ❌ ParenPad and NoWhitespaceBefore
        System.out.println(   "Length of last word: " +  result ); // ❌ Unnecessary spacing
    }

    public static int getLengthOfLastWord( String s ) { // ❌ ParenPad (spaces after/before parentheses)
        if(s == null || s.trim( ).isEmpty( ))  { // ❌ ParenPad, NoWhitespaceAfter, MethodParamPad
            return 0 ;  // ❌ Extra space before semicolon (NoWhitespaceBefore)
        } 
        String[] words =  s.trim( ).split(" ") ; // ❌ Extra spaces and ParenPad
        String lastWord=words[ words.length - 1 ]; // ❌ Extra space inside brackets (GenericWhitespace)
        return ( lastWord.length( ) ); // ❌ UnnecessaryParentheses, ParenPad
    } 
}

//maintainability
public class LastWordLength {

    // Magic numbers used (violates MagicNumber)
    private static final int SOME_VALUE = 3;

    public static void main(String[] args) {
        String input = "Hello World";
        System.out.println(getLastWordLength(input, 1, 2, 3, 4, 5)); // too many parameters
    }

    // Violates: ParameterNumber (more than 4 parameters)
    public static int getLastWordLength(String s, int a, int b, int c, int d, int e) {

        int unusedVar = 10; // UnusedLocalVariable

        int result = 0;
        try {
            // Violates NestedTryDepth
            try {
                if (s != null) {
                    // Violates NestedIfDepth (too many nested ifs)
                    if (s.length() > 0) {
                        if (!s.isEmpty()) {
                            if (s.endsWith(" ")) {
                                s = s.trim();
                            }
                        }
                    }
                }

                // MagicNumber violation (using a literal directly)
                for (int i = s.length() - 1; i >= 0; i--) {
                    if (s.charAt(i) == ' ') {
                        result = s.length() - i - 1;
                        break;
                    }
                }

                // Nested for loop to simulate complexity (violates NestedForDepth)
                for (int i = 0; i < SOME_VALUE; i++) {
                    for (int j = 0; j < SOME_VALUE; j++) {
                        if (i == j && s.length() > 2 && s.length() < 20) { // BooleanExpressionComplexity
                            result += 0; // redundant
                        }
                    }
                }

            } catch (Exception e1) {
                try {
                    throw new RuntimeException("Inner try-catch");
                } catch (Exception e2) {
                    System.out.println("Deeply nested try");
                }
            }
        } catch (Exception e) {
            System.out.println("Outer exception");
        }

        return result == 0 ? s.length() : result;
    }
}

