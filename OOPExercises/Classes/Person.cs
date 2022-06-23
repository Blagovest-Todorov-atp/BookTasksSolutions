
using System.Text;

namespace OOPExercises1.Classes
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        private const int PERSON_MIN_AGE = 0;

        private string name;
        private int age;
        private string id;

        public string Name
        {
            get => this.name;

            protected set
            {
                this.name = value;
            }
        }


        public virtual string PersonId
        {
            get => this.id;
            protected set
            {
                this.id = value;
            }
        }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
            this.PersonId = GenerateId();
        }
        public virtual int Age
        {
            get
            {
                return this.age;
            }

            protected set
            {
                if (value < PERSON_MIN_AGE)
                {
                    throw new ArgumentException("Age cannot be negative");
                }

                this.age = value;
            }
        }


        public bool Equals(Person? other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.PersonId == other.PersonId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

            return sb.ToString();
        }

        public int CompareTo(Person? other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.Age.CompareTo(other.Age);
        }

        private string GenerateId()
        {
            var ticks = DateTime.Now.Ticks;
            Guid guid =  Guid.NewGuid();
            var strUniqueId = ticks + guid.ToString();
            return strUniqueId;
        }
    }
}
