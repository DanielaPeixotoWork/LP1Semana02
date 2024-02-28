using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número não-negativo:");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Erro,Insira um numero inteiro não-negativo");
                return;
            }

            byte n = Convert.ToByte(input);

            Console.WriteLine($"Resultado de -n:{--n}");
            Console.WriteLine($"Resultado de +n:{++n}");
        }
    }
}
