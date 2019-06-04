using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructClassAndEnums
{
    public class ClassPerson : Object
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name : " + Name);
            sb.AppendLine("Age : " + Age);

            return sb.ToString();
        }
    }

    public struct StructPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name : " + Name);
            sb.AppendLine("Age : " + Age);

            return sb.ToString();
        }
    }

    public enum OpenDays
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        thuesday = 4,
        Friday = 5,
        Saturday = 5
    }

    public enum Authors {
        Billy, 
        Elie,
        Eric,
        Renové
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ClassPerson = new ClassPerson();
            ClassPerson.Name = Authors.Billy.ToString() + " - " + OpenDays.Tuesday;
            ClassPerson.Age = 15;

            var ClassPerson2 = new ClassPerson();
            ClassPerson2.Name = Authors.Elie.ToString();
            ClassPerson2.Age = 12;

            Console.WriteLine("Point to the reference");
            ClassPerson2 = ClassPerson; // Pointer
            ClassPerson.Name = Authors.Eric.ToString() +  " - " + OpenDays.Monday;

            Console.WriteLine(ClassPerson);
            Console.WriteLine(ClassPerson);

            var StructPerson = new StructPerson();
            StructPerson.Name = "Billy";
            StructPerson.Age = 15;

            var StructPerson2 = new StructPerson();
            StructPerson2.Name = "Elie";
            StructPerson2.Age = 12;

            Console.WriteLine("Deep Copy of a value");
            StructPerson2 = StructPerson; // deep copy
            
            Console.WriteLine(StructPerson);
            Console.WriteLine(StructPerson2);
            Console.ReadLine();

        }
    }
}
