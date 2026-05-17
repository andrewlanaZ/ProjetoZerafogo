namespace ZeraFogoApp;

public class PaginaProdutos : Form
{
    private FlowLayoutPanel flowProdutos;

    public PaginaProdutos()
    {
        InicializarComponentes();
        CarregarProdutos(ObterExtintores());
    }

    private void InicializarComponentes()
    {
        this.Text = "Produtos - Extintores";
        this.Size = new System.Drawing.Size(1000, 700);
        this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

        flowProdutos = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = System.Drawing.Color.FromArgb(240, 240, 240),
            Padding = new Padding(16),
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = true,
        };

        this.Controls.Add(flowProdutos);
    }

    private void CarregarProdutos(List<Extintor> extintores)
    {
        flowProdutos.SuspendLayout();
        flowProdutos.Controls.Clear();

        foreach (var e in extintores)
        {
            var card = new ExtintorCard(e) { Margin = new Padding(8) };
            flowProdutos.Controls.Add(card);
        }

        flowProdutos.ResumeLayout();
    }

    private void InitializeComponent()
    {

    }

    // Dados de exemplo — substitua pela sua fonte de dados real
    private List<Extintor> ObterExtintores()
    {
        return new List<Extintor>
        {
            new Extintor
            {
                Nome       = "Extintor Pó Químico ABC",
                Fabricante = "Amerex",
                Capacidade = "6 kg",
                Preco      = 89.90m,
                Classes    = "A, B, C",
                Descricao  = "Ideal para incêndios em materiais sólidos, líquidos e gases inflamáveis e equipamentos elétricos."
            },
            new Extintor
            {
                Nome       = "Extintor CO₂",
                Fabricante = "Fireshield",
                Capacidade = "4 kg",
                Preco      = 219.90m,
                Classes    = "B, C",
                Descricao  = "Não deixa resíduo. Recomendado para ambientes com equipamentos eletrônicos e servidores."
            },
            new Extintor
            {
                Nome       = "Extintor Água Pressurizada",
                Fabricante = "Totalfire",
                Capacidade = "10 L",
                Preco      = 74.50m,
                Classes    = "A",
                Descricao  = "Indicado para incêndios em materiais sólidos de origem orgânica como madeira, papel e tecido."
            },
            new Extintor
            {
                Nome       = "Extintor Pó Químico BC",
                Fabricante = "Segurmax",
                Capacidade = "4 kg",
                Preco      = 69.00m,
                Classes    = "B, C",
                Descricao  = "Eficaz contra líquidos inflamáveis e equipamentos elétricos energizados."
            },
            new Extintor
            {
                Nome       = "Extintor Espuma Mecânica",
                Fabricante = "Amerex",
                Capacidade = "10 L",
                Preco      = 149.90m,
                Classes    = "A, B",
                Descricao  = "Excelente para incêndios em líquidos inflamáveis como gasolina, óleo e álcool."
            },
            new Extintor
            {
                Nome       = "Extintor Pó ABC Grande",
                Fabricante = "Fireshield",
                Capacidade = "12 kg",
                Preco      = 159.90m,
                Classes    = "A, B, C",
                Descricao  = "Versão de alta capacidade para ambientes industriais e grandes áreas de armazenamento."
            },
        };
    }
}
