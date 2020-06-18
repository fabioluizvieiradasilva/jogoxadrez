using Tabuleiro;

namespace Xadrez
{
    class Rei:Peca
    {
        public Rei (Table tab, Cor cor): base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
