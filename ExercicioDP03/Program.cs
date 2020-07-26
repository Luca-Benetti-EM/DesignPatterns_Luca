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
            //COQUETEL 1
            Coquetel coquetel1 = new Vodka("Vodka", 3);
            coquetel1 = new Suco(coquetel1, "Suco", 2);
            coquetel1 = new Gelo(coquetel1, "Gelo", 1);
            Console.WriteLine($"{coquetel1.getNome()} R${coquetel1.getPreco()}");

            //COQUETEL 2
            Coquetel coquetel2 = new Tequila("Tequila", 10);
            coquetel2 = new Limao(coquetel2, "Limao", 2);
            coquetel2 = new Acucar(coquetel2, "Acucar", 4);
            Console.WriteLine($"{coquetel2.getNome()} R${coquetel2.getPreco()}");

            //COQUETEL 3
            Coquetel coquetel3 = new Cachaca("Cachaça", 7);
            coquetel3 = new LeiteCondensado(coquetel3, "Leite Condensado", 8);
            coquetel3 = new Acucar(coquetel3, "Acucar", 4);
            coquetel3 = new Gelo(coquetel3, "Gelo", 1);
            Console.WriteLine($"{coquetel3.getNome()} R${coquetel3.getPreco()}");

            Console.ReadKey();
        }
    }
}
