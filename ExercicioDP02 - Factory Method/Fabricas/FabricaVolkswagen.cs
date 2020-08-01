using ExercicioDP02___Factory_Method.Carros;

namespace ExercicioDP02___Factory_Method.Fabricas
{
    public class FabricaVolkswagen : FabricaDeCarro
    {
        public Carro CriarCarro()
        {
            return new Gol();
        }
    }
}
