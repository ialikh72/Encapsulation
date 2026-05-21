using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {
        private string name;
        private int age;
        private string rollNum;
        private string Class;
        private string id;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                    age = value;
              
            }
        }

        public string RollNum { get => rollNum; set => rollNum = value; }
        public string Class1 { get => Class; set => Class = value; }
        public string Id { get => id;  }
        public string introduce()
        {
            return $"My name is {Name}. \nI am {Age} years old. \nmy roll number is {RollNum}. \nI am in class {Class1}.\nMy id is "+(Class1+RollNum);
        }
    }
}
