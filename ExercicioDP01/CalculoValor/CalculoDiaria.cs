using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class CalculoDiaria : CalculoValor
    {
        private double _inicio;
        private double _fim;
        public double Calcular(double inicio, double fim)
        {
            _inicio = inicio;
            _fim = fim;
            return 0;
        }
    }
}
