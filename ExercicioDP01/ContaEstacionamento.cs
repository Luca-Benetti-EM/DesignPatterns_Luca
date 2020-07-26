using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class ContaEstacionamento
    {
        private CalculoValor _veiculo;
        private double _inicio;
        private double _fim;

        public ContaEstacionamento(CalculoValor veiculo, double inicio, double fim)
        {
            _veiculo = veiculo;
            _inicio = inicio;
            _fim = fim;
        }

        private double getPeriodo()
        {
            return _fim - _inicio;
        }

        public double ValorConta()
        {
            return _veiculo.Calcular(_inicio, _fim);
        }
    }
}
