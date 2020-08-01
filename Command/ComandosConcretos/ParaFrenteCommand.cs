using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ComandosConcretos
{
    public class ParaFrenteCommand : CarrinhoCommand
    {
        public int distancia { get; set; }
        public ParaFrenteCommand(Carrinho carrinho) : base(carrinho) { }
        public override void Execute()
        {
            _carrinho.ParaFrente(distancia);
        }
    }
}
