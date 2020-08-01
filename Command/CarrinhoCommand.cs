using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class CarrinhoCommand
    {
        protected Carrinho _carrinho;

        public CarrinhoCommand(Carrinho carrinho)
        {
            _carrinho = carrinho;
        }

        public abstract void Execute();
    }
}
