using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JaggedArray.amin();
            Console.WriteLine("JaggedArray ..");

            twoDimemsoinal.amin2();
            Console.WriteLine();

            Console.WriteLine("twoDimemsoinal ..");

            oneDimensional.amin3();

            Console.WriteLine("oneDimensional ..");

        }
    }
}
