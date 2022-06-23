using System;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Operators Exercises
//Task 1
//int number = int.Parse(Console.ReadLine());

//if (number % 2 == 0)
//{
//    Console.WriteLine($"The number is {number} is even");
//}
//else
//{
//    Console.WriteLine($"The number is {number} is odd");
//}

//Task 2 
int a = 4;
int b = 6;
int resultRectangleArea = 2 * (a + b);

// Task 3

// given number is devided only to itself and to one with no reminder 2,3,5



Console.WriteLine("Accept number:");
int number = int.Parse(Console.ReadLine());

if (IsPrime(number))
{
    Console.WriteLine("It is prime");
}
else
{
    Console.WriteLine("It is not prime");
}

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}

