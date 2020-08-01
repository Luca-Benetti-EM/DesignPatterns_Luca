namespace Command
{
    public class Carrinho
    {
        public void ParaFrente(int distancia)
        {
            System.Console.WriteLine($"O carrinho foi {distancia}cm para frente");
        }

        public void ParaTras(int distancia)
        {
            System.Console.WriteLine($"O carrinho foi {distancia}cm para trás");
        }

        public void ParaDireita(double graus)
        {
            System.Console.WriteLine($"O carrinho foi {graus} graus para direita");
        }

        public void ParaEsquerda(double graus)
        {
            System.Console.WriteLine($"O carrinho foi {graus} graus para esquerda");
        }
    }
}