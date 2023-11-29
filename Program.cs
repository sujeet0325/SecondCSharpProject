using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCSharpProject
{
    internal class Program
    {
        public void Square()
        {
            int a = 10,c;
            c = a * a;
            Console.WriteLine("Square = " + c);
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.Square();
            Console.ReadLine();
        }
    }
}
