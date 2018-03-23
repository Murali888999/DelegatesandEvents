using System;

namespace DelegatesandEvents
{
    public delegate int calDelegate(int a, int b);
    class MulticastDelegatewithReturnTypes
    {
        static void Main(string[] args)
        {
            MulticastDelegatewithReturnTypes obj = new MulticastDelegatewithReturnTypes();
            calDelegate cd = obj.add;
                        cd += obj.mul;
            int result = cd(4, 6);
            Console.WriteLine("addition:" + result);
            Console.WriteLine("multiplication:" + result);
            Console.ReadKey();
        }
        public int add(int a , int b)
        {
            return a + b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
    }
}
