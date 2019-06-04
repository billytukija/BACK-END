using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Contact
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class Person
    {
        private int Code { get; set; }
        private string Name { get; set; }
        private Contact Contact { get; set; }

        public Person() {
            this.Code = 0;
            this.Name = "Without name";
        }

        public Person(int code)
        {
            this.Code = code;
            this.Name = "Without name";
        }

        public Person(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Code : " + this.Code);
            sb.AppendLine("Name : " + this.Name);
            return sb.ToString();
        }
    }

    public class PersonVP: Person {
        public bool Expertise { get; set; }

        public PersonVP(int code, string name): base(code, name)
        {
            Expertise = true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(123, "Billy");
            PersonVP p_vip = new PersonVP(12, "Tukija");
            Console.WriteLine(p);
            Console.WriteLine(p_vip);
            Console.ReadLine();
        }
    }
}
