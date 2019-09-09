public class Postfix
{
    public static String convertToPostfix(String infix)
    {
        StackInterface<Character> operatorStack = new LinkedStack<>();

        // use a StringBuilder object rather than a String, since appending is much more efficient.
        // To add to the StringBuilder object 'postfix':
        // postfix.append(stringToAppend);
        StringBuilder postfix = new StringBuilder();
        int length = infix.length();
        for(int i = 0; i < length; i++)
        {
            char nextCharacter = infix.charAt(i);
            if(isVariable(nextCharacter))
            {
                // TODO
            }
            else
            {
                switch(nextCharacter)
                {
                    // TODO
                    default:
                        break;
                }
            }
        }

        return postfix.toString();
    }

    public static int evaluatePostfix(String postfix)
    {
        // TODO
        return 0;
    }

    private static int getValue(Character c)
    {
        switch(c)
        {
            case 'a':
                return 2;
            case 'b':
                return 3;
            case 'c':
                return 4;
            case 'd':
                return 5;
            case 'e':
                return 6;
            default:
                return 0;
        }
    }


    private static int performOperation(int operandOne, int operandTwo, char operator)
    {
        // TODO
        return 0;
    }

    private static int getPrecedence(char operator)
    {
        switch (operator)
        {
            case '(': case ')': return 0;
            case '+': case '-': return 1;
            case '*': case '/': return 2;
            case '^':           return 3;
        }
        return -1;
    }

    private static boolean isOperator(char c)
    {
        return (c == '+' || c == '-' || c == '*' || c == '/' || c == '^');
    }

    private static boolean isVariable(Character c)
    {
        return Character.isLetter(c);
    }
}