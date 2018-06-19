using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            RomanConverter converter = new RomanConverter();
            Console.WriteLine(converter.Convert(3888));
            Console.ReadLine();

        }
    }
}
