using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses_Heranca
{
    internal class Alunos : Pessoa
    {
        String Registro;
        String DataMatricula;


        public Alunos()
        {

        }
        public void setRegistro()
        {
            Console.WriteLine("Insira o numero de seu RA (seguindo o modelo XXXX-X): ");
            Registro = Console.ReadLine();
        }
        public void setDataMatricula()
        {
            Console.WriteLine("Insira a data de sua matricula: (xx/xx/xxxx");
            DataMatricula = (Console.ReadLine());
        }

        public void SetMatriculaTotal()
        {
            setRegistro();
            setDataMatricula();
        }
        public override String ToString()
        {
            return base.ToString() + "Registro: " + Registro + "\nData de matricula: " + DataMatricula;
        }
    }
}
