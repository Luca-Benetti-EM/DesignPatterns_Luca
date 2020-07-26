using ExercicioDP01.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public abstract class CalculoValor
    {
        protected double _periodo;

        public CalculoValor(double periodo)
        {
            _periodo = periodo;
        }

        public abstract double Calcule();
    }
}
