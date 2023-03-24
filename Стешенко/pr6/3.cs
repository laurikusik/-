using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_z3
{
    class Human
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public Human (string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Worker : Human
    {
        public string Position
        {
            get;
            set;
        }
        public Worker (string name, int age, char gender, string position) : base (name, age, gender)
        {

            Position = position;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Laura = new Human("Лаура Стешенко", 18, 'Ж');
            Console.WriteLine(Alexander.Name);
            Worker Anastasia = new Worker("Анастасия Шелушинина", 19, 'Ж', "Уборщица");
            Console.WriteLine(Ulyana.Position);
            Console.ReadKey(true);
        }
    }
}