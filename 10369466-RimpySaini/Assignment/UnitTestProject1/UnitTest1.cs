using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student s1 = new Student("undergraduate", 101, 711, "Peter", 97896876, "swords", "peter1@gmail.com");
            Assert.AreEqual("undergraduate", s1.Status);
            Assert.AreEqual(101, s1.studId);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Lecturer l1 = new Lecturer(201, 3200, 593, "Lucy", 896876876, "balbriggan", "lucy@yahoo.com");
            Assert.AreEqual(201, l1.LecId);
            Assert.AreEqual(3200, l1.Salary);
        }

        [TestMethod]

        public void TotalSalaryShouldBe6300()
        {
            Lecturer l1 = new Lecturer(201, 3200, 593, "Lucy", 896876876, "balbriggan", "lucy@yahoo.com");
           double expectedResult = 6300;
            double actualresult = l1.TotalSalary(2);
            Assert.AreEqual(expectedResult, actualresult);
        }

        [TestMethod]
        public void TotalFee()
        {
            Student s3 = new Student("undergraduate", 103, 713, "Garry", 97566876, "limrick", "garry@gmail.com");
            double expectedResult = 600;
          decimal actualresult = s3.Totalfee(3);
            Assert.AreEqual  (expectedResult, actualresult);


        }
    }
}
