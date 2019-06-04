using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypes
{
    public class Costumer : Object
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Id : " + Id);
            sb.AppendLine("Name : " + Name);
            sb.AppendLine("Phone Number : " + PhoneNumber);

            return sb.ToString();
        }
    }
}
