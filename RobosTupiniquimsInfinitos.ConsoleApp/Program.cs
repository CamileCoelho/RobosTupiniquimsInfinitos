namespace RobosTupiniquimsInfinitos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int maxCol, maxRow, posicaoX, posicaoY;
                char orientacao;
                string coordenadas;

                Console.Clear();

                Console.Write("Robô Tupiniquim");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Digite quantas colunas deseja para delimitar o seu grid:");
                maxCol = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite quantas linhas deseja para delimitar o seu grid:");
                maxRow = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Escreva a posição X em que seu Robô Tupiniquim se encontra: ");
                posicaoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Escreva a posição Y em que seu Robô Tupiniquim se encontra: ");
                posicaoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Escreva a Orientação Geográfica em que seu Robô Tupiniquim se encontra (Norte, Sul, Leste ou Oeste): ");
                orientacao = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                Console.WriteLine();
                Console.WriteLine("A posição inicial do Robô Tupiniquim é (" + posicaoX + "," + posicaoY + ")" + orientacao + ".");
                Console.WriteLine();
              
                Console.Write("Escreva as coordenadas para o seu Robô Tupiniquim se deslocar:");
                coordenadas = Convert.ToString(Console.ReadLine());

                char[] coordenadasChar = coordenadas.ToUpper().ToCharArray();

                foreach (char coordenada in coordenadasChar)
                {
                    switch (coordenada)
                    {
                        case 'M':

                            if (orientacao == 'N' )
                            {
                                posicaoY = posicaoY + 1;
                            }
                            else if (orientacao == 'S' )
                            {
                                posicaoY = posicaoY - 1;
                            }
                            else if (orientacao == 'L' )
                            {
                                posicaoX = posicaoX + 1;
                            }
                            else if (orientacao == 'O' )
                            {
                                posicaoX = posicaoX - 1;
                            }
                            break;

                        case 'E':

                            switch (orientacao)
                            {
                                case 'N':
                                    orientacao = 'O';
                                    break;
                                case 'S':
                                    orientacao = 'L';
                                    break;
                                case 'L':
                                    orientacao = 'N';
                                    break;
                                case 'O':
                                    orientacao = 'S';
                                    break;
                            }
                            break;

                        case 'D':

                            switch (orientacao)
                            {
                                case 'N':
                                    orientacao = 'L';
                                    break;
                                case 'S':
                                    orientacao = 'O';
                                    break;
                                case 'L':
                                    orientacao = 'S';
                                    break;
                                case 'O':
                                    orientacao = 'N';
                                    break;
                            }
                            break;

                    }
                                       
                }

                if (posicaoX < 0 || posicaoX > maxCol || posicaoY < 0 || posicaoY > maxRow)
                {
                    Console.WriteLine();
                    Console.WriteLine("O Robô Tupiniquim bateu na parede, tente novamente.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("A posição final do Robô Tupiniquim é (" + posicaoX + "," + posicaoY + ")" + orientacao + ".");
                    Console.ReadLine();
                }

            } while (true);
        }
    }
}