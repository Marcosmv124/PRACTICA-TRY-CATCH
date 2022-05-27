using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones___cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Martinez Valdez Marcos 21210398
                try 
                { 
                Console.Write("Ingrese un numero: "); 
                int Num1 = Int32.Parse(Console.ReadLine());

                Console.Write("ingrese el siguiente Numero: ");
                int Num2 = Int32.Parse(Console.ReadLine());

                Console.WriteLine(Num1 / Num2);
                Console.ReadLine();
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message); 
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("Para salir del programa presione enter: "); 
                Console.ReadKey(); 
        }
    }
}
