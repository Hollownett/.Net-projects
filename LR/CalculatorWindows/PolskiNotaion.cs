using System;



class ExpressionParser
{
    Calculator calculator = new Calculator();
    private static String operators = "+-*/^";
    private static String delimiters = "() " + operators;
    public static boolean flag = true;
    private static boolean isDelimiter(String token)
    {
        if (token.length() != 1) return false;
        for (int i = 0; i < delimiters.length(); i++)
        {
            if (token.charAt(0) == delimiters.charAt(i)) return true;
        }
        return false;
    }

    private static boolean isOperator(String token)
    {
        if (token.equals("u-")) return true;
        for (int i = 0; i < operators.length(); i++)
        {
            if (token.charAt(0) == operators.charAt(i)) return true;
        }
        return false;
    }

    private static boolean isFunction(String token)
    {


        if (token.equals("sqrt") || token.equals("cube") || token.equals("pow10") || token.equals("sin") || token.equals("cos") || token.equals("tan") || token.equals("sqr")) return true;
        return false;
    }

    private static int priority(String token)
    {
        if (token.equals("(")) return 1;
        if (token.equals("+") || token.equals("-")) return 2;
        if (token.equals("*") || token.equals("/") || token.equals("^")) return 3;
        return 4;
    }

    public static List<String> parse(String infix)
    {
        List<String> postfix = new ArrayList<>();
        Deque<String> stack = new ArrayDeque<>();
        StringTokenizer tokenizer = new StringTokenizer(infix, delimiters, true);
        String prev = "";
        String curr = "";
        while (tokenizer.hasMoreTokens())
        {
            curr = tokenizer.nextToken();
            if (!tokenizer.hasMoreTokens() && isOperator(curr))
            {
                // Calculator calculator = new Calculator();
                // calculator.setText("Error");
                Console.WriteLine("Некорректное выражение.");
                flag = false;
                return postfix;
            }
            if (curr.equals(" ")) continue;
            if (isFunction(curr)) stack.push(curr);
            else if (isDelimiter(curr))
            {
                if (curr.equals("(")) stack.push(curr);
                else if (curr.equals(")"))
                {
                    while (!stack.peek().equals("("))
                    {
                        postfix.add(stack.pop());
                        if (stack.isEmpty())
                        {
                            Console.WriteLine("Скобки не согласованы.");
                            flag = false;
                            return postfix;
                        }
                    }
                    stack.pop();
                    if (!stack.isEmpty() && isFunction(stack.peek()))
                    {
                        postfix.add(stack.pop());
                    }
                }
                else
                {
                    if (curr.equals("-") && (prev.equals("") || (isDelimiter(prev) && !prev.equals(")"))))
                    {
                        // унарный минус
                        curr = "u-";
                    }
                    else
                    {
                        while (!stack.isEmpty() && (priority(curr) <= priority(stack.peek())))
                        {
                            postfix.add(stack.pop());
                        }

                    }
                    stack.push(curr);
                }

            }

            else
            {
                postfix.add(curr);
            }
            prev = curr;
        }

        while (!stack.isEmpty())
        {
            if (isOperator(stack.peek())) postfix.add(stack.pop());
            else
            {
                Console.WriteLine("Скобки не согласованы.");
                flag = false;
                return postfix;
            }
        }
        return postfix;
    }
}

class Ideone
{
    public static Double calc(List<String> postfix)
    {
        Deque<Double> stack = new ArrayDeque<>();
        foreach (String x in postfix)
        {
            if (x.equals("sqrt")) stack.push(Math.sqrt(stack.pop()));
            else if (x.equals("cube"))
            {
                Double tmp = stack.pop();
                stack.push(tmp * tmp * tmp);
            }
            else if (x.equals("sin")) stack.push(Math.sin(stack.pop()));
            else if (x.equals("cos")) stack.push(Math.cos(stack.pop()));
            else if (x.equals("tan")) stack.push(Math.tan(stack.pop()));
            else if (x.equals("^"))
            {
                Double a = stack.pop(), b = stack.pop();
                stack.push(Math.pow(b, a));
            }
            else if (x.equals("sqr"))
            {
                Double c = stack.pop();
                stack.push(c * c);
            }
            else if (x.equals("pow10")) stack.push(Math.pow(10, stack.pop()));
            else if (x.equals("+")) stack.push(stack.pop() + stack.pop());
            else if (x.equals("-"))
            {
                Double b = stack.pop(), a = stack.pop();
                stack.push(a - b);
            }
            else if (x.equals("*")) stack.push(stack.pop() * stack.pop());
            else if (x.equals("/"))
            {
                Double b = stack.pop(), a = stack.pop();
                stack.push(a / b);
            }
            else if (x.equals("u-")) stack.push(-stack.pop());
            else stack.push(Double.valueOf(x));
        }
        return stack.pop();
    }
}