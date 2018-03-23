using System;

namespace DelegatesandEvents
{
    class GenericDelegateswithLambda
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> md  =(a, b,c) => 
            {
                return a * b * c;
            };
            double b1 = md(23, 45.6f, 34.6);
            Console.WriteLine(b1);

            Action<int, float, double> sd = (a, b, c) =>
            {
                Console.WriteLine(a - b - c);
            };
            Predicate<string> obj = (s) =>
            {
                if (s.Length > 5)
                    return true;
                return false;
            };
            bool status1 = obj("Murali Mohan");
            Console.WriteLine(status1);
            Console.Read();
        }

    }
}
