using System.Security.Cryptography.X509Certificates;

namespace OOPpolymorphism   //Wille Persson - .Net23 - Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel rektangel = new Rektangel();
            Fyrkant fyrkant = new Fyrkant();
            Cirkel cirkel = new Cirkel();
            Parallellogram parallellogram = new Parallellogram();
            Ellips ellips = new Ellips();

            Geometri[] geometrin = { rektangel, fyrkant, cirkel, parallellogram, ellips };

            foreach (Geometri geometri in geometrin)//skriver ut area metoden till alla 
            {
                geometri.Area();
                Console.WriteLine();
            }
        }

    }
    public class Geometri //Main/parentclass
    {
        public virtual void Area()//Virtual Method
        {
            
        }
    }
    public class Rektangel : Geometri//Childclass from Geometri
    {
        public double _hight;//field
        public double _base;

        public Rektangel()//construktor
        {
            _hight = 8.5;
            _base = 4.5;
        }

        public override void Area()//overriding Method
        {
            double area = _hight * _base;
            Console.WriteLine("Area på Rektangeln: " + area + " cm2");
        }
        
    }
    public class Fyrkant : Geometri//Childclass from Geometri
    {
        public double _hight;//fields
        public double _base;
        public Fyrkant()//construktor
        {
            _hight = 6.5;
            _base = 6.5;
        }
        public override void Area()//overriding Method
        {
            double area = _hight * _base;
            Console.WriteLine("Area på Fyrkanten: " + area + " cm2");
        }
    }
    public class Cirkel : Geometri//Childclass from Geometri
    {
        public double _radius;//fields
        public float _pi;
        public Cirkel()//construktor
        {
            _radius = 3.5;
            _pi = 3.14f;
        }
        public override void Area()//overriding Method
        {
            double area = _radius * _radius * _pi;
            Console.WriteLine("Area på Circkeln: " + area + " cm2");
        }
    }
    public class Parallellogram : Geometri//Childclass from Geometri
    {
        public double _hight;//fields
        public double _base;
        public Parallellogram()//construktor
        {
            _hight = 3.5;
            _base = 7.5;
        }
        public override void Area()//overriding Method
        {
            double area = _hight * _base;
            Console.WriteLine("Area på Parallellogramet: " + area + " cm2");
        }
    }
    public class Ellips : Geometri //Childclass from Geometri
    {
        public float _pi;//fields
        public double _lenghtA;
        public double _lenghtB;
        public Ellips()//construktor
        {
            _pi = 3.141f;//fields
            _lenghtA = 5.5;
            _lenghtB = 3.5;
        }
        public override void Area()//overriding Method
        {
            double area = _pi * _lenghtA * _lenghtB;
            Console.WriteLine("Area på Ellipsen: " + area + " cm2");
        }
     }
}