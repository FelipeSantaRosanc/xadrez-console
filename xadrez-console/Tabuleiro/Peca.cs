﻿

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }



        public Peca( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tabuleiro = tab;
            this.cor = cor;
            this.qtdeMovimentos = 0;
            
        }

        public void incrementarQuantidaddeMovimento()
        {
            qtdeMovimentos++;
        }



    }
}
