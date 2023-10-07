
namespace ListaFuncionario
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }


        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double salarioPorcentagem)
        {
            if(salarioPorcentagem <= 1) Salario += (Salario * salarioPorcentagem);
        }

        public override string ToString()
        {
            return $"Id {Id}, Funcionário(a) {Nome}, Salário de R${Salario}";
        }
    }
}
