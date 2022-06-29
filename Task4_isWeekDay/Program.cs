//Take a number from the user and print out if the corresponding day of the week is a workday
Console.Write("Write the number of the day: ");
int weekNumber = int.Parse(Console.ReadLine());

while (weekNumber <= 0 || weekNumber > 7)
{
    Console.Write("Your day number is out of range, try again\nWrite the number of the day: ");
    weekNumber = int.Parse(Console.ReadLine());
}

if (weekNumber == 6 || weekNumber == 7) Console.WriteLine("This is the weekend! Go have fun!");
else Console.WriteLine("This is a workday");
