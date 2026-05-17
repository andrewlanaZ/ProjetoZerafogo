namespace ZeraFogoApp;

partial class ExtintorCard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.picImagem    = new System.Windows.Forms.PictureBox();
        this.lblNome      = new System.Windows.Forms.Label();
        this.lblFabricante= new System.Windows.Forms.Label();
        this.pnlDivider   = new System.Windows.Forms.Panel();
        this.lblCapacidade= new System.Windows.Forms.Label();
        this.lblClasses   = new System.Windows.Forms.Label();
        this.lblDescricao = new System.Windows.Forms.Label();
        this.lblPreco     = new System.Windows.Forms.Label();
        this.btnComprar   = new System.Windows.Forms.Button();

        ((System.ComponentModel.ISupportInitialize)this.picImagem).BeginInit();
        this.SuspendLayout();

        // ── Tamanho do card ──────────────────────────────────────────
        // Largura fixa; altura cresce com o conteúdo se necessário
        this.Size        = new System.Drawing.Size(220, 370);
        this.BackColor   = System.Drawing.Color.White;
        this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Name        = "ExtintorCard";

        // ── picImagem ────────────────────────────────────────────────
        this.picImagem.Location  = new System.Drawing.Point(20, 12);
        this.picImagem.Size      = new System.Drawing.Size(178, 110);
        this.picImagem.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picImagem.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        this.picImagem.Name      = "picImagem";

        // ── lblNome ──────────────────────────────────────────────────
        this.lblNome.AutoSize  = false;
        this.lblNome.Size      = new System.Drawing.Size(198, 36);
        this.lblNome.Location  = new System.Drawing.Point(10, 130);
        this.lblNome.Font      = new System.Drawing.Font("Segoe UI", 9.5F,
            System.Drawing.FontStyle.Bold);
        this.lblNome.ForeColor = System.Drawing.Color.FromArgb(25, 25, 25);
        this.lblNome.Name      = "lblNome";

        // ── lblFabricante ────────────────────────────────────────────
        this.lblFabricante.AutoSize  = false;
        this.lblFabricante.Size      = new System.Drawing.Size(198, 18);
        this.lblFabricante.Location  = new System.Drawing.Point(10, 167);
        this.lblFabricante.Font      = new System.Drawing.Font("Segoe UI", 8F,
            System.Drawing.FontStyle.Italic);
        this.lblFabricante.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
        this.lblFabricante.Name      = "lblFabricante";

        // ── pnlDivider (linha fina separadora) ───────────────────────
        this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.pnlDivider.Location  = new System.Drawing.Point(10, 190);
        this.pnlDivider.Size      = new System.Drawing.Size(198, 1);
        this.pnlDivider.Name      = "pnlDivider";

        // ── lblCapacidade ────────────────────────────────────────────
        this.lblCapacidade.AutoSize  = false;
        this.lblCapacidade.Size      = new System.Drawing.Size(198, 18);
        this.lblCapacidade.Location  = new System.Drawing.Point(10, 198);
        this.lblCapacidade.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblCapacidade.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
        this.lblCapacidade.Name      = "lblCapacidade";

        // ── lblClasses ───────────────────────────────────────────────
        this.lblClasses.AutoSize  = false;
        this.lblClasses.Size      = new System.Drawing.Size(198, 18);
        this.lblClasses.Location  = new System.Drawing.Point(10, 218);
        this.lblClasses.Font      = new System.Drawing.Font("Segoe UI", 8.5F,
            System.Drawing.FontStyle.Bold);
        this.lblClasses.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
        this.lblClasses.Name      = "lblClasses";

        // ── lblDescricao ─────────────────────────────────────────────
        this.lblDescricao.AutoSize  = false;
        this.lblDescricao.Size      = new System.Drawing.Size(198, 52);
        this.lblDescricao.Location  = new System.Drawing.Point(10, 240);
        this.lblDescricao.Font      = new System.Drawing.Font("Segoe UI", 8F);
        this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
        this.lblDescricao.Name      = "lblDescricao";

        // ── lblPreco ─────────────────────────────────────────────────
        this.lblPreco.AutoSize  = true;
        this.lblPreco.Location  = new System.Drawing.Point(10, 298);
        this.lblPreco.Font      = new System.Drawing.Font("Segoe UI", 14F,
            System.Drawing.FontStyle.Bold);
        this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0);
        this.lblPreco.Name      = "lblPreco";

        // ── btnComprar ───────────────────────────────────────────────
        this.btnComprar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
        this.btnComprar.FlatAppearance.BorderSize = 0;
        this.btnComprar.BackColor                 = System.Drawing.Color.FromArgb(139, 0, 0);
        this.btnComprar.ForeColor                 = System.Drawing.Color.White;
        this.btnComprar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F,
            System.Drawing.FontStyle.Bold);
        this.btnComprar.Text                      = "Ver Mais";
        this.btnComprar.Size                      = new System.Drawing.Size(198, 30);
        this.btnComprar.Location                  = new System.Drawing.Point(10, 330);
        this.btnComprar.Cursor                    = System.Windows.Forms.Cursors.Hand;
        this.btnComprar.Name                      = "btnComprar";

        this.Controls.AddRange(new System.Windows.Forms.Control[]
        {
            this.picImagem,
            this.lblNome,
            this.lblFabricante,
            this.pnlDivider,
            this.lblCapacidade,
            this.lblClasses,
            this.lblDescricao,
            this.lblPreco,
            this.btnComprar
        });

        ((System.ComponentModel.ISupportInitialize)this.picImagem).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.PictureBox picImagem;
    private System.Windows.Forms.Label      lblNome;
    private System.Windows.Forms.Label      lblFabricante;
    private System.Windows.Forms.Panel      pnlDivider;
    private System.Windows.Forms.Label      lblCapacidade;
    private System.Windows.Forms.Label      lblClasses;
    private System.Windows.Forms.Label      lblDescricao;
    private System.Windows.Forms.Label      lblPreco;
    private System.Windows.Forms.Button     btnComprar;
}
