using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Dog : Animal, ISound
    {
        public Dog(int age, string name, string sex) : base(age, name, sex)
        {
        }

        public void sound()
        {
            Console.WriteLine("Gau gau");
        }
    }
}
