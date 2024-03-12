using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprovacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a média do aluno: ");
             double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual de frequência do aluno: ");
             int presenca = int.Parse(Console.ReadLine());

            if (media >= 7 && presenca >= 75)
            {
                Console.WriteLine("O aluno está aprovado!");
            }

            else if (media < 7 && media >= 4 && presenca >= 75 || media>=7 && presenca<75)
            {
                Console.WriteLine("O aluno está de recuperação!");
            }

            else
            {
                Console.WriteLine("O aluno está retido.");
            }
            Console.ReadKey();
        }
    }
}
