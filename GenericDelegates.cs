using System;

namespace DelegatesandEvents
{
    class GenericDelegates
    {
        public static double mul(int a, float b, double c )
        {
            return a * b * c;
        }
        public static void sub(int a, float b, double c)
        {
            Console.WriteLine(a - b - c);
        }
        public static bool status(string s)
        {
            if (s.Length > 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, Double,double> md = mul;
            double b = md(23, 45.6f, 34.6);
            Console.WriteLine(b);

            Action<int,float ,double> sd = sub;
            sd(70, 62.5f, 65.8);

            Predicate<string> obj = status;
            bool status1 = obj("Murali Mohan");
            Console.WriteLine(status1);
            Console.Read();
        }
        
    }
}
