using ExercicioDP01.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class CalculoEstacionamento
    {
        private CalculoValor _calculoValor;

        public void setEstrategia(CalculoValor calculoValor)
        {
            _calculoValor = calculoValor;
        }

        public void Execute()
        {
            _calculoValor.Calcule();
        }
    }
}
