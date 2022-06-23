using OOPExercises1.Classes;

namespace OOPExercises
{
    internal class EntryPointPerson
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");           

            Person person;
            Child child;

            person = new Person(60, "Jameses");
            Console.WriteLine(person);

            child = new Child(15, "Jessyca");
            Console.WriteLine(child);

            Console.WriteLine(child.Equals(person));

            Console.WriteLine(child.CompareTo(person));

            //Task -> 1 in OOP Person and Children Page -> 46 of the book
        }
    }
}