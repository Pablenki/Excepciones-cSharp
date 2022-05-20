using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_T1
{
    class Program
    {
        static void Main(string[] args)
        {       
            try
            {
                Console.Write(" Ingrese el primer numero: ");
                int Num1 = int.Parse(Console.ReadLine());
                Console.Write(" Ingrese el segundo numero: ");
                int Num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(Num1 / Num2);
                Console.ReadKey();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }     
    }
}
