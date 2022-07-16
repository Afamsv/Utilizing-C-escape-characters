using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_special_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'z';
            char ch2 = 'x';

            Console.WriteLine("This is the first line of text");
            Console.WriteLine("\n\n\nSkkippd three lines");
            Console.WriteLine("one\ttwo\tthree < -tabbed");
            Console.WriteLine(" A qoute: \' \ndouble qoute: \"");
            Console.WriteLine("\n ch1 = {0} ch2 = {1}", ch1, ch2);
        }
    }
}
