using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     public class Lecturer : Person
    {
        // variables
        private int lecId;
        private double salary;

        // properties
        public int LecId
        {
            get { return lecId; }
            set { lecId = value; }
        }
       
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

      
        public Lecturer(int id, double salary, int ppsn, string name, int phoneNumber, string address, string email) : base(ppsn, name, phoneNumber, address, email)
        {
            LecId = id;
            Salary = salary;
        }

        
        public double TotalSalary(int months)
        {
            const int tax = 100;
           double totalSalary = 0;


            totalSalary = ((months * salary) - tax);
            return totalSalary;

        }


      
        public string toString()
        {

            return " LecturerId: " + lecId + "  Salary: " + salary + "  PPSN: " + ppsn + "  Name: " + name + "  \n PhoneNumber: " + phoneNumber + "  Address: " + address + "  Email : " + email;

        }
    }
}

