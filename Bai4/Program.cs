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
    class Animal
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
    class Dog : Animal,ISound
    {
        public Dog(int age, string name, string sex) : base(age, name, sex)
        {
        }

        public void sound()
        {
            Console.WriteLine("Gau gau");
        }
    }
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, string sex) : base(age, name, sex)
        {
        }

        public void sound()
        {
            Console.WriteLine("Ech op ech op");
        }
    }
    class Cat : Animal, ISound
    {
        public Cat(int age, string name, string sex) : base(age, name, sex)
        {
        }

        public void sound()
        {
            Console.WriteLine("Meow meow");
        }
    }
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, string sex) : base(age, name, sex)
        {
            sex = "Male";
        }
    }
    class Kitten : Cat
    {
        public Kitten(int age, string name, string sex) : base(age, name, sex)
        {
            sex = "Female";
        }
    }
}
