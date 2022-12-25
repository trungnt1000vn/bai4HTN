using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Animal
    {
        int age;
        string name;
        string sex;

        public Animal(int age, string name, string sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
