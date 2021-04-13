using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                PosicaoXadrez pos = new PosicaoXadrez('a', 1);

                Console.WriteLine(pos.toPosicao());

                Tela.ImprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message) ;
            }

        }
    }
}
