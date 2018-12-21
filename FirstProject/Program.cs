using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // The classig Hello World
            Console.WriteLine("Hello World");


            // ***** Implicit Type Conversion *****
            byte b = 1;
            int ib = b;
            Console.WriteLine("IMPLICIT Conversion of Byte (" + b + ") into Int (" + ib + ")");

            // ***** Explicit Type Conversion *****
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine("EXPLICIT Conversion of String (" + s + ") using Convert.ToInt32 (" + i + ") and int.Parse (" + j + ")");
    }
    }
}
