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
            // The classic Hello World
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
                Console.WriteLine("4. There was an EXCEPTION caught while converting that Number to Byte. Asshole!!!");
            }

            // ***** OPERATORS *****

            int opOne = 1;
            int opTwo = opOne++;
            Console.WriteLine("Posfix Increment ( b = a++): opOne = " + opOne + " opTwo = " + opTwo);
            int opThree = ++opOne;
            Console.WriteLine("Prefix Increment (b = ++a: opOne = " + opOne + " opThree = " + opThree);


            Person client = new Person();
            client.FirstName = "John";
            client.LastName = "Verga";
            client.Introduce();

            var newClient = new Person();
            newClient.FirstName = "Jeremy";
            newClient.LastName = "Piturri";
            newClient.Introduce();

            var calc = new Calculator();
            var result = calc.Add(5, 6);
            Console.WriteLine(result);

            // ***** ARRAYS *****
            int[] coordinates = new int[3];
            coordinates[0] = 1;
            coordinates[1] = 2;
            coordinates[2] = 3;

            // Easier way to declare / initialize arrays
            int[] easyArray = new int[3] {1,2,3};
            // Even easier
            var easiestArray = new int[3] { 1, 2, 3 };

            Console.WriteLine("Arrays");
            Console.WriteLine(easiestArray[0]);
            Console.WriteLine(easiestArray[1]);
            Console.WriteLine(easiestArray[2]);

            Console.WriteLine(string.Join(",",easyArray));

            // ***** STRINGS *****
            // Strings are immutable, so once you assign them a value, you can't change it
            string firstString = "First Name";
            string lastString = "Last Name";
            string fullName = string.Format("{0} {1}", firstString, lastString);
            Console.WriteLine("Strings");

            Console.WriteLine(fullName);

            // Using @ prior to a string allows you to avoid using escape characters like \n or \\ 
            string verb = @"I can enter txt
in different lines
and use paths much simpler
c:\users\bo
c:\users\io";
            Console.WriteLine(verb);
            //testing commit/push
        }
    }
}
