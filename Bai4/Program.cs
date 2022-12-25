using System;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             static int Average(Animal[] array)
            {
                int sum=0;
                for(int i = 0; i < array.Length; i++)
                {
                    sum += array[i].Age;
                }
                return sum / (array.Length);
            }
            Dog dog = new Dog(3,"Toan","Male");
            Frog frog = new Frog(1, "Froggen", "Male");
            Tomcat tomcat = new Tomcat(20, "Tom", "Male");
            Kitten kitten = new Kitten(20, "Jerry", "Female");
            Animal[] arrayAnimals = {dog,frog,tomcat, kitten };
            Console.WriteLine(Average(arrayAnimals));
        }
    }
}
