using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inner.Private innerprivate = new Inner.Private();

            Console.WriteLine("Enter the number:");

            int n = int.Parse(Console.ReadLine());

            if (innerprivate.Power(n))

            {

                Console.WriteLine(n + " is power of 2");

            }

            else

            {

                Console.WriteLine(n + " is not power of 2");

            }

        }
    }
    
}
