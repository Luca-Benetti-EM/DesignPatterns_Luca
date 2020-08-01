using ExercicioDP02___Factory_Method.Fabricas;
using System;

namespace ExercicioDP02___Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabricaChevrolet = new FabricaChevrolet();
            var celta = fabricaChevrolet.CriarCarro();
            celta.exibirInfo();
        }
    }
}
