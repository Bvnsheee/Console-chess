
namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab{ get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            this.QteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }
    }
}
