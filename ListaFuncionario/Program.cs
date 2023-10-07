
using System;

namespace ListaFuncionario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Console.Write("Digite a quantidade de funionários a ser contradada: ");
            int n = int.Parse(Console.ReadLine());
            AdicionarFunionarios(n, funcionarios);


            //Mostrando funcionarios
            ExibirFuncionarios(funcionarios);
            Console.Write("\nDigite o Id do funcionário que receberá o aumento: ");
            int idTemp = int.Parse(Console.ReadLine());
            Funcionario funcionarioTemp = funcionarios.Find(x => x.Id == idTemp);
            if (funcionarioTemp != null) 
            {
                Console.Write($"Digite o aumento de salário de {funcionarioTemp.Nome}: ");
                funcionarioTemp.AumentarSalario(double.Parse(Console.ReadLine()));
            } else Console.WriteLine("Esse ID não existe!");
            Console.WriteLine("dados atualizados:");
            ExibirFuncionarios(funcionarios);


        }

        private static void AdicionarFunionarios(int n, List<Funcionario> f){
            for(int i = 0; i < n; i++) {
                Console.Write("Digite um Id válido para o novo usuário: ");
                int idTemp = int.Parse(Console.ReadLine());
                if(f.Find(x => x.Id ==  idTemp) == null){
                    Console.Write("Digite um nome para esse novo usuário: ");
                    string nomeTemp = Console.ReadLine();
                    Console.Write($"Digite o salário de {nomeTemp}: ");
                    double salarioTemp = double.Parse(Console.ReadLine());
                    f.Add(new Funcionario(idTemp, nomeTemp, salarioTemp));
                } else Console.WriteLine("esse id já existe!");
                Console.Clear();
            }
        }
        
        private static void ExibirFuncionarios(List<Funcionario> f)
        {
            if (f.Count > 0) f.ForEach(x => Console.WriteLine(x));
        }
    }
}