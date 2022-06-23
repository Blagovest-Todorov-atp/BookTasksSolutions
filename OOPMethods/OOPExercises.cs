using System.Globalization;

namespace OOPMethods
{
    internal class ClassesAndObjectsExercises
    {
        static void Main(string[] args)
        {
            //Methods -> Solution Task 1 and 2

            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            ////GetMax(5,15);
            //double resultBiggerNum = GetMax(a, b);
            //Console.WriteLine(resultBiggerNum);

            //string s = new string('*', 5);
            //Console.WriteLine(s);
            
            //Task 1.   Write a program that generates and prints to the console 
            //          10 random values in the range[100, 200].

            Random randomNum = new Random(); ///this is not a perfect solution

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(randomNum.Next(100, 201));
            }

            //Task 2.
            //2.Write a program that prints to the console which day of the week is today.Use
            //System.DateTime
            Console.WriteLine();
            Console.Write("Today is : ");

            var currDay = DateTime.Today.DayOfWeek;
            Console.WriteLine(currDay);           
            
        } 

        static double GetMax(double a, double b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }


    }
}