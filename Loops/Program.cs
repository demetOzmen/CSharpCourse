﻿
if (IsPrimaryNumber(6))
{
    Console.WriteLine("This is a prime number.");
}
else
{
    Console.WriteLine("This is  not a prime number.");

}

Console.ReadLine();

static bool IsPrimaryNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;

        }
    }

    return result;
}