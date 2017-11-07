using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class College
    {
        
        private static string name;
        
       



        static void Main(string[] args)
        {

            int months = 0;
            
           

            List<Student> S = new List<Student>();

        

   

            Student s1 = new Student("undergraduate", 101, 711, "Peter", 97896876, "swords", "peter1@gmail.com");
            S.Add(s1);
            s1.computer = 150;
            s1.Maths = 80; s1.Science = 95;

            Student s2 = new Student("undergraduate", 102, 712, "Harry", 97836876, "limrick", "harry@gmail.com");
            S.Add(s2);
            s2.computer = 50;
            s2.Maths = 60; s2.Science = 75;

            Student s3 = new Student("undergraduate", 103, 713, "Garry", 97566876, "limrick", "garry@gmail.com");
            S.Add(s3);
            s3.computer = 100;
            s3.Maths = 160; s3.Science = 175;

            S.Add(new Student("undergraduate", 104, 714, "Rani", 92316876, "malahide", "rani@gmail.com"));

            S.Add(new Student("Postgraduate", 405, 811, "Samantha", 76566876, "Beamont", "samantha@gmail.com"));

            S.Add(new Student("Postgraduate", 406, 812, "shoan", 84756876, "navan", "shaun@gmail.com"));


            List<Lecturer> L = new List<Lecturer>();



            Lecturer l1 = new Lecturer(201, 3200.00, 593, "Lucy", 896876876, "balbriggan", "lucy@yahoo.com");
            L.Add(l1);

            Lecturer l2 = new Lecturer(202, 3240.00, 543, "Marie", 896876348, "balbriggan", "marie@yahoo.com");
            L.Add(l2);

            L.Add(new Lecturer(203, 3700.00, 593, "Gagan", 926876876, "Athlon", "gagan@yahoo.com"));



            Console.WriteLine();



            foreach (Student item in S)
            {
                Console.WriteLine("Student Detail:");
                Console.WriteLine(item.toString());
                Console.WriteLine("              ");

            }


                Console.WriteLine("              ");

            

            Console.WriteLine("Enter the name of Lecturer");
            name = Console.ReadLine();


            foreach (Lecturer lec in L)
            {
                
                if (name.ToUpper().Equals(lec.name.ToUpper()))
                {
                Console.WriteLine("Enter number of months");
                months = int.Parse(Console.ReadLine());

                    Console.WriteLine("Total salary is{0}", lec.TotalSalary(months));
                    Console.WriteLine("lecturers can borrow unlimited books");
                }
            }

            

            Console.WriteLine("***********************************");


            Console.WriteLine("Enter the name of Student");
            name = Console.ReadLine();



            foreach(Student stu in S)
            {
                if(name.ToUpper().Equals(stu.name.ToUpper()))
                {
                    Console.WriteLine("Enter number of months");
                   months = int.Parse(Console.ReadLine());

                  

                Console.WriteLine("Total fee for given student is {0}", stu.Totalfee(months));
                    
                    int division = stu.GetDivision();
                     switch(division)
                    {
                        case -1:
                            Console.WriteLine("Student is fail");
                                break;
                        case 3:
                            Console.WriteLine("Student is pass");
                            break;
                        case 2:
                            Console.WriteLine("Student has 2nd diuvision");
                            break;
                        case 1:
                            Console.WriteLine("Student has distinction");
                            break;
                        default :
                            break;

                    }
                   

                }
            }
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            Console.WriteLine("Please Enter Any Key To Exit");

            Console.ReadLine();

        }

    }
}