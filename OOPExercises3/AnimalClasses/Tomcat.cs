using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises3.AnimalClasses
{
    public class Tomcat : Cat
    {
        private const string TOMCAT_SOUND = "ManMiau";
        public Tomcat(string name, string age) 
            : base(name, age, "M")
        {
        }

        public override string ProduceSound()
        {
            return $"{TOMCAT_SOUND}";
        }
    }
}
