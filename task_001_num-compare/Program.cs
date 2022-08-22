Console.WriteLine("Please, enter num1 ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Please, enter num2 ");
int numB = int.Parse(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine(numA + " larger than " + numB);
}
else
{
    Console.WriteLine(numB + " larger than " + numA);
}