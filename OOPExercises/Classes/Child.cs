namespace OOPExercises1.Classes
{
    public class Child : Person
    {
        private const int CHILD_MAX_AGE = 15;

        public override int Age 
        {
            get 
            {
                return base.Age;
            }

            protected set 
            {
                if (value > CHILD_MAX_AGE)
                {
                    throw new ArgumentException("Age cannot be greater than 15 for children");   
                }

                base.Age = value;
            }         
        }
        public Child(int age, string name) 
            : base(age, name)
        {
        }
    }
}
