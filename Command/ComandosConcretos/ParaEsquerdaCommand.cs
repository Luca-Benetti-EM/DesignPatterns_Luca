using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ComandosConcretos
{
    public class ParaEsquerdaCommand : CarrinhoCommand
    {
        public double graus { get; set; }

        public ParaEsquerdaCommand(Carrinho carrinho) : base(carrinho) { }

        public override void Execute()
        {
            _carrinho.ParaEsquerda(graus);
        }
    }
}
