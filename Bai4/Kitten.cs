using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Kitten : Cat
    {
        public Kitten(int age, string name, string sex) : base(age, name, sex)
        {
            sex = "Female";
        }
    }
}
