namespace FolhaPagamento
{
    internal class Funcionario
    {
        public string NomeFuncionario;
        public double Salario;
        public double Imposto;

        public Funcionario(string nomeFuncionario, double salario, double imposto)
        {
            NomeFuncionario = nomeFuncionario;
            Salario = salario;
            Imposto = imposto;
        }

        public Funcionario()
        {

        }

        public double CalculaSalarioLiquido()
        {
            double salarioLiquido = Salario - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double percentual)
        {
            double reajuste = Salario * (percentual / 100);
            Salario += reajuste;
        }
    }
}
