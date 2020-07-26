using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class Contexto
    {
        private IEstrategiaVeiculo _estrategiaVeiculo;

        public void setEstrategia(IEstrategiaVeiculo estrategiaVeiculo)
        {
            _estrategiaVeiculo = estrategiaVeiculo;
        }

        public void Execute()
        {
            _estrategiaVeiculo.Calcule();
        }
    }
}
