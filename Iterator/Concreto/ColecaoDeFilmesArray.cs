using System.Collections;

namespace Iterator.Concreto
{
    public class ColecaoDeFilmesArray : IColecaoAggregate<Filme>
    {
        protected ArrayList _filmes;
        protected int _contador;

        public ColecaoDeFilmesArray()
        {
            _filmes = new ArrayList()
            {
                new Filme("Poeira em alto mar - Array"),
                new Filme("E o vento levou - Array"),
                new Filme("Titanic - Array")
            };
        }

        public IIterator<Filme> CreateIterator()
        {
            return new IteradorArray<Filme>(_filmes);
        }
    }
}
