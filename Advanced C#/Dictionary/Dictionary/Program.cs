using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Request
    {
        public int Number { get; set; }
        public string Client { get; set; }
        public double Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var requests = new Dictionary<string, Request>();

            var r1 = new Request() { Number = 1, Client = "Billy", Value = 110.55 };
            var r2 = new Request() { Number = 2, Client = "Richard", Value = 110.55 };

            requests.Add(r1.Client.Substring(0, 3) + r1.Number, r1);
            requests.Add(r2.Client.Substring(0, 3) + r2.Number, r2);

            foreach (var item in requests.Values)
                Console.WriteLine(item.Client);

            Console.WriteLine("Chaves e valor do produtos");

            foreach (KeyValuePair<string, Request> item in requests)
                Console.WriteLine("Key: " + item.Key + " " + " Valor: " + item.Value.Value);

            var sum = requests.Sum(r => r.Value.Value);

            Console.WriteLine("O valor total é : " + sum);
            Console.ReadLine();
        }
    }
}
