using System.Formats.Asn1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDaForca.ConsoleApp
{
    
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                string[] palavras = LogicaDoJogo.ArmazenamentoDePalavras();

                string palavraEscolhida = LogicaDoJogo.CriarPalavra(palavras);

                char[] letrasEncontradas = LogicaDoJogo.OcultarPalavra(palavraEscolhida);
                int erros = 0;
                bool jogadorEnforcou = false;
                bool jogadorGanhou = false;
                
                do
                {
                    MenuPrincipal(erros, letrasEncontradas);

                    erros = LogicaDoJogo.ErrouOuNao(palavraEscolhida, letrasEncontradas, erros);

                    string palavraEncontrada = LogicaDoJogo.PalavraFoiEncontrada(letrasEncontradas);

                    jogadorGanhou = LogicaDoJogo.JogadorGanhou(jogadorGanhou, palavraEncontrada, palavraEscolhida);

                    jogadorEnforcou = LogicaDoJogo.JogadorEnforcou(jogadorEnforcou, erros);

                    GanhouOuNao(jogadorGanhou, jogadorEnforcou, palavraEscolhida);

                } while (jogadorEnforcou == false && jogadorGanhou == false);

                 continuar = DesejaContinuar(continuar);
            }
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

        static bool DesejaContinuar(bool continuar )
        {
            
            Console.WriteLine("Deseja Continuar? (s/n)");
            string querContinuar = Console.ReadLine()!.ToUpper();
            if (querContinuar == "S")
            {
                continuar = true;  
            } else if (querContinuar == "N")
            {
                Console.WriteLine("Obrigado Pela Presença");
                Console.ReadLine();
                continuar = false;
            } else
            {
                Console.WriteLine("Comando Inválido, Retornando");
                DesejaContinuar(continuar);
            }
            return continuar;

        }
    }
}
