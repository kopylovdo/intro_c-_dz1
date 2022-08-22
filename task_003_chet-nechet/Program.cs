Console.WriteLine("Please, enter number ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine(number + " chetnoe chislo");
}
else
{
    Console.WriteLine(number + " nechetnoe chislo");
}