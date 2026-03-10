// 1.

Console.WriteLine("WHILE LOOP 1");

int counter;
counter = 1;
while (counter <= 5)
{
    Console.WriteLine(counter);
    counter = counter + 1;
}

// 2.
Console.WriteLine("WHILE LOOP 2");

int counter2;
counter2 = 100;
while (counter2 <= 150)
    {
    Console.WriteLine(counter2);
    counter2 = counter2 + 1;
    }

// 3.
Console.WriteLine("WHILE LOOP 3");

int counter3;
counter3 = 0;
while (counter3 <= 100)
    {
    Console.WriteLine(counter3);
    counter3 = counter3 + 2;
    }

// 4.
Console.WriteLine("WHILE LOOP 4");

int counter4;
counter4 = 20;
while (counter4 >= -20)
{
    Console.WriteLine(counter4);
    counter4 = counter4 - 1;
}

// 5.
Console.WriteLine("WHILE LOOP 5");

int counter5;
counter5 = 1;
while (counter5 <= 100)
{
    Console.WriteLine(counter5);
    counter5 = counter5 + 3;
}

// 6.
Console.WriteLine("WHILE LOOP 6");

int counter6;
counter6 = 1;
while (counter6 <= 1024)
    {
    Console.WriteLine(counter6);
    counter6 = counter6 * 2;
    }

// 7.
Console.WriteLine("WHILE LOOP 7");

string userAnswer;
userAnswer = "No";
do
{
    Console.WriteLine("Do you want the loop to stop?");
} while (Console.ReadLine() == userAnswer);

// 8.
Console.WriteLine("WHILE LOOP 8");

bool answer;
answer = true;
while (answer = true)
{
    Console.WriteLine("True");
    Console.WriteLine("False");
}


// 9.
Console.WriteLine("WHILE LOOP 9");

int counter9;
counter9 = 1;
while (counter9 <= 20)
{
    Console.WriteLine(counter9 + " is odd");
    counter9 = counter9 + 1;
    Console.WriteLine(counter9 + " is even");
    counter9 = counter9 + 1;
}

// 10.
Console.WriteLine("WHILE LOOP 10");

int i;
string [] poemWords;
poemWords = new string [] {"once", "upon", "a", "midnight", "dreary"};
i = 0;
while (i < poemWords.Length)
{
    Console.WriteLine(poemWords[i]);
    i = i + 1;
}