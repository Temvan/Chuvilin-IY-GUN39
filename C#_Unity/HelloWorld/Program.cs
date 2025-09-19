class Program
{
    static void Main(string[] args)
    {

        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Input string is not a number");
            return;
        }

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Input string is not a number");
            return;
        }

        var s = Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)
        {
            Console.WriteLine("Input string is not a symbol");
            return;
        }

        int result = 0;
        switch (s[0])
        {
            case '+':
                result = a + b;
                Console.WriteLine("Result of {0} + {1}:", a, b);
               
                break;
            case '-':
                result = a - b;
                Console.WriteLine("Result of {0} - {1}:", a, b);
              
                break;
            case '*':
                result = a * b;
                Console.WriteLine("Result of {0} * {1}:", a, b);
              
                break;
            case '/':
                result = a / b;
                Console.WriteLine("Result of {0} / {1}:", a, b);
                
                break;
            case '%':
                result = a % b;
                Console.WriteLine("Result of {0} % {1}:", a, b);
             
                break;
            case '^':
                result = a ^ b;
                Console.WriteLine("Result of {0} ^ {1}:", a, b);
               
                break;
            case '&':
                result = a & b;
                Console.WriteLine("Result of {0} & {1}:", a, b);
              
                break;
            case '|':
                result = a | b;
                Console.WriteLine("Result of {0} | {1}:", a, b);
              
                break;
            default:
                Console.WriteLine("Unknown operation");
                break;
        }
                Console.WriteLine("Decimal: {0}", result);
                Console.WriteLine("Binary: {0}", Convert.ToString(result, 2));
                Console.WriteLine("Hex: {0}", Convert.ToString(result, 16).ToUpper());
    }
}


