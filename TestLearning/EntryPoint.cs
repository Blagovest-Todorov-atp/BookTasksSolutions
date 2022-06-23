using System;
using System.Linq;

namespace TestLearning
{
    class EntryPoint
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); -> Exercises Page 33/ Task 3
            // Console.WriteLine("Hello, Blagovest Todorov");    //  Task 4    

            // PrintThreeNumbers(); 
            // PrintCurrDate();
            Console.WriteLine(PrintSquareOfNumber());


        }

        //Task 5
        public static void PrintThreeNumbers() 
        {
            int[] nums = new int[] { 2, 202, 2002 };

            Console.WriteLine(string.Join(" ",nums));
        }
        //Task 6
        public static void PrintCurrDate() 
        {
            DateTime currDate = DateTime.Now;
            Console.WriteLine(currDate);          
        }

        //Task 7

        public static double PrintSquareOfNumber() 
        {
            long number = 32346;
            return number*number;
           // return Math.Pow(number, 2);
        }

        //Task 

    }
}
