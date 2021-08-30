using System;

namespace exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
{
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int resultado = n1 / n2;
                Console.WriteLine(resultado);
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Formato inválido.");
                Console.ReadKey();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possivel efetuar divisão por 0.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
