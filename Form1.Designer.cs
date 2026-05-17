namespace ZeraFogoApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        lblZera = new Label();
        lblFogo = new Label();
        txtSearch = new TextBox();
        btnBuscar = new Button();
        btnCarrinho = new Button();
        pnlBody = new Panel();
        pnlContent = new Panel();
        flowLayoutPanel1 = new FlowLayoutPanel();
        pnlBanner = new Panel();
        lblSuper = new Label();
        lblPromocao = new Label();
        lblSub = new Label();
        pnlSidebar = new Panel();
        lblMenuTitulo = new Label();
        btnHome = new Button();
        btnProdutos = new Button();
        btnGerenciar = new Button();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlBanner.SuspendLayout();
        pnlSidebar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(0, 0, 128);
        pnlHeader.Controls.Add(lblZera);
        pnlHeader.Controls.Add(lblFogo);
        pnlHeader.Controls.Add(txtSearch);
        pnlHeader.Controls.Add(btnBuscar);
        pnlHeader.Controls.Add(btnCarrinho);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1144, 60);
        pnlHeader.TabIndex = 1;
        // 
        // lblZera
        // 
        lblZera.AutoSize = true;
        lblZera.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblZera.ForeColor = Color.White;
        lblZera.Location = new Point(16, 12);
        lblZera.Name = "lblZera";
        lblZera.Size = new Size(81, 37);
        lblZera.TabIndex = 0;
        lblZera.Text = "Zera ";
        // 
        // lblFogo
        // 
        lblFogo.AutoSize = true;
        lblFogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblFogo.ForeColor = Color.FromArgb(255, 140, 0);
        lblFogo.Location = new Point(94, 14);
        lblFogo.Name = "lblFogo";
        lblFogo.Size = new Size(82, 37);
        lblFogo.TabIndex = 1;
        lblFogo.Text = "Fogo";
        // 
        // txtSearch
        // 
        txtSearch.BackColor = Color.FromArgb(240, 240, 240);
        txtSearch.BorderStyle = BorderStyle.FixedSingle;
        txtSearch.Font = new Font("Segoe UI", 10F);
        txtSearch.Location = new Point(400, 16);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Buscar produtos....";
        txtSearch.Size = new Size(340, 25);
        txtSearch.TabIndex = 2;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // btnBuscar
        // 
        btnBuscar.BackColor = Color.FromArgb(210, 140, 0);
        btnBuscar.Cursor = Cursors.Hand;
        btnBuscar.FlatAppearance.BorderSize = 0;
        btnBuscar.FlatStyle = FlatStyle.Flat;
        btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnBuscar.ForeColor = Color.White;
        btnBuscar.Location = new Point(744, 16);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(80, 26);
        btnBuscar.TabIndex = 3;
        btnBuscar.Text = "BUSCAR";
        btnBuscar.UseVisualStyleBackColor = false;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // btnCarrinho
        // 
        btnCarrinho.BackColor = Color.White;
        btnCarrinho.Cursor = Cursors.Hand;
        btnCarrinho.FlatAppearance.BorderColor = Color.LightGray;
        btnCarrinho.FlatStyle = FlatStyle.Flat;
        btnCarrinho.Font = new Font("Segoe UI", 9F);
        btnCarrinho.ForeColor = Color.Black;
        btnCarrinho.Location = new Point(972, 14);
        btnCarrinho.Name = "btnCarrinho";
        btnCarrinho.Size = new Size(90, 30);
        btnCarrinho.TabIndex = 4;
        btnCarrinho.Text = "Carrinho";
        btnCarrinho.UseVisualStyleBackColor = false;
        btnCarrinho.Click += btnCarrinho_Click;
        // 
        // pnlBody
        // 
        pnlBody.BackColor = Color.White;
        pnlBody.Controls.Add(pnlContent);
        pnlBody.Controls.Add(pnlSidebar);
        pnlBody.Dock = DockStyle.Fill;
        pnlBody.Location = new Point(0, 60);
        pnlBody.Name = "pnlBody";
        pnlBody.Size = new Size(1144, 621);
        pnlBody.TabIndex = 0;
        // 
        // pnlContent
        // 
        pnlContent.AutoScroll = true;
        pnlContent.BackColor = Color.White;
        pnlContent.Controls.Add(flowLayoutPanel1);
        pnlContent.Controls.Add(pnlBanner);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(220, 0);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new Size(924, 621);
        pnlContent.TabIndex = 0;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.BackColor = Color.FromArgb(240, 240, 240);
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.Location = new Point(0, 155);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Padding = new Padding(8, 24, 8, 32);
        flowLayoutPanel1.Size = new Size(924, 466);
        flowLayoutPanel1.TabIndex = 2;
        // 
        // pnlBanner
        // 
        pnlBanner.BackColor = Color.FromArgb(139, 0, 0);
        pnlBanner.Controls.Add(lblSuper);
        pnlBanner.Controls.Add(lblPromocao);
        pnlBanner.Controls.Add(lblSub);
        pnlBanner.Dock = DockStyle.Top;
        pnlBanner.Location = new Point(0, 0);
        pnlBanner.Name = "pnlBanner";
        pnlBanner.Size = new Size(924, 155);
        pnlBanner.TabIndex = 1;
        // 
        // lblSuper
        // 
        lblSuper.AutoSize = true;
        lblSuper.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
        lblSuper.ForeColor = Color.White;
        lblSuper.Location = new Point(40, 18);
        lblSuper.Name = "lblSuper";
        lblSuper.Size = new Size(87, 32);
        lblSuper.TabIndex = 0;
        lblSuper.Text = "SUPER";
        // 
        // lblPromocao
        // 
        lblPromocao.AutoSize = true;
        lblPromocao.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic);
        lblPromocao.ForeColor = Color.FromArgb(255, 140, 0);
        lblPromocao.Location = new Point(40, 50);
        lblPromocao.Name = "lblPromocao";
        lblPromocao.Size = new Size(191, 41);
        lblPromocao.TabIndex = 1;
        lblPromocao.Text = "PROMOÇÃO";
        // 
        // lblSub
        // 
        lblSub.AutoSize = true;
        lblSub.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
        lblSub.ForeColor = Color.White;
        lblSub.Location = new Point(55, 100);
        lblSub.Name = "lblSub";
        lblSub.Size = new Size(227, 38);
        lblSub.TabIndex = 2;
        lblSub.Text = "EQUIPAMENTOS DE SEGURANÇA\r\nCOM OS MELHORES PREÇOS!";
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(30, 30, 40);
        pnlSidebar.Controls.Add(lblMenuTitulo);
        pnlSidebar.Controls.Add(btnHome);
        pnlSidebar.Controls.Add(btnProdutos);
        pnlSidebar.Controls.Add(btnGerenciar);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(220, 621);
        pnlSidebar.TabIndex = 1;
        // 
        // lblMenuTitulo
        // 
        lblMenuTitulo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblMenuTitulo.ForeColor = Color.FromArgb(140, 140, 160);
        lblMenuTitulo.Location = new Point(0, 0);
        lblMenuTitulo.Name = "lblMenuTitulo";
        lblMenuTitulo.Size = new Size(220, 40);
        lblMenuTitulo.TabIndex = 0;
        lblMenuTitulo.Text = "  NAVEGAÇÃO";
        lblMenuTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnHome
        // 
        btnHome.BackColor = Color.Transparent;
        btnHome.Cursor = Cursors.Hand;
        btnHome.FlatAppearance.BorderSize = 0;
        btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 70);
        btnHome.FlatStyle = FlatStyle.Flat;
        btnHome.Font = new Font("Segoe UI", 10F);
        btnHome.ForeColor = Color.FromArgb(210, 210, 220);
        btnHome.Location = new Point(0, 70);
        btnHome.Name = "btnHome";
        btnHome.Padding = new Padding(16, 0, 0, 0);
        btnHome.Size = new Size(220, 46);
        btnHome.TabIndex = 2;
        btnHome.Text = "🏠  Início";
        btnHome.TextAlign = ContentAlignment.MiddleLeft;
        btnHome.UseVisualStyleBackColor = false;
        btnHome.Click += btnHome_Click;
        // 
        // btnProdutos
        // 
        btnProdutos.BackColor = Color.Transparent;
        btnProdutos.Cursor = Cursors.Hand;
        btnProdutos.FlatAppearance.BorderSize = 0;
        btnProdutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 70);
        btnProdutos.FlatStyle = FlatStyle.Flat;
        btnProdutos.Font = new Font("Segoe UI", 10F);
        btnProdutos.ForeColor = Color.FromArgb(210, 210, 220);
        btnProdutos.Location = new Point(0, 116);
        btnProdutos.Name = "btnProdutos";
        btnProdutos.Padding = new Padding(16, 0, 0, 0);
        btnProdutos.Size = new Size(220, 46);
        btnProdutos.TabIndex = 3;
        btnProdutos.Text = "\U0001f9ef  Produtos";
        btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
        btnProdutos.UseVisualStyleBackColor = false;
        btnProdutos.Click += btnProdutos_Click;
        // 
        // btnGerenciar
        // 
        btnGerenciar.BackColor = Color.Transparent;
        btnGerenciar.Cursor = Cursors.Hand;
        btnGerenciar.FlatAppearance.BorderSize = 0;
        btnGerenciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 70);
        btnGerenciar.FlatStyle = FlatStyle.Flat;
        btnGerenciar.Font = new Font("Segoe UI", 10F);
        btnGerenciar.ForeColor = Color.FromArgb(210, 210, 220);
        btnGerenciar.Location = new Point(0, 162);
        btnGerenciar.Name = "btnGerenciar";
        btnGerenciar.Padding = new Padding(16, 0, 0, 0);
        btnGerenciar.Size = new Size(220, 46);
        btnGerenciar.TabIndex = 4;
        btnGerenciar.Text = "📋  Gerenciar";
        btnGerenciar.TextAlign = ContentAlignment.MiddleLeft;
        btnGerenciar.UseVisualStyleBackColor = false;
        btnGerenciar.Click += btnGerenciar_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1144, 681);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(800, 550);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ZeraFogo";
        Resize += Form1_Resize;
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        pnlContent.ResumeLayout(false);
        pnlBanner.ResumeLayout(false);
        pnlBanner.PerformLayout();
        pnlSidebar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblZera;
    private System.Windows.Forms.Label lblFogo;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Button btnCarrinho;
    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.Label lblMenuTitulo;
    private System.Windows.Forms.Button btnHome;
    private System.Windows.Forms.Button btnProdutos;
    private System.Windows.Forms.Button btnGerenciar;
    private Panel pnlContent;
    private Panel pnlBanner;
    private Label lblSuper;
    private Label lblPromocao;
    private Label lblSub;
    private FlowLayoutPanel flowLayoutPanel1;
}