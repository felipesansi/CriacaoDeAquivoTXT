using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manipula arquivo = new Manipula();
            //Aluno a = new Aluno(6317603, "Vinicius", "1 ADS", "233.720.578-30");
            //arquivo.Gravar(a.RA + ";" + a.Nome + ";" + a.Turma + ";" + a.Cpf);
            List<Aluno> Alunos = arquivo.ler();
            string texto = null;
            foreach(Aluno fuçano in Alunos)
            {
                texto += " \nRa =" +fuçano.RA + "- Nome =" +fuçano.Nome + " - Curso = "+fuçano.Turma + " - CPF = " +fuçano.Cpf;
            }
             Aluno a = new Aluno(6317699, "Vinicius", "1 ADM", "233.720.578-30");
            arquivo.Alterar(a);
            Console.WriteLine(texto);
            Console.ReadKey();

        }
        
    }
}
