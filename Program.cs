using System.Security.Cryptography.X509Certificates;

namespace OOPpolymorphism
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

            foreach (Geometri geometri in geometrin)
            {
                geometri.Area();
                Console.WriteLine();
            }
        }

    }
    public class Geometri 
    {
        public virtual void Area()
        {
            
        }
    }
    public class Rektangel : Geometri
    {
        public double _hight;
        public double _base;

        public Rektangel()
        {
            _hight = 8.5;
            _base = 4.5;
        }

        public override void Area()
        {
            double area = _hight * _base;
            Console.WriteLine("Area på Rektangeln: " + area + " cm2");
        }
        
    }
    public class Fyrkant : Geometri
    {
        public double _hight;
        public double _base;
        public Fyrkant()
        {
            _hight = 6.5;
            _base = 6.5;
        }
        public override void Area()
        {
            double area = _hight * _base;
            Console.WriteLine("Area på Fyrkanten: " + area + " cm2");
        }
    }
    public class Cirkel : Geometri
    {
        public double _radius;
        public float _pi;
        public Cirkel()
        {
            _radius = 3.5;
            _pi = 3.141f;
        }
        public override void Area()
        {
            double area = _radius * _radius * _pi;
            Console.WriteLine("Area på Circkeln: " + area + " cm2");
        }
    }
    public class Parallellogram : Geometri
    {
        public double _hight;
        public double _base;
        public Parallellogram()
        {
            _hight = 3.5;
            _base = 7.5;
        }
        public override void Area()
        {
            double area = _hight * _base;
            Console.WriteLine("Area på Parallellogramet: " + area + " cm2");
        }
    }
    public class Ellips : Geometri
    {
        public float _pi;
        public double _lenghtA;
        public double _lenghtB;
        public Ellips()
        {
            _pi = 3.141f;
            _lenghtA = 5.5;
            _lenghtB = 3.5;
        }
        public override void Area()
        {
            double area = _pi * _lenghtA * _lenghtB;
            Console.WriteLine("Area på Ellipsen: " + area + " cm2");
        }
     }
}