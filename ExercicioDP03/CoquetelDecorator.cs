using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP03
{
    public class CoquetelDecorator : Coquetel
    {
        Coquetel _coquetel;

        public CoquetelDecorator(Coquetel coquetel)
        {
            _coquetel = coquetel;
        }

        public override string getNome()
        {
            return _coquetel.getNome() + " + " + _nome;
        }

        public override double getPreco()
        {
            return _coquetel.getPreco() + _preco;
        }

    }
}
