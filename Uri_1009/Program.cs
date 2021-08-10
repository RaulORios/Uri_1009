using System;
using System.Globalization;

namespace Uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int comissao = 15;
            double salario_final = salario + (((double)comissao / 100) * vendas);

            Console.WriteLine($"TOTAL = R$ {salario_final.ToString("F2", CultureInfo.InvariantCulture)}");
                        
        }
    }
}
