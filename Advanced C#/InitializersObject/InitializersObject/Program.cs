using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializersObject
{
    class Program
    {
        public class Account {
            public int Agennce { get; set; }
            public int AccountNumber { get; set; }
        }
        public class Client {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<Account> Acounts { get; set; }
        }

        static void Main(string[] args)
        {
            int Counter = 0;

            var client = new Client()
            {
                Id = 1,
                Name = "Billy",
               Acounts = new List<Account>() {
                   new Account{ Agennce = 1524, AccountNumber= 1254541 },
                   new Account{ Agennce = 1234, AccountNumber= 1234565 }
               }
            };

            Console.WriteLine("Id: " + client.Id + " Name : " + client.Name);

            foreach (var account in client.Acounts)
            {
                Counter++;
                Console.WriteLine("Info " + Counter + " => Agence : " + account.Agennce + " => Number : " + account.AccountNumber);
            }
            
            Console.Read();
        }
    }
}
