string userA, userB;
double a, b;
string operation;

Console.WriteLine("What is you first number?");
userA = Console.ReadLine();
a = double.Parse(userA);

Console.WriteLine("What is your second number?");
userB = Console.ReadLine();
b = double.Parse(userB);

Console.WriteLine("What operation would you like to do?");
operation = Console.ReadLine();

if (operation == "addition")
{
    Console.WriteLine(a + b);
}
else if (operation == "subtraction")
{
    Console.WriteLine(a - b);
}
else if (operation == "multiplication")
{
    Console.WriteLine(a * b);
}
else if (operation == "division")
{
    Console.WriteLine(a / b);
}
else
{
    Console.WriteLine("Invalid input");
}