using System;

namespace DelegatesandEvents
{
    public delegate string frdDelegate(string name);
    class AnonymousMethod
    {
        static void Main(string[] args)
        {
            //frdDelegate obj = delegate (string name)
            //{
            //    return "Bhaskar " + name + " Madhu";
            //};  
            frdDelegate obj = (name) =>
             {
                 return "Bhaskar " + name + " Madhu";
             };      
            string s = obj("Murali");          
            Console.WriteLine(s);
            Console.ReadKey();
        }
        
    }
}
