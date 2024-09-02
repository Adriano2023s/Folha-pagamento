namespace FolhaPagamento
{
    internal class Salario
    {
        public string NomeFuncionario;
        public double SalarioBruto;
        public double Imposto;

        public Salario(string nomeFuncionario, double salarioBruto, double imposto)
        {
            NomeFuncionario = nomeFuncionario;
            SalarioBruto= salarioBruto;
            Imposto = imposto;
        }

        public double CalculaSalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double percentual)
        {
            double reajuste = SalarioBruto * (percentual / 100);
            SalarioBruto += reajuste;
        }
    }
}
