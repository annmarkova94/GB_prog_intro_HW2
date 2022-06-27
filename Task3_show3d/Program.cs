Console.Write("Write your number: ");
int numberX = int.Parse(Console.ReadLine());
string numberX_str = Convert.ToString(numberX);

if (numberX_str.Length < 3) Console.Write("This number does not have the 3d digit");
else Console.Write(numberX_str[2]);
