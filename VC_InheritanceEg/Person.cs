using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_InheritanceEg
{
    public class Person
    {
        private int id;
        private string name;
        private int age;

        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age;} set { age = value; } }

        public virtual void displayResult()
        {
            Console.WriteLine($"Id is {id}");
            Console.WriteLine($"Name is: {name}");
            Console.WriteLine($"Age is: {age}");
        }



    }
}
