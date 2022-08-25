using System;

namespace PClasses_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cadastro Pessoa
            Console.WriteLine("Cadastro pessoa");
            Pessoa pessoa = new Pessoa();
            pessoa.RealizarCadastro(); //set
            Console.WriteLine("---");
            Console.WriteLine(pessoa.ToString());//get

            //Cadastro Aluno (herança)
            Console.WriteLine("Cadastro Pessoa/Aluno");
            Alunos aluno = new Alunos();
            aluno.RealizarCadastro();
            aluno.SetMatriculaTotal();
            Console.WriteLine("---");
            Console.WriteLine(aluno.ToString());

            //Cadastro Funcionatrio (herança) 
            Console.WriteLine("Cadastro Pessoa/Funcionario");
            Funcionarios funcionario = new Funcionarios();
            funcionario.RealizarCadastro();
            funcionario.RegistroFuncionario();
            Console.WriteLine("---");          
            Console.WriteLine(funcionario.ToString());
        }
    }
}
