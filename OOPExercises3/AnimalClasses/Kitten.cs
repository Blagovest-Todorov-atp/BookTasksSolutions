using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises3.AnimalClasses
{
    public class Kitten : Cat
    {
        private const string KITTEN_SOUND = "Miau";
        
        public Kitten(string name, string age) 
            : base(name, age, "F")
        {
        }

        public override string ProduceSound()
        {
            return $"{KITTEN_SOUND}";
        }
    }
}
