using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Todos os Mínimos e Máximos de todos os valores especiais:");

            Console.WriteLine($"Valor Mínimo de sbyte: {sbyte.MinValue}");
            Console.WriteLine($"Valor Máximo de sbyte: {sbyte.MaxValue}");

            Console.WriteLine($"Valor Mínimo de byte: {byte.MinValue}");
            Console.WriteLine($"Valor Máximo de byte: {byte.MaxValue}");

            Console.WriteLine($"Valor Mínimo de short: {short.MinValue}");
            Console.WriteLine($"Valor Máximo de short: {short.MaxValue}");

            Console.WriteLine($"Valor Mínimo de ushort: {ushort.MinValue}");
            Console.WriteLine($"Valor Máximo de ushort: {ushort.MaxValue}");

            Console.WriteLine($"Valor Mínimo de int: {int.MinValue}");
            Console.WriteLine($"Valor Máximo de int: {int.MaxValue}");

            Console.WriteLine($"Valor Mínimo de uint: {uint.MinValue}");
            Console.WriteLine($"Valor Máximo de uint: {uint.MaxValue}");

            Console.WriteLine($"Valor Mínimo de long: {long.MinValue}");
            Console.WriteLine($"Valor Máximo de long: {long.MaxValue}");

            Console.WriteLine($"Valor Mínimo de ulong: {ulong.MinValue}");
            Console.WriteLine($"Valor Máximo de ulong: {ulong.MaxValue}");

            Console.WriteLine($"Valor Mínimo de float: {float.MinValue}");
            Console.WriteLine($"Valor Máximo de float: {float.MaxValue}");
            Console.WriteLine($"Valor de -∞ em float: {float.NegativeInfinity}");
            Console.WriteLine($"Valor de +∞ em float: {float.PositiveInfinity}");
            Console.WriteLine($"Valor de NaN em float: {float.NaN}");

            Console.WriteLine($"Valor Mínimo de double: {double.MinValue}");
            Console.WriteLine($"Valor Máximo de double: {double.MaxValue}");
            Console.WriteLine($"Valor de +∞ em double: {double.PositiveInfinity}");
            Console.WriteLine($"Valor de +∞ em double: {double.PositiveInfinity}");
            Console.WriteLine($"Valor de NaN em double: {double.NaN}");
            Console.WriteLine($"Valor de NaN em double: {double.NaN}");

            Console.WriteLine($"Valor Mínimo de decimal: {decimal.MinValue}");
            Console.WriteLine($"Valor Máximo de decimal: {decimal.MaxValue}");

            Console.WriteLine($"Valor Mínimo de char: {(int)char.MinValue}");
            Console.WriteLine($"Valor Máximo de char: {(int)char.MaxValue}");

            Console.WriteLine($"Valor Mínimo de bool: {bool.FalseString}");
            Console.WriteLine($"Valor Máximo de bool: {bool.TrueString}");

            int i = short.MaxValue; //32767
            Console.WriteLine(( short) ( i + 1));

            float x1 = 2 * float.MaxValue;
            Console.WriteLine($"float overflow:{x1}");

            float x2 = float.MaxValue + 1;
            Console.WriteLine($"float overflow:{x2}");

            float y1, y2;
            y1 = y2 = 10000.0f;
            Console.WriteLine(y1 == y2 + 0.0001f);

            Console.ReadKey();

        }
    }
}
