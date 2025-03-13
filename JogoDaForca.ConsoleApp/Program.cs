using System.Formats.Asn1;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);

            string palavraEscolhida = palavras[indiceEscolhido];

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for(int caracter = 0; caracter < palavraEscolhida.Length; caracter++)
            {
                letrasEncontradas[caracter] = '_';
            }

            int Erros = 0;
            bool jogadorEnforcou = false;
            bool jogadorAcertou = false;
            do
            {

                string cabecaDoBoneco = Erros >= 1 ? " o " : " ";
                string bracoEsquerdo = Erros >= 3 ? "/" : " ";
                string bracoDireito = Erros >= 4 ? "\\" : " ";
                string troncoCima = Erros >= 2 ? "x" : " ";
                string troncoBaixo = Erros >= 2 ? " x " : " ";
                string pernas = Erros >= 5 ? "/ \\" : " ";

                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" ___________        ");
                Console.WriteLine(" |/        |        ");
                Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
                Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, troncoCima, bracoDireito);
                Console.WriteLine(" |        {0}       ", troncoBaixo);
                Console.WriteLine(" |        {0}       ", pernas);
                Console.WriteLine(" |                  ");
                Console.WriteLine(" |                  ");
                Console.WriteLine("_|____              ");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Erros do jogador: " + Erros);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Palavra escolhida: " + String.Join("", letrasEncontradas));
                Console.WriteLine("----------------------------------------------");

                bool letraFoiEncontrada = false;
                Console.WriteLine("Digite uma letra: ");
                char chute = Console.ReadLine()!.ToUpper()[0];

                for (int contador = 0; contador < palavraEscolhida.Length; contador++)
                {
                    char letraAtual = palavraEscolhida[contador];
                    if (letraAtual == chute)
                    {
                        letrasEncontradas[contador] = letraAtual;
                        letraFoiEncontrada = true;
                    }

                }
                if (letraFoiEncontrada == false)
                {
                    Erros++;
                }
                string palavraEncontrada = string.Join("", letrasEncontradas);
                jogadorAcertou = palavraEncontrada == palavraEscolhida;
                jogadorEnforcou = Erros > 5;
                if (jogadorAcertou)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"Parabéns, Você ganhou o jogo !! Você Acertou a palavra {palavraEscolhida}");
                    Console.WriteLine("----------------------------------------------");
                } else if(jogadorEnforcou)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Que azar. Você não conseguiu acertar a palavra");
                    Console.WriteLine($"A palavra era {palavraEscolhida}");
                    Console.WriteLine("----------------------------------------------");
                }
                Console.ReadLine();

            } while (jogadorAcertou == false && jogadorEnforcou == false);
        }
    }
}
