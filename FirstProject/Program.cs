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
            Console.WriteLine("1. Hello World");


            // ***** Implicit Type Conversion *****
            byte b = 1;
            int ib = b;
            Console.WriteLine("2. IMPLICIT Conversion of Byte (" + b + ") into Int (" + ib + ")");

            // ***** Explicit Type Conversion *****
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine("3. EXPLICIT Conversion of String (" + s + ") using Convert.ToInt32 (" + i + ") and int.Parse (" + j + ")");

            // ***** Explicit Type Conversion Failing, adding Try-Catch *****
            try
            {
                var number = "1234";
                byte secondB = Convert.ToByte(number);
                Console.WriteLine(secondB);
            }
            catch (Exception)
            {
                //throw;
                Console.WriteLine("4. There was an EXCEPTION catched while converting that Number to Byte. Asshole!!!");
            }

           

            
    }
    }
}
