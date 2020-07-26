using ExercicioDP01.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class CalculoPasseio : CalculoValor
    {
        
        private const int _hora = 1;
        private const int _dia = 24;
        private const int _mes = 720;

        public CalculoPasseio(double periodo) : base(periodo)
        {
            _periodo = periodo;
        }

        public override double Calcule()
        {
            Console.WriteLine($"Calcula Veículo de Paseeio - Periodo:{_periodo}");

            if (_periodo < 12 * _hora)
            {
                return (double)2.0 * (_periodo / _hora);
            }
            else if (_periodo > 12 * _hora && _periodo < 15 * _dia)
            {
                return (double)26.0 * (_periodo / _dia);
            }
            else
            {
                return (double)300.0 * (_periodo / _mes);
            }

        }

    }
}
