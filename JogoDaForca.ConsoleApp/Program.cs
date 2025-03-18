using System.Formats.Asn1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] palavras = ArmazenamentoDePalavras();

            string palavraEscolhida = CriarPalavra(palavras);

            char[] letrasEncontradas = OcultarPalavra(palavraEscolhida);
            int erros = 0;
            bool jogadorEnforcou = false;
            bool jogadorGanhou = false;
            bool continuar = false;
            do
            {
                MenuPrincipal(erros, letrasEncontradas);
                erros = ErrouOuNao(palavraEscolhida, letrasEncontradas, erros);

                string palavraEncontrada = PalavraFoiEncontrada(letrasEncontradas);
                jogadorGanhou = JogadorGanhou(jogadorGanhou, palavraEncontrada, palavraEscolhida);
                jogadorEnforcou = JogadorEnforcou(jogadorEnforcou, erros);
                GanhouOuNao(jogadorGanhou, jogadorEnforcou, palavraEscolhida);
                //if (jogadorGanhou == true || jogadorEnforcou == true)
                //continuar = DesejaContinuar(continuar);

            } while (jogadorEnforcou == false && jogadorGanhou == false);
        }

        
        
        
        
        
        
        static string[] ArmazenamentoDePalavras()
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
            return palavras;
        }
        static string CriarPalavra(string[] palavras)
        {
            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);
            string palavraEscolhida = palavras[indiceEscolhido];
            return palavraEscolhida;
        }

        static char[] OcultarPalavra(string palavraEscolhida)
        {
            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caracter = 0; caracter < palavraEscolhida.Length; caracter++)
            {
                letrasEncontradas[caracter] = '_';
            }
            return letrasEncontradas;
        }

        static void MenuPrincipal(int erros, char[] letrasEncontradas)
        {
            string cabecaDoBoneco = erros >= 1 ? " o " : " ";
            string bracoEsquerdo = erros >= 3 ? "/" : " ";
            string bracoDireito = erros >= 4 ? "\\" : " ";
            string troncoCima = erros >= 2 ? "x" : " ";
            string troncoBaixo = erros >= 2 ? " x " : " ";
            string pernas = erros >= 5 ? "/ \\" : " ";

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
            Console.WriteLine("Erros do jogador: " + erros);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Palavra escolhida: " + System.String.Join("", letrasEncontradas));
            Console.WriteLine("----------------------------------------------");
        }

        static int ErrouOuNao(string palavraEscolhida, char[] letrasEncontradas, int erros)
        {
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
                erros++;
            }
            return erros;
        }
        static void GanhouOuNao(bool jogadorGanhou, bool jogadorEnforcou, string palavraEscolhida)
        {
            if (jogadorGanhou)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Parabéns, Você ganhou o jogo !! Você Acertou a palavra {palavraEscolhida}");
                Console.WriteLine("----------------------------------------------");
            }
            else if (jogadorEnforcou)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Que azar. Você não conseguiu acertar a palavra");
                Console.WriteLine($"A palavra era {palavraEscolhida}");
                Console.WriteLine("----------------------------------------------");
            }
            Console.ReadLine();
        }

        static string PalavraFoiEncontrada(char[] letrasEncontradas)
        {
            string palavraEncontrada = string.Join("", letrasEncontradas);
            return palavraEncontrada;
        }

        static bool JogadorGanhou(bool jogadorGanhou, string palavraEncontrada, string palavraEscolhida)
        {
            jogadorGanhou = palavraEncontrada == palavraEscolhida;
            return jogadorGanhou;
        }
        static bool JogadorEnforcou(bool jogadorEnforcou, int erros)
        {
            jogadorEnforcou = erros > 5;
            return jogadorEnforcou;
        }
        /*static bool DesejaContinuar(bool continuar )
        {
            Console.WriteLine("Deseja Continuar? (s/n)");
            string querContinuar = Console.ReadLine()!.ToUpper();
            if (querContinuar == "S")
            {
                continuar = false;  
            } else if (querContinuar == "N")
            {
                Console.WriteLine("Obrigado Pela Presença");
                continuar = true;
            } else
            {
                Console.WriteLine("Comando Inválido, Retornando");
                DesejaContinuar(continuar);
            }
            return continuar;

        }*/
    }
}
