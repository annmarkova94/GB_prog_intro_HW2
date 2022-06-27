Console.Write("Write a 3-digit number: ");
int numberX = int.Parse(Console.ReadLine());

Console.Write($"Second digit is: {numberX % 100 / 10}");
