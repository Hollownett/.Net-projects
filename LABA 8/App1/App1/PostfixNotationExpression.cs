using System;
using System.Collections.Generic;


public class PostfixNotationExpression
{
    public PostfixNotationExpression()
    {
        operators = new List<string>(standart_operators);

    }
    private List<string> operators;
    private List<string> standart_operators =
        new List<string>(new string[] { "(", ")", "+", "-", "*", "/", "^", "sqrt", "Exp", "sqr", "pow10", "log", "sin", "cos", "tan", "%", "fact","cube" });

    private IEnumerable<string> Separate(string input)
    {
        int pos = 0;
        while (pos < input.Length)
        {
            string s = string.Empty + input[pos];
            if (!standart_operators.Contains(input[pos].ToString()))
            {
                if (Char.IsDigit(input[pos]))
                    for (int i = pos + 1; i < input.Length &&
                        (Char.IsDigit(input[i]) || input[i] == ',' || input[i] == '.'); i++)
                        s += input[i];
                else if (Char.IsLetter(input[pos]))
                    for (int i = pos + 1; i < input.Length &&
                        (Char.IsLetter(input[i]) || Char.IsDigit(input[i])); i++)
                        s += input[i];
            }
            yield return s;
            pos += s.Length;
        }
    }
    private byte GetPriority(string s)
    {
        switch (s)
        {
            case "(":
            case ")":
                return 0;
            case "+":
            case "-":
                return 1;
            case "*":
            case "/":
            case "Mod":
                return 2;
            case "^":
                return 3;
            default:
                return 4;
        }
    }

    public string[] ConvertToPostfixNotation(string input)
    {
        List<string> outputSeparated = new List<string>();
        Stack<string> stack = new Stack<string>();
        foreach (string c in Separate(input))
        {
            if (operators.Contains(c))
            {
                if (stack.Count > 0 && !c.Equals("("))
                {
                    if (c.Equals(")"))
                    {
                        string s = stack.Pop();
                        while (s != "(")
                        {
                            outputSeparated.Add(s);
                            s = stack.Pop();
                        }
                    }
                    else if (GetPriority(c) > GetPriority(stack.Peek()))
                        stack.Push(c);
                    else
                    {
                        while (stack.Count > 0 && GetPriority(c) <= GetPriority(stack.Peek()))
                            outputSeparated.Add(stack.Pop());
                        stack.Push(c);
                    }
                }
                else
                    stack.Push(c);
            }
            else
                outputSeparated.Add(c);
        }
        if (stack.Count > 0)
            foreach (string c in stack)
                outputSeparated.Add(c);

        return outputSeparated.ToArray();
    }
    public int fact(int a)
    {

        int rez = 1;

        for (int i = 1; i <= a; i++) rez = rez * i;
        return rez;
    }
    public decimal result(string input)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>(ConvertToPostfixNotation(input));
        string str = queue.Dequeue();
        while (queue.Count >= 0)
        {
            if (!operators.Contains(str))
            {
                stack.Push(str);
                try
                {
                    str = queue.Dequeue();
                }
                catch (System.InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                decimal summ = 0;



                switch (str)
                {

                    case "fact":
                        {
                            double a = Convert.ToDouble(stack.Pop());
                            int rez = Convert.ToInt32(a);

                            if (Convert.ToDouble(rez) == a)
                                summ = fact(rez);
                            else
                                summ = Convert.ToDecimal(Math.Exp(Math.Log(fact(Convert.ToInt32(a))) + (rez - a) * Math.Log(rez + 1)));




                            break;
                        }
                    case "%":
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());

                            summ = b % a;

                            break;
                        }

                    case "tan":
                        {

                            summ = Convert.ToDecimal(Math.Atan(Convert.ToDouble(stack.Pop())));

                            break;
                        }
                    case "cos":
                        {

                            summ = Convert.ToDecimal(Math.Acos(Convert.ToDouble(stack.Pop())));

                            break;
                        }
                    case "sin":
                        {

                            summ = Convert.ToDecimal(Math.Asin(Convert.ToDouble(stack.Pop())));

                            break;
                        }

                    case "pow10":
                        {


                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = Convert.ToDecimal(Math.Pow(Convert.ToDouble(b), 10));
                            break;
                        }
                    case "log":
                        {

                            summ = Convert.ToDecimal(Math.Log(Convert.ToDouble(stack.Pop())));

                            break;
                        }
                    case "Exp":
                        {

                            summ = Convert.ToDecimal(Math.Exp(Convert.ToDouble(stack.Pop())));

                            break;
                        }
                    case "sqr":
                        {


                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = Convert.ToDecimal(Math.Pow(Convert.ToDouble(b), 2));
                            break;
                        }
                    case "cube":
                        {


                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = Convert.ToDecimal(Math.Pow(Convert.ToDouble(b), 3));
                            break;
                        }
                    case "sqrt":
                        {

                            summ = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(stack.Pop())));

                            break;
                        }
                    case "+":
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = a + b;
                            break;
                        }
                    case "-":
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = b - a;
                            break;
                        }
                    case "*":
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = b * a;
                            break;
                        }
                    case "/":
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = b / a;
                            break;
                        }
                    case "^":
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = Convert.ToDecimal(Math.Pow(Convert.ToDouble(b), Convert.ToDouble(a)));
                            break;
                        }
                }
            
                
                stack.Push(summ.ToString());
                if (queue.Count > 0)
                    str = queue.Dequeue();
                else
                    break;
            }

        }
        return Convert.ToDecimal(stack.Pop());
    }
}


