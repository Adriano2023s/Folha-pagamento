using System;

namespace FolhaPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario s = new Salario("Adriano", 1000, 10);

            Console.WriteLine($"O funcionário: {s.NomeFuncionario}.");
            Console.WriteLine($"Salário antigo é de: R${s.SalarioBruto}");

            double salarioLiquido = s.CalculaSalarioLiquido();
            Console.WriteLine($"O salário líquido atual é de: R${salarioLiquido}");

            s.AumentarSalario(1000);
            Console.WriteLine($"O salário atual é de: R${s.SalarioBruto}");
        }
    }
}
