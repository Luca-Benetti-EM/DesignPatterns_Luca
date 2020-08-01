using System.Collections.Generic;

namespace Iterator
{
    public class IteradorLista<T> : IIterator<T>
    {
        protected IList<T> _lista;
        protected int _contador;

        public IteradorLista(IList<T> lista)
        {
            _lista = lista;
            _contador = 0;
        }

        public T currentItem()
        {
            return _lista[_contador];
        }

        public void first()
        {
            _contador = 0;
        }

        public bool isDone()
        {
            return (_contador == _lista.Count);
        }

        public void next()
        {
            _contador++;
        }
    }
}
