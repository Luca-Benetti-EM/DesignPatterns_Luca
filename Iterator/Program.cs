using Iterator.Concreto;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            IColecaoAggregate<Filme> filmesLista = new ColecaoDeFilmesLista();

            for(IIterator<Filme> it = filmesLista.CreateIterator(); !it.isDone(); it.next())
            {
                Console.WriteLine(it.currentItem().Nome);
            }


            IColecaoAggregate<Filme> filmesArray = new ColecaoDeFilmesArray();

            for (IIterator<Filme> it = filmesArray.CreateIterator(); !it.isDone(); it.next())
            {
                Console.WriteLine(it.currentItem().Nome);
            }

        }
    }
}
