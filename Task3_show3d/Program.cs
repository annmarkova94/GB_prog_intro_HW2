//Take a number and show it's 3rd digit or say that there in no 3rd digit
Console.Write("Write your number: ");
int numberX = int.Parse(Console.ReadLine());
string numberX_str = Convert.ToString(numberX);

if (numberX_str.Length < 3) Console.Write("This number does not have the 3d digit");
else Console.Write($"The 3rd digit of your number is {numberX_str[2]}");
