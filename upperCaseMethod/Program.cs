using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upperCaseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToLower();
                              

            Console.WriteLine('\n' + "What is your last name?");
            string lastName = Console.ReadLine().ToLower();

            upper(firstName, lastName);      //calls method with arguments
            
        }

        //upper case method
        static void upper(string f, string l)
        {
            char[] first = f.ToCharArray();     //converts firstName to array and splits into chars
            char[] last = l.ToCharArray();       //converts lastName to array and splits into chars

                             
            string newF = new string(first);      //declare new string based off char arrays
            string newL = new string(last);

            newF = newF.Replace(first[0], char.ToUpper(first[0]));     //replaces first index in char array with uppercase equivalent
            newL = newL.Replace(last[0], char.ToUpper(last[0]));       

            Console.WriteLine('\n' + "Hello " + newF + " " + newL);
            return;
        }
    }
}
