using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDP01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _contexto = new Contexto();

            _contexto.setEstrategia(new Passeio(10));

            _contexto.Execute();

            _contexto.setEstrategia(new Carga(20, 30, 40));

            _contexto.Execute();

            Console.ReadKey();
        }
    }
}
