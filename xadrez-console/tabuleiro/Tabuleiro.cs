using System;
using System.Collections.Generic;
using System.Text;


namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        public bool existePeca(Posicao pos)              // CONFERE SE EXISTE UMA PEÇA EM DETERMINADA POSIÇAO
        {
            validarPosicao(pos);
            return peca(pos) != null;
            
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {   if (existePeca(pos))                        // MESMO QUE ESCREVER if(existepeca(pos) == true)
            {
                throw new TabuleiroException("Já existe uma peça nessa posiçao!");
            }
            
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos)            // CONFERE SE A POSIÇAO É VALIDA
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
                return true;
        }

        public void validarPosicao(Posicao pos)            // LANÇA UMA EXCEÇÃO CASO A POSIÇAO SEJA INVALIDA(FORA DO TABULEIRO)
        {
            if(posicaoValida(pos) == false)
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
