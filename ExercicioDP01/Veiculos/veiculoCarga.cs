using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01.Veiculos
{
    public class veiculoCarga : IVeiculo
    {
        private int _quantidadeEixos;
        private double _valorDaCarga;

        public veiculoCarga(int quantidadeEixos, double valorDaCarga)
        {
            _quantidadeEixos = quantidadeEixos;
            _valorDaCarga = valorDaCarga;
        }

        public int ObtenhaQuantidadeDeEixos()
        {
            return _quantidadeEixos;
        }

        public double ObtenhaValorDaCarga()
        {
            return _valorDaCarga;
        }
    }
}
