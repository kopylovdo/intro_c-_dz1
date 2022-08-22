Console.WriteLine("Please, enter num1 ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Please, enter num2 ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Please, enter num3 ");
int numC = int.Parse(Console.ReadLine());

int max = numA;

if (numB > max)
{
    max = numB;
}

if (numC > max)
{
    max = numC;
}

Console.WriteLine("Maximum is - " + max);