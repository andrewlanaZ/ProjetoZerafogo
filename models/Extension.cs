namespace ZeraFogoApp.models;

static internal class ProdutoExtension
{
    static internal bool Search(this Produto produto, string pesquisa)
    {
        if (produto.tipo.Contains(pesquisa) || produto.fabricante.Contains(pesquisa))
        {
            return true;
        }

        return false;
    }
}
