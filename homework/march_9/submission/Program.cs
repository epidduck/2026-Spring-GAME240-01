
int[] numbers;
numbers = new int[] {-5, 20, 100, 10, 35};
int smallest = numbers[0];
int biggest = numbers[0];
int CurrentSmallest;
int CurrentBiggest;

int i;
i = 0;
while (i < numbers.Length - 1)
{
   if (i < i + 1) ;
   {
      CurrentSmallest = numbers[i];
      CurrentBiggest = numbers[i + 1];
   }
   if (i > i + 1) ;
   {
      CurrentBiggest = numbers[i];
      CurrentSmallest = numbers[i + 1];
   }
   if (CurrentSmallest < smallest)
   {
      smallest = CurrentSmallest;
   }

   if (CurrentBiggest > biggest)
   {
      biggest = CurrentBiggest;
   }
   i++;
}

Console.Write("The largest number is " + biggest + ". ");
Console.Write("The smallest number is " + smallest + ".");




