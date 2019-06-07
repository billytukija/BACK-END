using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndProperties
{
    class Program
    {
        public class Converter
        {
            public static bool Status { get; set; }
            public double Tax { get; set; }
            public double Fah { get; set; }
            public double Cel { get; set; }
            public double _salary;

            public Converter()
            {
                Fah = 0;
                Cel = 0;
                Tax = 0;
                _salary = 0;
            }

            public Converter(double p_Salary)
            {
                Fah = 0;
                Cel = 0;
                Tax = 0;
                this._salary = p_Salary;

                Salary();
            }

            public void Salary()
            {
                Status = true;

                if (_salary >= 0)
                    Tax = _salary == 0 ? 0.12 : (_salary / 100) * 5;
                else
                    throw new Exception("wrong salary");
            }
        }

        public static double FahToCel(double fah)
        {
            return (fah - 32) * 5 / 9;
        }

        public static double CelToFah(double cel)
        {
            return (cel * (9 / 5)) + 32;
        }

        static void Main(string[] args)
        {
            var TextStatus = Converter.Status ? "Enable" : "Disable";

            var C1 = new Converter(12.5);
            C1.Cel = 12;
            C1.Fah = -11.1111;
            C1._salary = 12;

            var C2 = new Converter();
            C2.Cel = 123;
            C2.Fah = -12.1111;

            Console.WriteLine("Status: " + Converter.Status);
            Console.WriteLine("Fah to cel " + FahToCel(C1.Fah) + "  Tax: " + C1.Tax + " Status: " + TextStatus);
            Console.WriteLine("Cel to fah " + CelToFah(C1.Cel) + "  Tax: " + C1.Tax + " Status: " + TextStatus);

            Console.WriteLine("----- SECOND INSTANCE ------");
            Console.WriteLine("Status: " + Converter.Status);
            Console.WriteLine("Fah to cel " + FahToCel(C2.Fah) + "  Tax: " + C2.Tax + " Status: " + TextStatus);
            Console.WriteLine("Cel to fah " + CelToFah(C2.Cel) + "  Tax: " + C2.Tax + " Status: " + TextStatus);


            Console.ReadLine();
        }
    }
}
