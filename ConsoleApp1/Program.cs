using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування української мови
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== Лабораторна робота №4 (Варіант 5) ===");

            // Робота з Кулею
            Ball ball = new Ball();
            ball.SetParams(0, 0, 0, 5);
            ball.Display();
            Console.WriteLine($"Об'єм кулі: {ball.CalculateVolume():F2}");

            Console.WriteLine("-----------------------------------------");

            // Робота з Еліпсоїдом
            Ellipsoid ellipsoid = new Ellipsoid();
            ellipsoid.SetParams(0, 0, 0, 3, 4, 5);
            ellipsoid.Display();
            Console.WriteLine($"Об'єм еліпсоїда: {ellipsoid.CalculateVolume():F2}");

            // Щоб вікно не закривалося одразу
            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }

    public class Ball
    {
        protected double b1, b2, b3, R;
        public virtual void SetParams(double x, double y, double z, double r)
        {
            b1 = x; b2 = y; b3 = z; R = r;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Куля: Центр({b1}, {b2}, {b3}), R={R}");
        }
        public virtual double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
        }
    }

    public class Ellipsoid : Ball
    {
        private double a1, a2, a3;
        public void SetParams(double x, double y, double z, double sa1, double sa2, double sa3)
        {
            base.SetParams(x, y, z, 0);
            a1 = sa1; a2 = sa2; a3 = sa3;
        }
        public override void Display()
        {
            Console.WriteLine($"Еліпсоїд: Центр({b1}, {b2}, {b3}), півосі: a1={a1}, a2={a2}, a3={a3}");
        }
        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * a1 * a2 * a3;
        }
    }
}