using System.Collections;

namespace Iterator
{
    public class IteradorArray<T> : IIterator<T>
    {
        protected ArrayList _lista;
        protected int _contador;

        public IteradorArray(ArrayList lista)
        {
            _lista = lista;
            _contador = 0;
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

        public T currentItem()
        {
            return (T)_lista[_contador];
        }
    }
}
