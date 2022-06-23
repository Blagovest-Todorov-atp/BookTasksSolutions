namespace ConditionalStatements
{
    internal class CondStatementsExercises
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Task 1

            int a = 1;
            int b = 0;

            if (a > b)
            {
                int c = b;

                b = a;
                a = c;
            }

            //Task 2
            //sign of sum of three real numbers
            //What if the entered numbers are too big and overflows the double type- >exception

            Console.WriteLine("Please enter three real numbers only.");
            Console.WriteLine("If You enter special symbols, letters, text, " +
                " symbols or empty spaces -> the app will not work properly and will crash,then please try again");


            double aNum = double.Parse(Console.ReadLine()); 
            double bNum = double.Parse(Console.ReadLine());
            double cNum = double.Parse(Console.ReadLine());           

            string multProductOf3NumsIsPositive = "Multiplication Product is with positive sign + ";
            string multProductOf3NumsIsNegative = "Multiplication Product is with negative sign -";
            string multProductOfZero = "Multiplication Product of zero is with no sign";


            //if (aNum > 0 && bNum > 0 && cNum > 0) // all nums positive        //  > > >
            //{
            //    Console.WriteLine(multProductOf3NumsIsPositive);          
            //}
            //else if (aNum < 0 && bNum < 0 && cNum < 0)  // all nums negative  //  // < < <
            //{
            //    Console.WriteLine(multProductOf3NumsIsNegative);
            //}
            //else if (aNum < 0 && bNum > 0 && cNum > 0)  // mixed by sign scenarios down
            //{
            //    Console.WriteLine(multProductOf3NumsIsNegative);
            //}
            //else if (aNum > 0 && bNum < 0 && cNum > 0)                     // > < >  than 0
            //{
            //    Console.WriteLine(multProductOf3NumsIsNegative);
            //}
            //else if (aNum > 0 && bNum > 0 && cNum < 0)                     // > > <
            //{
            //    Console.WriteLine(multProductOf3NumsIsNegative);
            //}
            //else if (aNum > 0 && bNum < 0 && cNum < 0)                     // > < <
            //{
            //    Console.WriteLine(multProductOf3NumsIsPositive);
            //}
            //else if (aNum < 0 && bNum > 0 && cNum < 0)                     // < > <
            //{
            //    Console.WriteLine(multProductOf3NumsIsPositive);
            //}
            //else if (aNum < 0 && bNum < 0 && cNum > 0)                      // < < >
            //{
            //    Console.WriteLine(multProductOf3NumsIsPositive);
            //}
            //else if (aNum < 0 && bNum > 0 && cNum > 0)                      // < > >
            //{
            //    Console.WriteLine(multProductOf3NumsIsNegative);
            //}
            //else if (aNum == 0 || bNum == 0 || cNum == 0)                // 0 || 0 || 0
            //{
            //    Console.WriteLine(multProductOfZero);            // BoundaryValues
            //}  

            //think of another solution when count of negative signs is even, then the multiplicationNumber is positive,
            //if the count of negative signs is odd then the sign of multiplication number is negative 

            int countMinusSigns = 0;

            if (aNum == 0 || bNum == 0 || cNum == 0)
            {
                Console.WriteLine(multProductOfZero);
                // Environment.Exit(0);
                return;
            }

            if (aNum < 0)
            {
                countMinusSigns++;
            }

            if (bNum < 0)
            {
                countMinusSigns++;
            }

            if (cNum < 0)
            {
                countMinusSigns++;
            }

            if (aNum > 0 && bNum > 0 && cNum > 0)
            {               
                Console.WriteLine(multProductOf3NumsIsPositive);
                Environment.Exit(0);
               // return;
            }           

            if (countMinusSigns % 2 == 1)
            {
                Console.WriteLine(multProductOf3NumsIsNegative);
            }          
            else if (countMinusSigns % 2 == 0)
            {
                Console.WriteLine(multProductOf3NumsIsPositive);
            }  
        }
    }
}