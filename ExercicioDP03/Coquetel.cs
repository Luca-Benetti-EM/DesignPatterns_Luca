using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP03
{
    public abstract class Coquetel
    {
        protected string _nome;
        protected double _preco;

        public virtual string getNome()
        {
            return _nome;
        }

        public virtual double getPreco()
        {
            return _preco;
        }
    }
}
