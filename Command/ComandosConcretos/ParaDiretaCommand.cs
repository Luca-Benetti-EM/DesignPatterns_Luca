using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ComandosConcretos
{
    public class ParaDiretaCommand : CarrinhoCommand
    {
        public double graus { get; set; }

        public ParaDiretaCommand(Carrinho carrinho) : base(carrinho) { }

        public override void Execute()
        {
            _carrinho.ParaDireita(graus);
        }
    }
}
