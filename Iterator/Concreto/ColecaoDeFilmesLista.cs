using System.Collections.Generic;

namespace Iterator.Concreto
{
    public class ColecaoDeFilmesLista : IColecaoAggregate<Filme>
    {
        protected IList<Filme> _filmes;

        public ColecaoDeFilmesLista()
        {
            _filmes = new List<Filme>
            {
                new Filme("Poeira em alto mar - Lista"),
                new Filme("E o vento levou - Lista"),
                new Filme("Titanic - Lista")
            };
        }

        public IIterator<Filme> CreateIterator()
        {
            return new IteradorLista<Filme>(_filmes);
        }
    }
}
