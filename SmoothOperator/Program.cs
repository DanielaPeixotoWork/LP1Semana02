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
            Console.WriteLine($"Resultado de %2: {n / 2}");
            Console.WriteLine($"Resultado de shift left 3: {n << 3}");
            Console.WriteLine($"Resultado de xor com 5: {n ^ 5}");
            Console.WriteLine($"É maior que 10? {n > 10}");
        }
    }
}
