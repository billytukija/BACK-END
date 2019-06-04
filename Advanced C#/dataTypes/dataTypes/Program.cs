using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypes
{
    public class Program
    {
        public class DataByRef
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public static void Bend(ref int value)
        {
            value = value * 2;
        }

        public static void Bend(DataByRef pos) {
            pos.X = pos.X * 2;
        }

        static void Main(string[] args)
        {
            var costumer = new Costumer();
            costumer.Name = "Billy";
            costumer.Id = 1;
            costumer.PhoneNumber = 1245454;

            var costumer2 = new Costumer();
            costumer2 = costumer;

            Console.WriteLine(costumer);
            Console.WriteLine(costumer2);

            if (costumer.Equals(costumer2))
                Console.WriteLine("Objects are equal");
            
            //var x = 10;
            //Bend(ref x);
            //Console.WriteLine(x);
            //Console.Read();

            //DataByRef pos1 = new DataByRef();
            //DataByRef pos2 = new DataByRef();

            //pos1.X = 30;
            //pos1.Y = 40;

            //Bend(pos1);

            //pos2.X = 50;
            //pos2.Y = 60;

            //pos1.Y = pos2.Y; // Pointer

            //Console.WriteLine("pos1 x :" + pos1.X);
            //Console.WriteLine("pos1 y :" + pos1.Y);

            //Console.WriteLine("pos2 x :" + pos2.X);
            //Console.WriteLine("pos2 y :" + pos2.Y);

            Console.ReadLine();
        }

        private static void DataByValue()
        {
            var x = 10;
            var y = 20;

            y = x; // Copy

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
