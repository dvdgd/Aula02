using exerc01.Classes;
using exerc01.Classes.Enum;
using System;

namespace exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new()
            {
                Id = 1,
                Nome = "Francisco",
                TipoFunc = TipoFuncionario.Contradado
            };

            Console.WriteLine(func);

            //Convertendo string
            string strTpFunc = func.TipoFunc.ToString();
            Console.WriteLine(strTpFunc);

            //Convertendo String (Lendo do teclado)
            Console.WriteLine("Digite o tipo de especialização do funcionario: ");
            TipoFuncionario tp1 = (TipoFuncionario)Enum.Parse(typeof(TipoFuncionario), Console.ReadLine());
            Console.WriteLine(tp1);

            //Convertendo Númerico (Lendo do teclado)
            Console.Write("Digite o tipo de funcionario: ");
            TipoFuncionario tp2 = (TipoFuncionario)int.Parse(Console.ReadLine());
            Console.WriteLine(tp2);


        }
    }
}
