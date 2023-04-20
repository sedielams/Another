using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_InheritanceEg
{
    public class Student: Person
    {
        private string studentNumber;

        public Student(int id, string name, int age, string _studentNum) : base(id, name, age)
        {
            this.studentNumber = _studentNum;
        }

        public override void displayResult()
        {
            base.displayResult();
            Console.WriteLine($"Student number is: {studentNumber}");
        }
    }
}
