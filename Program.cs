using System;

namespace FolhaPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário \n");
            f.NomeFuncionario = Console.ReadLine();

            Console.WriteLine($"Digite o salário atual que o funcionario: {f.NomeFuncionario} recebe");
            f.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o imposto que será descontado do salário: R${f.Salario}, do funcionário: {f.NomeFuncionario}");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"O funcionário: {f.NomeFuncionario}, recebe como salário: R${f.Salario}, e é descontado de imposto: {f.Imposto}");

            Console.WriteLine($"Qual o percentual de almento para o funcionário: {f.NomeFuncionario}");
            double aumento = double.Parse(Console.ReadLine());
            f.AumentarSalario(aumento);

            double salarioLiquido = f.CalculaSalarioLiquido();

            Console.WriteLine($"O salário atual do funcionário é: {f.NomeFuncionario}, é de: R${salarioLiquido}");
            }
    }
}
