using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tradicionalGetAndSet
{
    class Program
    {
        public class Account
        {
            private string _client { get; set; }
            private double _balance { get; set; }

            public Account()
            {
                this._client = "Without name";
                this._balance = 0.0;
            }

            public string getClient()
            {
                return this._client;
            }

            public void setClient(string name)
            {
                this._client = name;
            }

            public double Debit(double value)
            {
                var res = this._balance - value;
                if (res < 0)
                    throw new Exception("Balance is negative");
                return this._balance;
            }

            public double Credit(double value)
            {
                this._balance = this._balance + value;
                return this._balance;
            }

            public double getBalance()
            {
                return this._balance;
            }
        }


        static void Main(string[] args)
        {
            Account ac = new Account();
            ac.setClient("Billy");

            Console.WriteLine(ac.getClient());

            ac.Credit(100.0);
            Console.WriteLine(ac.getBalance());

            ac.Debit(50.0);
            Console.WriteLine(ac.getBalance());

            Console.ReadLine();
        }
    }
}
