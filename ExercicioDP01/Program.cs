using ExercicioDP01.Veiculos;
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
            var calculoEstacionamento = new CalculoEstacionamento();

            var carro = new veiculoPasseio();
            var calculoPasseio = new CalculoPasseio(10);
            calculoEstacionamento.setEstrategia(calculoPasseio);
            calculoEstacionamento.Execute();

            var caminhao = new veiculoCarga(5, 100);
            var calculoCarga = new CalculoCarga(20, caminhao);
            calculoEstacionamento.setEstrategia(calculoCarga);
            calculoEstacionamento.Execute();

            Console.ReadKey();
        }
    }
}
