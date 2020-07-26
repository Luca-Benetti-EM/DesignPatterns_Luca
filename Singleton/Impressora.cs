using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Impressora
    {
        private static Impressora _instancia;

        private readonly string _nomeDaImpressora;

        private Impressora(string nomeDaImpressora) //Recebe string para evidenciar que ocorre apenas a primeira instância
        {
            _nomeDaImpressora = nomeDaImpressora;
        }

        public static Impressora ObtenhaInstancia(string nomeDaImpressora) //Recebe string para evidenciar que ocorre apenas a primeira instância 
        { 
            if (_instancia == null)
            {
                _instancia = new Impressora(nomeDaImpressora);
            }

            return _instancia;
        }

        public void Imprimir()
        {
            Console.WriteLine($"{_nomeDaImpressora} - Imprimindo!");
        }
    }
}
