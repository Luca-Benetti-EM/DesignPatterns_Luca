using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP03.DecoradoresConcretos
{
    public class Limao : CoquetelDecorator
    {
        public Limao(Coquetel coquetel, string nome, double preco) : base(coquetel)
        {
            _nome = nome;
            _preco = preco;
        }
    }
}
