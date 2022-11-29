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
            Aluno a = new Aluno(6317602, "Felipe Freitas", "1 ADS", "233.620.578-30");
            arquivo.Gravar(a.RA + ";" + a.Nome + ";" + a.Turma + ";" + a.Cpf);
            Console.ReadKey();
        }
    }
}
