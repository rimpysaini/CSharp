using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{ 

    public abstract class Person
    {
        public int ppsn
        { get; set; }
        public string name
        {
            get; set;
        }
        public int phoneNumber
        { get; set; }
        public string address
        {
            get; set;
        }

        public string email
        {
            get; set;
        }

        public Person(int ppsn, string name, int phoneNumber, string address, string email)
        {
            this.ppsn = ppsn;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.email = email;
        }
       

        public override string ToString()
        {
            return string.Format("({0},{1},{2},{3},{4})", ppsn, name, phoneNumber, address, email);
        }

    }

}