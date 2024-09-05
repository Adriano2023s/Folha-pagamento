namespace FolhaPagamento
{
    internal class Funcionario
    {
        public string NomeFuncionario { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }

        public Funcionario()
        {

        }
        
        public Funcionario(string nomeFuncionario, double salario, double imposto)
        {
            NomeFuncionario = nomeFuncionario;
            Salario = salario;
            Imposto = imposto;
        }

        public double CalculaSalarioLiquido()
        {
            double salarioLiquido= Salario - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double percentual)
        {
            double reajuste = Salario * (percentual / 100);
            Salario = Salario + reajuste;
        }
    }
}
