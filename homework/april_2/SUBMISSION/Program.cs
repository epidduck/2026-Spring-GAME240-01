  
Console.Write("This calculator can perform 5 operations: ");
Console.Write("addition (+), subtraction (-), multiplication (-), ");
Console.WriteLine("division (/), and modulus (%).");



while (true)
{
    Console.Write("Please type a simple mathematical expression, ");
    Console.WriteLine("or type \"quit\" to shut down the calculator.");
    string equation;
    equation = Console.ReadLine();
    char[] operands = {'+', '-', '*', '/', '%'};

    if (equation.ToLower() == "quit")
    {
        Console.WriteLine("Goodbye.");
        Environment.Exit(0);
    }
    else if (equation.Any(operands.Contains))
    {
        string a, b, c;
        string[] inputs = equation.Split(' ');
        a = inputs[0];
        b = inputs[1];
        c = inputs[2];
        double aDouble = double.Parse(a);
        double cDouble = double.Parse(c);

        if (b == "+")
        {
            double result;
            result = aDouble + cDouble;
            Console.Write(a);
            Console.Write(" + ");
            Console.Write(c);
            Console.Write(" is ");
            Console.WriteLine(result);
        }
        else if (b == "-")
        {
            double result;
            result = aDouble - cDouble;
            Console.Write(a);
            Console.Write(" - ");
            Console.Write(c);
            Console.Write(" is ");
            Console.WriteLine(result);
        }
        else if (b == "*")
        {
            double result;
            result = aDouble * cDouble;
            Console.Write(a);
            Console.Write(" * ");
            Console.Write(c);
            Console.Write(" is ");
            Console.WriteLine(result);
        }
        else if (b == "/" && cDouble != 0)
        {
            double result;
            result = aDouble / cDouble;
            Console.Write(a);
            Console.Write(" / ");
            Console.Write(c);
            Console.Write(" is ");
            Console.WriteLine(result);
        }
        else if (b == "%" && cDouble != 0)
        {
            double result;
            result = aDouble % cDouble;
            Console.Write(a);
            Console.Write(" % ");
            Console.Write(c);
            Console.Write(" is ");
            Console.WriteLine(result);
        }
        else if  (b == "%" && cDouble == 0)
        {
            Console.WriteLine("Does not compute");
        }
        else if  (b == "/" && cDouble == 0)
        {
            Console.WriteLine("Does not compute");
        }
    }
    else
    {
        Console.WriteLine("Not a valid operation.");
    }
}