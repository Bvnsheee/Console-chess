using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            ConsoleColor color = Console.ForegroundColor;
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(8 - i + " ");
                Console.ForegroundColor = color;

                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" - ");
                        Console.ForegroundColor = color;
                    }
                    else
                    {
                        Console.Write(" ");
                        Tela.imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   a  b  c  d  e  f  g  h");
            Console.ForegroundColor = color;
        }


        public static void imprimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branca)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
