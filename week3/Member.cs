using System;
using System.Collections.Generic;
using System.Text;

namespace week3
{
    internal class Member
    {
        private int memberId;
        private string name;
        private string address;
        private string phone;



        public int MemberId {
            get { return memberId; }
            private set
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than 0.");
                }
            }
        }

        public string Name {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit) &&value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot contain numbers or be empty.");
                }
            }
        }

        public string Address {
            get { return address; }
            set { address = value; }
        }
        public string Phone {
            get { return phone; }
            set { phone = value; }
        }

        public Member(int memberId, string name, string address, string phone) {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {memberId}");
            Console.WriteLine($"Member Name: {name}");
            Console.WriteLine($"Member Address: {address}");
            Console.WriteLine($"Member Phone: {phone}");
            Console.WriteLine();
        }



    }
}
