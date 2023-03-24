using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_z2
{
    class TransportVehicle
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public TransportVehicle (string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
        }
    }
    class PolytechMachine : TransportVehicle
    {
        public void TurnMusic()
        {
            Console.WriteLine("�� �������� �� ������ ��������� ������ ������");
        }
        public PolytechMachine (string name, int speed) : base (name, speed)
        {
        }
    }
    class Airplane : TransportVehicle
    {
        public void PollinateField()
        {
            Console.WriteLine("���� ������� �������");
        }
        public Airplane (string name, int speed) : base (name, speed)
        {
        }
    }
    class ConcreteMixer: TransportVehicle
    {
        public void MixConcrete()
        {
            Console.WriteLine("������ �����");
        }
        public ConcreteMixer (string name, int speed) : base (name, speed)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportVehicle Car = new TransportVehicle("Lamborghini Urus", 350);
            PolytechMachine Polytech = new PolytechMachine("�������-������-1", 150);
            Polytech.TurnMusic();
            Airplane Boeing = new Airplane("Boeing 787 Dreamliner", 956);
            Boeing.PollinateField();
            ConcreteMixer beton = new ConcreteMixer("�����", 250);
            beton.MixConcrete();
            Console.ReadKey(true);
        }
    }
}