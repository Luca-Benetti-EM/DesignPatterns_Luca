using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CarrinhoControle
    {
        public Queue<CarrinhoCommand> Comandos;

        public CarrinhoControle()
        {
            Comandos = new Queue<CarrinhoCommand>();
        }

        public void ExecuteComandos()
        {
            Console.WriteLine("EXECUTANDO COMANDOS");

            while(Comandos.Count > 0)
            {
                CarrinhoCommand comando = Comandos.Dequeue();
                comando.Execute();
            }
        }
    }
}
