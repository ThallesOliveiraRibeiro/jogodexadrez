using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tabuleiro tab1 = new Tabuleiro(10, 10);

           tab.ColocarPeca( new Torre(Cor.Branca,tab), new Posicao(0, 0));
           tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 1));
            tab1.ColocarPeca(new Torre(Cor.Branca, tab1), new Posicao(1, 5));

            Tela.ImprimirTabuleiro(tab);
            Console.WriteLine();
            Tela.ImprimirTabuleiro(tab1);
        }
    }
}
