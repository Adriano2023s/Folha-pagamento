namespace FolhaPagamento
{
    internal class Funcionario
    {
        private string _NomeFuncionario;
        private double _Salario;
        private double _Imposto;

        public string NomeFuncionario
        {
            get
            {
                return _NomeFuncionario;
            }
            set
            {
                _NomeFuncionario = value;
            }
        }

        public double Salario
        {
            get
            {
                return _Salario;
            }
            set
            {
                _Salario = value;
            }
        }

        public double Imposto
        {
            get
            {
                return _Imposto;
            }
            set
            {
                _Imposto = value;
            }
        }

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
