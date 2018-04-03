using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVaribales
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = byte.MinValue;
            byte b2 = byte.MaxValue;
            Console.WriteLine("byte Min = " + b1 + "\nbyte Max = " + b2);
            int x1 = int.MinValue;
            int x2 = int.MaxValue;
            Console.WriteLine("int Min = " + x1 + "\nint Max = " + x2);
            float f1 = float.MinValue;
            float f2 = float.MaxValue;
            Console.WriteLine("float Min = " + f1 + "\nfloat Max = " + f2);
            double d1 = double.MinValue;
            double d2 = double.MaxValue;
            Console.WriteLine("double Min = " + d1 + "\ndouble Max = " + d2);
            decimal de1 = decimal.MinValue;
            decimal de2 = decimal.MaxValue;
            Console.WriteLine("decimal Min = " + de1 + "\ndecimal Max = " + de2);

            Console.ReadKey();

        }
    }
}
