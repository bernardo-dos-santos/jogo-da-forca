namespace JogoDaForca.ConsoleApp
{
    public class LogicaDoJogo
    {
        public static string[] ArmazenamentoDePalavras()
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
        public static int ErrouOuNao(string palavraEscolhida, char[] letrasEncontradas, int erros)
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
        public static string CriarPalavra(string[] palavras)
        {
            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);
            string palavraEscolhida = palavras[indiceEscolhido];
            return palavraEscolhida;
        }
        public static char[] OcultarPalavra(string palavraEscolhida)
        {
            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caracter = 0; caracter < palavraEscolhida.Length; caracter++)
            {
                letrasEncontradas[caracter] = '_';
            }
            return letrasEncontradas;
        }
        public static string PalavraFoiEncontrada(char[] letrasEncontradas)
        {
            string palavraEncontrada = string.Join("", letrasEncontradas);
            return palavraEncontrada;
        }
        public static bool JogadorGanhou(bool jogadorGanhou, string palavraEncontrada, string palavraEscolhida)
        {
            jogadorGanhou = palavraEncontrada == palavraEscolhida;
            return jogadorGanhou;
        }
        public static bool JogadorEnforcou(bool jogadorEnforcou, int erros)
        {
            jogadorEnforcou = erros > 5;
            return jogadorEnforcou;
        }
    }
}
