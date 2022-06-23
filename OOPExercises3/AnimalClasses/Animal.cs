using System.Text;

namespace OOPExercises3.AnimalClasses
{
    public abstract class Animal
    {
        private string _name;
        private string _age;
        private string _gender;

        public Animal(string name, string age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        protected Animal(string name, string age)
        {
            Name = name;
            Age = age;
        }
        public string Name 
        {
            get => _name;

            protected set 
            {
                bool isEmpty = string.IsNullOrWhiteSpace(value);

                if (isEmpty)
                {
                    throw new ArgumentException("Invalid input!");
                }

                _name = value;
            }
        }

        public string Age 
        {
            get => _age;

            protected set 
            {              

                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                _age = value;
            }         
        }

        public string Gender 
        {
            get => _gender;

            protected set
            {
                CheckForNullOrWhiteSpace(value);

                _gender = value;
            }
        }

        private static void CheckForNullOrWhiteSpace(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} ");
            sb.Append($"{this.Age} ");
            sb.AppendLine($"{this.Gender}");
            sb.AppendLine(this.ProduceSound());

            return $"{GetType().Name}{Environment.NewLine}{sb?.ToString()}";
        }

    }
}
