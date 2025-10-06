using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

         //make memberid read only
         public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public void displayInfo()
        {
            //output book information
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member Phone Number: {Phone}\n");
        }

        //constructor
        public Member (int memberId, string name, string address, int phone)
        {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
    }
}
