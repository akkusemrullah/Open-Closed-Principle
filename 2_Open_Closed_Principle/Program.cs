using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Open_Closed_Principle
{
    class Program
    {
        /*Sınıfların, modüllerin, fonksiyonların geliştirilmeye açık, fakat değişikliğe kapalı olması gerekir.
        Her defasında if - else ekleyerek çözüm bulunabilir fakat Open closed prensibine aykırı olur
        
        */

        // Git denemesi
        // Git denemesi 2
        // Git denemesi 3
        static void Main(string[] args)
        {
         

            AlanHesapla alanHesapla = new AlanHesapla();
            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine(rectangle.Area().ToString());

            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public abstract double Area();
    }
    class AlanHesapla
    {
        public double Alan(Shape sh)
        {
            return sh.Area();
        }
    }
    class Rectangle : Shape
    {
        public double  X { get; set; }
        public double  Y { get; set; }
        public Rectangle (int x, int y)
        {
            X = x;
            Y = y;
        }
        public override double Area()
        {
            return X * Y;   
        }
    }

    class Circle : Shape
    {
        public double  Radius { get; set; }
        public Circle (double radi)
        {
            Radius = radi;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
