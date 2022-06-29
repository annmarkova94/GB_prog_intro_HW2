//Generate a 3-digit random number, delete the second digit and print out
int numberX = new Random().Next(100, 1000);
Console.WriteLine($"The random 3-digit number: {numberX}");

Console.WriteLine($"This number if we delete the 2nd digit: {numberX / 100 * 10 + numberX % 10}");
