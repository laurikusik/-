using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_z2
{
    interface IHello
    {
        void SayHello();
    }
    class Russian: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Deutsch: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hallo");
        }
    }
    class Baski: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Kaixo");
        }
    }
    class Zulu: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Sawubona");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new Deutsch());
            greetings.Add(new Baski());
            greetings.Add(new Zulu());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}