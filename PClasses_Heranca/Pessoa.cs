using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses_Heranca
{
    internal class Pessoa
    {
        String Nome, Cpf, DataNascimento;


        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, string dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public void setNome()
        {
            Console.WriteLine("Insira um nome: ");
            this.Nome = Console.ReadLine();
        }

        public void setData()
        {
            Console.WriteLine("Insira uma Data (no modelo dia/mes/ano): ");
            this.DataNascimento = Console.ReadLine();
        }

        public void setDocumento()
        {
            Console.Write("Informe a o cpf da primeira pessoa (seguindo o modelo 'XXX.XXX.XXX-XX'): ");
            this.Cpf = (Console.ReadLine());
        }

        public void getNome()
        {
            Console.WriteLine("O nome informado foi: " + this.Nome);
        }

        public void getData()
        {
            Console.WriteLine("A data de nascimento informada por " + this.Nome + " informada foi: " + this.DataNascimento);
        }

        public void getDocumento()
        {
            Console.WriteLine("o cpf de" + this.Nome + " é correspondete a " + this.Cpf);
        }

        public void RealizarCadastro()
        {
            setNome();
            setData();
            setDocumento();
        }

        public override String ToString()
        {
            return "O seu nome é: " + Nome + "\nsua data de nascimento é: " + DataNascimento + "\nSeu CPF é: " + Cpf;
        }
    }
}
