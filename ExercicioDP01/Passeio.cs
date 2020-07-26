using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class Passeio : IEstrategiaVeiculo
    {
        private int _periodo;
        private const int _hora = 1;
        private const int _dia = 24;
        private const int _mes = 720;

        public Passeio(int periodo)
        {
            _periodo = periodo;
        }

        public int Calcule()
        {
            Console.WriteLine($"Calcula Veículo de Paseeio - Periodo:{_periodo}");

            if (_periodo < 12 * _hora)
            {
                return (int)2.0 * (_periodo / _hora);
            }
            else if (_periodo > 12 * _hora && _periodo < 15 * _dia)
            {
                return (int)26.0 * (_periodo / _dia);
            }
            else
            {
                return (int)300.0 * (_periodo / _mes);
            }

        }
    }
}
