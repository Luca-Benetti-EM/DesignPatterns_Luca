using ExercicioDP03.Concreto;
using ExercicioDP03.DecoradoresConcretos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP03
{
    class Program
    {
        static void Main(string[] args)
        {
            Coquetel coquetel1 = new Vodka("Vodka", 3);

            coquetel1 = new Suco(coquetel1, "Suco", 2);

            coquetel1 = new Gelo(coquetel1, "Gelo", 1);

            Console.WriteLine($"{coquetel1.getNome()} R${coquetel1.getPreco()}");

            //Coquetel coquetel2 = new Tequila("Tequila", 10);

            Console.ReadKey();
        }
    }
}
