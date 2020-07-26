using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calculoDiaria = new CalculoDiaria();
            var calculo15Minutos = new Calculo15Minutos();
            var calculoCarga = new CalculoCarga();

            var contaEstacionamento = new ContaEstacionamento(calculoDiaria, 0, 10);
            var valorContaEstacionamento = contaEstacionamento.ValorConta();

            Console.ReadKey();
        }
    }
}
