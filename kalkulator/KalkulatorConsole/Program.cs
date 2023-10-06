using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;

            var cal = new Calculator();
            Console.WriteLine(a + " + " + b + " = " + cal.Tambah(a, b));
            Console.WriteLine(a + " - " + b + " = " + cal.Kurang(a, b));

            Console.ReadKey();
        }
    }

    class Calculator
    {
        public int Tambah(int a, int b)
        {
            return a + b;
        }

        public int Kurang(int a, int b)
        {
            return a - b;
        }
    }
}
