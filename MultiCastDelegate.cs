using System;

namespace DelegatesandEvents
{
    public delegate void rectDelegate(double width, double height);
    public delegate int CalDelegate(int a, int b);
    class MultiCastDelegate
    {      
        static void Main(string[] args)
        {
            MultiCastDelegate obj = new MultiCastDelegate();
            rectDelegate rd = obj.Area;
            rd += obj.Perimeter;            
            rd(34.6, 28.3);
            Console.WriteLine();
            rd(45.2, 30.4);
            Console.ReadKey();
        }
        public void Area(double width, double height)
        {
            Console.WriteLine("Area of Reactangle:"+width * height);
        }
        public void Perimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of Rectangle:"+2 * (width + height));
        }        
    }
}
