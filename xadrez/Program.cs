using tabuleiro;
using xadrez;
using camadaXadrez;

try
{
    /*Tabuleiro tab = new Tabuleiro(8, 8);

    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 3));
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 2));

    Tela.imprimirTabuleiro(tab);*/

    PosicaoXadrez pos = new PosicaoXadrez('a', 1);
    Console.WriteLine(pos);
    Console.WriteLine(pos.toPosicao());
}
catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
