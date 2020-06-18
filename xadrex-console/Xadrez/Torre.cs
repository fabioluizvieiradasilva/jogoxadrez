using Tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Table tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}

