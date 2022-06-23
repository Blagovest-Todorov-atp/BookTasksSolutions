using System.Text;

namespace OOPExercises3.AnimalClasses
{
    public class Cat : Animal
    {
        private const string CAT_SOUND = "MiauMiau"; 

        public Cat(string name, string age, string gender)
            : base(name, age, gender)
        {
        }
        protected Cat(string name, string age)
             : base(name, age)
        {
        }

        public override string ProduceSound()
        {
            return $"{CAT_SOUND}"; 
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append($"{this.Name} ");
        //    sb.Append($"{this.Age} ");
        //    sb.AppendLine($"{this.Gender}");
        //    sb.AppendLine(this.ProduceSound());

        //    return $"{typeof(Cat).Name}{Environment.NewLine}{sb.ToString()}";
        //}
    }
}
