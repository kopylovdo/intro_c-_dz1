﻿Console.WriteLine("Please, enter N ");
int N = int.Parse(Console.ReadLine());

int index = 1;

while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.Write(index + ", ");
    }
    index++;
}
Console.WriteLine();
