using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        public class Client
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            var c1 = new Client() { Id = 1, Name = "Billy" };
            var c2 = new Client() { Id = 2, Name = "Serge" };
            var c3 = new Client() { Id = 3, Name = "Oskin" };

            var clients = new List<Client>() { c1, c2, c3 };
            var hst = new Hashtable();

            hst.Add(1, "Value1");
            hst.Add(2, "Value1");

            Console.WriteLine("Chosen cliente is : " + clients.FirstOrDefault(x => x.Id == 1).Name);
            Console.ReadLine();
        }
    }
}
