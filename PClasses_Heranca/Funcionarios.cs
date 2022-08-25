using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses_Heranca
{
    internal class Funcionarios : Pessoa
    {
        String NumeroPis;
        float Salario;
        String Setor;

        public void setNumeroPis()
        {
            Console.WriteLine("Digite o numeo do seu PIS: ");
            NumeroPis = Console.ReadLine();
        }

        public void setSalario()
        {
            Console.WriteLine("Digite o valor de seu salario: ");
            Salario = float.Parse(Console.ReadLine());
        }

        public void setSetor()
        {
            Console.WriteLine("Informe o setor onde voce trabalha: ");
            Setor = Console.ReadLine();  
        }

        public void RegistroFuncionario()
        {
            setNumeroPis();
            setSalario();
            setSetor();
        }

        public override String ToString()
        {
            return base.ToString() + "Seu numero do PIS é: " + NumeroPis + "\nSeu salario é: " + Salario + "\nSeu setor: " + Setor;
        }
    }
}
