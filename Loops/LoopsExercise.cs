namespace Loops
{
    internal class LoopsExercise
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Task 1            

            for (int i = 1; i <= 30; i++)
            {
                Console.Write(i + " ");
            }  
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Task 2          

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 7 == 0 )
                {
                    continue;
                }

                Console.Write(i + " ");
            }
        }
    }
}