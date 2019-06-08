using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsClassesAndMethods
{
    public static class Extensions {

        // The method "WriteJSON" gonna be injected in "strings"
        public static void WriteJSON(this string str,string fileName) {
            // Logic
        }

        public static void BuildUrl(this string str) { }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            s.WriteJSON("");

            s.BuildUrl();
        }
    }
}
