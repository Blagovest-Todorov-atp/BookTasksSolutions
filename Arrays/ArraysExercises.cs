namespace Arrays
{
    internal class ArraysExercises
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Chapter Array >( See sentence-> Possible syntax Error )

            //List ->indexer like array. T is the type that the list will hold. E.g.,
            //List<T> will hold integers while -> correct is -> List<int> will hold integers // /page 47 of pdf File
            //or page 35 of book Page File;

            // Task One

            int[] intArrayContaining20Numbers = new int[20];

            for (int i = 0; i < intArrayContaining20Numbers.Length; i++)
            {
                intArrayContaining20Numbers[i] = i * 5;
            }

            Console.WriteLine(string.Join(" ", intArrayContaining20Numbers));
            Console.WriteLine();

            //Task 2
            List<int> myIntList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                myIntList.Add(i*5);
                Console.Write(myIntList[i] + " ");
            }            
        }
    }
}