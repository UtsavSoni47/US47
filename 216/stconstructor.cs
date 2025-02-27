using System;

namespace class1
{
    class program
    {
        static int a;

        static program()
        {
            a = 10;
            Console.WriteLine("hello");
        }

        static void Main(string[] args)
        {
            program p = new program();
            
          
            Console.WriteLine("Value of a: " + a);
        }
    }
}
