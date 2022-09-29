using Excepcion_Forma_T_Exception;

namespace Excepcion_Forma_T_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int valorUno = 0, valorDos = 0, resultado;

            try
            {
                Console.Write("Numero 1: ");
            valorUno = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            valorDos = int.Parse(Console.ReadLine());
            } catch(FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }

            try
            {
                resultado = valorUno / valorDos;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException dbzex)
            {
                Console.WriteLine(dbzex.Message);
            }
        }
    }
}
            */


            byte numeroChico = byte.MaxValue;
            try
            {

                  checked {
                      ++numeroChico;
                  }
                  Console.WriteLine(numeroChico);
            }
            catch (OverflowException ofex)  {
                 Console.WriteLine(ofex.Message);
            }


            Console.WriteLine("Final");
            Console.WriteLine();