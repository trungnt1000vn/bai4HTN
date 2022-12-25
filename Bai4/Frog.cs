using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Frog : Animal, ISound
    {
        public Frog(int age, string name, string sex) : base(age, name, sex)
        {
        }

        public void sound()
        {
            Console.WriteLine("Ech op ech op");
        }
    }
}
