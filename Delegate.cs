using System;

namespace DelegatesandEvents
{
    public delegate void addDelegate(int m, int n);
    public delegate string nameDelegate(string str);
    class Delegate
    {
        static void Main(string[] args)
        {
            Delegate d = new Delegate();
            addDelegate ad = new addDelegate(d.addnums);
            ad(24, 80);
            nameDelegate nd = new nameDelegate(Delegate.getname);
            
            string s1 = nd("Mohan");            
            Console.WriteLine(s1);
            Console.Read();
        }
        public void addnums(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public static string getname(string s)
        {
            return "Murali" + s;
        }
    }
}
