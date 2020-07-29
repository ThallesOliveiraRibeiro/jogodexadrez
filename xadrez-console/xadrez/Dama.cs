using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Dama : Peca
    {
        public Dama(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "D";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;

        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            // acima
            pos = new Posicao(posicao.linha - 1, posicao.coluna);

            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    break;
                pos.linha -= 1;

            }
            // abaixo
            pos = new Posicao(posicao.linha + 1, posicao.coluna);

            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    break;
                pos.linha += 1;

            }
            // direita
            pos = new Posicao(posicao.linha, posicao.coluna + 1);

            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    break;
                pos.coluna += 1;

            }
            // esquerda
            pos = new Posicao(posicao.linha, posicao.coluna - 1);

            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    break;
                pos.coluna -= 1;

            }
            // NO
            pos = new Posicao(posicao.linha - 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    break;
                pos = new Posicao(posicao.linha - 1, pos.coluna - 1);
            }

            // NE
            pos = new Posicao(posicao.linha - 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    break;
                pos = new Posicao(posicao.linha - 1, pos.coluna + 1);
            }

            // SE
            pos = new Posicao(posicao.linha + 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    break;
                pos = new Posicao(posicao.linha + 1, pos.coluna + 1);
            }

            // SO
            pos = new Posicao(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    break;
                pos = new Posicao(posicao.linha + 1, pos.coluna - 1);
            }
            return mat;
        }
    }
}
