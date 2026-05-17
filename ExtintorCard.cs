using System.Drawing;
using System.Windows.Forms;

namespace ZeraFogoApp;

public partial class ExtintorCard : UserControl
{
    public ExtintorCard(Extintor extintor)
    {
        InitializeComponent();
        Preencher(extintor);
    }

    private void Preencher(Extintor e)
    {
        lblNome.Text       = e.Nome;
        lblFabricante.Text = e.Fabricante;
        lblCapacidade.Text = $"⚖ {e.Capacidade}";
        lblPreco.Text      = e.Preco.ToString("C2");
        lblClasses.Text    = $"Classes: {e.Classes}";
        lblDescricao.Text  = e.Descricao;

        if (e.Imagem != null)
            picImagem.Image = e.Imagem;
    }
}
