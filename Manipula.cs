using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    public class Manipula
    {
        private string caminho = "E://aula14/Dados.txt";

        public void Gravar(string texto)
        {
            StreamWriter sw = new StreamWriter(caminho);
            sw.WriteLine(texto);
            sw.Close();

        }
        public List<Aluno> ler()
        {
            var list = new List<Aluno>();
            if (File.Exists(caminho))
            {
                StreamReader sr = File.OpenText(caminho);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    Aluno alguem = new Aluno(int.Parse(arquivo[0]), arquivo[1], arquivo[2], arquivo[3]);
                    list.Add(alguem);
                }
            }
            return list;
        }
        public void Alterar(Aluno a)
        {
            string texto = null;
            if (File.Exists(caminho))
            {
                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (int.Parse(arquivo[0]) == a.RA)
                        {
                            string nova = a.RA + ";" + a.Nome + ";" + a.Turma + ";" + a.Cpf + "\n";
                            texto += nova;
                        }
                        else
                        {
                            texto += linha + "\n";
                        }
                    }sr.Close();
                    File.Delete(caminho);
                    StreamWriter sw = new StreamWriter(caminho);
                    sw.WriteLine(texto);
                    sw.Close(); 
                }
                
                VBBV
            }
        }
    }
}
