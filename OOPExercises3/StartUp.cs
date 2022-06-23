using System.Collections.Generic;
using OOPExercises3.AnimalClasses;

namespace OOPExercises3
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");          

            List <Animal> animalsCollection = new List<Animal>();

            Dog dog = new Dog("Kimba", "12", "F");
            animalsCollection.Add(dog);
            //Console.WriteLine(dog);          

            Cat cat = new Cat("Fiffy", "10", "F");
            animalsCollection.Add(cat);
            //Console.WriteLine(cat);      

            Frog frog = new Frog("FroggyMen", "15", "M");
            animalsCollection.Add(frog);

            //Console.WriteLine(frog);

            Kitten kitten = new Kitten("KittyGirl", "5");
            animalsCollection.Add(kitten);           

            Tomcat tomcat = new Tomcat("TomBoy", "50");
            animalsCollection.Add(tomcat);

            PrintCollectionAnimals(animalsCollection);
        }


        public static void PrintCollectionAnimals( List<Animal> animals) 
        {
            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }
    }
}