Console.Write("Write a 3-digit number: ");
int numberX = int.Parse(Console.ReadLine());
while (numberX < 100 || numberX > 999)
{
    Console.Write("Number of digits does not equal 3, try again: ");
    numberX = int.Parse(Console.ReadLine());
}
Console.Write($"The second digit of your 3-digit number {numberX} is {numberX % 100 / 10}");
