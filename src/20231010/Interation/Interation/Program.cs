using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);

            }
            string input = string.Empty;

            while (input.Length < 5)
                do
                {
                    Console.Write("Ihre Eingabe: ");
                    input = Console.ReadLine();
                }
                while (input.Length < 5);
        }
    }
}
