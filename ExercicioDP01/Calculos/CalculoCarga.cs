using ExercicioDP01.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class CalculoCarga : CalculoValor
    {
        private veiculoCarga _veiculo;

        public CalculoCarga(int periodo, veiculoCarga veiculo) : base(periodo)
        {
            _veiculo = veiculo;
            _periodo = periodo;
        }

        public override double Calcule()
        {
            Console.WriteLine($"Calcula Veículo de Carga - Periodo:{_periodo}, Eixo:{_veiculo.ObtenhaQuantidadeDeEixos()}, Carga:{_veiculo.ObtenhaValorDaCarga()}");
            return 0;
        }
    }
}
