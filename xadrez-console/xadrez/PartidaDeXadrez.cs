using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;


namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
            terminada = false;
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.ColocarPeca(p, destino);

        }
        private void colocarPecas()
        {

            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('c', 1).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('d', 1).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('e', 1).toPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('f', 1).toPosicao());
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('c', 8).toPosicao());
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('d', 8).toPosicao());
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('e', 8).toPosicao());
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('f', 8).toPosicao());
            

        }

    }
}
