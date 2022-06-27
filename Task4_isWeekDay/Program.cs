Console.Write("Write the number of the day: ");
int weekNumber = int.Parse(Console.ReadLine());

//if (weekNumber <= 0 || weekNumber > 7) Console.WriteLine("Day number is out of range, try again")

while (weekNumber <= 0 || weekNumber > 7)
{
    Console.Write("Your day number is out of range, try again\nWrite the number of the day: ");
    //Console.Write("Write the number of a day: ");
    weekNumber = int.Parse(Console.ReadLine());
}

if (weekNumber == 6 || weekNumber == 7) Console.WriteLine("This is the weekend! Go have fun!");
else Console.WriteLine("This is a workday");
