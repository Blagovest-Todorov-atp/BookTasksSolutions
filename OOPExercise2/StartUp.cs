using OOPExercise2.Classes;

namespace OOPExercise2
{
    internal class StartUp
    {
        static void Main(string[] args)
        {         

            Book myBook = new Book("Humor", "Jack", "London", (decimal)10);

            GoldenEditionBook myGoldBook = new GoldenEditionBook("Under the Siege", "Ivan", "Vasov", (decimal)100);

            Console.WriteLine(myBook);
            Console.WriteLine(myGoldBook);

        }
    }
}