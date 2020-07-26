using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            string _nomeDaImpressora;

            do
            {
                Console.WriteLine("Escreva o nome da sua impressora");

                _nomeDaImpressora = Console.ReadLine();

                Impressora impressora = Impressora.ObtenhaInstancia(_nomeDaImpressora); //Sempre será o nome da primeira instância

                impressora.Imprimir();

            } while (_nomeDaImpressora != "sair");
        }
    }
}
