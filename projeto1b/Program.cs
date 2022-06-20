using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            mclan aluno;
            aluno = new mclan();
            mclan professor = new mclan();
            aluno.nome = "iguinho";
            professor.nome = "prof.iguinhotenhofuego";
            Console.WriteLine("aluno:" + aluno.nome);
            Console.WriteLine("professor:" + professor.nome);
            Console.ReadKey();
        }
    }
}
