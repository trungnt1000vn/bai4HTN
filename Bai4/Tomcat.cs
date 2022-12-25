using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Tomcat : Cat
    {
        public Tomcat(int age, string name, string sex) : base(age, name, sex)
        {
            sex = "Male";
        }
    }
}
