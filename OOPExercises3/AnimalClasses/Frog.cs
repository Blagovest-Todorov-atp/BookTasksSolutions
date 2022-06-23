using System.Text;

namespace OOPExercises3.AnimalClasses
{
    public class Frog : Animal
    {
        private const string FROG_SOUND = "Frogggg";

        public Frog(string name, string age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return $"{FROG_SOUND}";
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append($"{this.Name} ");
        //    sb.Append($"{this.Age} ");
        //    sb.AppendLine($"{this.Gender}");
        //    sb.AppendLine(this.ProduceSound());

        //    return $"{typeof(Frog).Name}{Environment.NewLine}{sb.ToString()}";
        //}
    }
}
