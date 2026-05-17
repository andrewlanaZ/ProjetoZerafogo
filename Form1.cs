using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ZeraFogoApp;

public partial class Form1 : Form
{
    private List<Extintor> _todosExtintores;
    private Label lblContagem;

    public Form1()
    {
        InitializeComponent();
        AjustarLayout();
        CriarLabelContagem();
        _todosExtintores = ObterExtintores();
        AplicarFiltro("");
    }

    // ── Label de contagem ────────────────────────────────────────────
    private Panel pnlContagem;

    private void CriarLabelContagem()
    {
        // Bolinha amarela desenhada via Paint
        var bolinha = new Panel
        {
            Size = new Size(10, 10),
            Location = new Point(0, 5),
            BackColor = Color.Transparent
        };
        bolinha.Paint += (s, e) =>
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(Brushes.Gold, 0, 0, 9, 9);
        };

        lblContagem = new Label
        {
            AutoSize = true,
            Font = new Font("Segoe UI Semibold", 11F),
            ForeColor = Color.FromArgb(50, 50, 50),
            BackColor = Color.FromArgb(245, 245, 245),
            Location = new Point(18, 0),
        };

        pnlContagem = new Panel
        {
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Height = 28,
            BackColor = Color.FromArgb(245, 245, 245),
        };
        pnlContagem.Controls.Add(bolinha);
        pnlContagem.Controls.Add(lblContagem);

        pnlContent.Controls.Add(pnlContagem);
        pnlContagem.BringToFront();
        AtualizarPosicaoContagem();
    }

    private void AtualizarPosicaoContagem()
    {
        pnlContagem.Location = new Point(12, pnlBanner.Height + 10);
        pnlContagem.Width = pnlContent.Width - 24;
    }

    // ── Filtro ───────────────────────────────────────────────────────
    private void AplicarFiltro(string termo)
    {
        termo = termo.Trim().ToLowerInvariant();

        var filtrados = string.IsNullOrEmpty(termo)
            ? _todosExtintores
            : _todosExtintores.Where(e =>
                (e.Nome ?? "").ToLower().Contains(termo) ||
                (e.Fabricante ?? "").ToLower().Contains(termo) ||
                (e.Capacidade ?? "").ToLower().Contains(termo) ||
                (e.Classes ?? "").ToLower().Contains(termo) ||
                (e.Descricao ?? "").ToLower().Contains(termo)
            ).ToList();

        CarregarProdutos(filtrados);
        AtualizarContagem(filtrados.Count);
    }

    private void AtualizarContagem(int count)
    {
        lblContagem.Text = count == 1
            ? "1 produto encontrado"
            : $"{count} produtos encontrados";
    }

    // ── Renderização dos cards ───────────────────────────────────────
    private void CarregarProdutos(List<Extintor> extintores)
    {
        flowLayoutPanel1.SuspendLayout();
        flowLayoutPanel1.Controls.Clear();

        foreach (var e in extintores)
        {
            var card = new ExtintorCard(e) { Margin = new Padding(8) };
            flowLayoutPanel1.Controls.Add(card);
        }

        flowLayoutPanel1.ResumeLayout();
    }

    // ── Dados de exemplo ─────────────────────────────────────────────
    private List<Extintor> ObterExtintores()
    {
        return new List<Extintor>
        {
            new Extintor { Nome = "Extintor Pó Químico ABC",    Fabricante = "Amerex",     Capacidade = "6 kg",  Preco = 89.90m,  Classes = "A, B, C", Descricao = "Ideal para incêndios em materiais sólidos, líquidos e gases inflamáveis e equipamentos elétricos." },
            new Extintor { Nome = "Extintor CO₂",               Fabricante = "Fireshield", Capacidade = "4 kg",  Preco = 219.90m, Classes = "B, C",    Descricao = "Não deixa resíduo. Recomendado para ambientes com equipamentos eletrônicos e servidores." },
            new Extintor { Nome = "Extintor Água Pressurizada", Fabricante = "Totalfire",  Capacidade = "10 L",  Preco = 74.50m,  Classes = "A",       Descricao = "Indicado para incêndios em materiais sólidos de origem orgânica como madeira, papel e tecido." },
            new Extintor { Nome = "Extintor Pó Químico BC",     Fabricante = "Segurmax",   Capacidade = "4 kg",  Preco = 69.00m,  Classes = "B, C",    Descricao = "Eficaz contra líquidos inflamáveis e equipamentos elétricos energizados." },
            new Extintor { Nome = "Extintor Espuma Mecânica",   Fabricante = "Amerex",     Capacidade = "10 L",  Preco = 149.90m, Classes = "A, B",    Descricao = "Excelente para incêndios em líquidos inflamáveis como gasolina, óleo e álcool." },
            new Extintor { Nome = "Extintor Pó ABC Grande",     Fabricante = "Fireshield", Capacidade = "12 kg", Preco = 159.90m, Classes = "A, B, C", Descricao = "Versão de alta capacidade para ambientes industriais e grandes áreas de armazenamento." },
        };
    }

    // ── Eventos ──────────────────────────────────────────────────────
    private void Form1_Resize(object sender, EventArgs e)
    {
        AjustarLayout();
        AtualizarPosicaoContagem();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        AplicarFiltro(txtSearch.Text);
    }

    // Filtra em tempo real enquanto digita
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        AplicarFiltro(txtSearch.Text);
    }

    private void btnCarrinho_Click(object sender, EventArgs e)
    {
        // TODO: abrir carrinho
    }

    private void AjustarLayout()
    {
        int cx = pnlHeader.Width / 2;
        txtSearch.Location = new Point(cx - txtSearch.Width / 2, 16);
        btnBuscar.Location = new Point(txtSearch.Right + 4, 16);
        btnCarrinho.Location = new Point(
            pnlHeader.Width - btnCarrinho.Width - 24,
            (pnlHeader.Height - btnCarrinho.Height) / 2);
    }

    private void btnHome_Click(object sender, EventArgs e)
    {
        // TODO: navegar para home
    }

    private void btnProdutos_Click(object sender, EventArgs e)
    {
        // TODO: navegar para listagem de produtos
    }

    private void btnGerenciar_Click(object sender, EventArgs e)
    {
        // TODO: navegar para gerenciamento (Ana)
    }

    private void btnCarrinhoPag_Click(object sender, EventArgs e)
    {
        // TODO: navegar para carrinho
    }

    private void btnDetalhe_Click(object sender, EventArgs e)
    {
        // TODO: navegar para detalhe do produto (João)
    }
}