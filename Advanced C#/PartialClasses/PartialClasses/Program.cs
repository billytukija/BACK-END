using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Billy", "123456");
            if (user.Login())
                Console.WriteLine("Connected with success");
            else
                Console.WriteLine("Incorrect login infos");

            Console.ReadLine();
        }
    }
}
