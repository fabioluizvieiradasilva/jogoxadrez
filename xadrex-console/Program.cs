using System;
using Tabuleiro;
using Xadrez;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Table tab = new Table(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TableException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
