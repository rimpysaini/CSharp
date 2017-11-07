using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public class Student : Person
    {
        decimal fee = 200;

        public string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int studId;
        public int StudId
        {
            get { return studId; }
            set { studId = value; }
        }


        public Student(string status, int studId, int ppsn, string name, int phoneNumber, string address, string email) : base(ppsn, name, phoneNumber, address, email)
        {
            this.status = status;
            if(status.Equals("Postgraduate"))
            {
                
                fee = 300;
                Console.WriteLine(" Postgraduates can borrow 10 books");  
            }
            else
            {
                Console.WriteLine("undergraduates can borrow 5 books");
            }
            
           
            this.studId = studId;

            
        }
       


        public double Maths
        { get;set;
    
        }

        public double Science
        {
            set;
            get;
        }
        public double computer
        {
            set;
            get;
        }

        public double GetAverage()
        {
            return ((Maths + Science + computer) / 3.0);
        }

        public int GetDivision()
        {
            double average = GetAverage();

        
            if(average<35)
            {
                return -1;
            }
            else if(average<=60)
            {
                return 3;

            }
            else if (average<=70)
                {
                return 2;
            }
            else if (average>70)
            {
                return 1;
            }
            return 0;
        }



        public decimal Totalfee(int months)
        {
            
            
            return months * fee;

        }

        

        public string toString()
        {
           
            return " Status: "+status+"  StudentId: "+studId+"  PPSN: "+ppsn+"  Name: "+name+"  \n PhoneNumber: "+phoneNumber+"  Address: "+address+"  Email : "+email;
        }   

    }
 

}
