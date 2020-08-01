using Command.ComandosConcretos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            CarrinhoControle controle = new CarrinhoControle();

            var paraFrente = new ParaFrenteCommand(carrinho);
            paraFrente.distancia = 10;
            controle.Comandos.Enqueue(paraFrente);

            var paraTras = new ParaTrasCommand(carrinho);
            paraTras.distancia = 20;
            controle.Comandos.Enqueue(paraTras);

            var paraDireita = new ParaDiretaCommand(carrinho);
            paraDireita.graus = 5;
            controle.Comandos.Enqueue(paraDireita);

            var paraEsquerda = new ParaEsquerdaCommand(carrinho);
            paraEsquerda.graus = 3;
            controle.Comandos.Enqueue(paraEsquerda);

            controle.ExecuteComandos();
            Console.ReadKey();
        }
    }
}
