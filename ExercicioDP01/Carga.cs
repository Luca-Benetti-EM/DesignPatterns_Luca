using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class Carga : IEstrategiaVeiculo
    {
        private int _periodo;
        private int _eixo;
        private int _valorDaCarga;

        public Carga(int periodo, int eixo, int valorDaCarga)
        {
            _periodo = periodo;
            _eixo = eixo;
            _valorDaCarga = valorDaCarga;
        }

        public int Calcule()
        {
            Console.WriteLine($"Calcula Veículo de Carga - Periodo:{_periodo}, Eixo:{_eixo}, Carga:{_valorDaCarga}");

            return 1;
        }
    }
}
