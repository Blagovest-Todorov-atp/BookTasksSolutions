using System.Text;

namespace OOPExercises3.AnimalClasses
{
    public class Dog : Animal
    {
        private const string DOG_SOUND = "BauBau";

        public Dog(string name, string age, string gender) 
            : base( name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return $"{DOG_SOUND}";
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append($"{this.Name} ");
        //    sb.Append($"{this.Age} ");
        //    sb.AppendLine($"{this.Gender}");
        //    sb.AppendLine(this.ProduceSound());

        //    return $"{typeof(Dog).Name}{Environment.NewLine}{sb.ToString()}";
        //}
    }
}
