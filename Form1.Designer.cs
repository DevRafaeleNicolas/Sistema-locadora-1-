
namespace Sistema_locadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaFilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroUsuárioToolStripMenuItem,
            this.cadastroFilmesToolStripMenuItem,
            this.cadastroCategoriaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroUsuárioToolStripMenuItem
            // 
            this.cadastroUsuárioToolStripMenuItem.Name = "cadastroUsuárioToolStripMenuItem";
            this.cadastroUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroUsuárioToolStripMenuItem.Text = "Cadastro Usuário";
            this.cadastroUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroUsuárioToolStripMenuItem_Click);
            // 
            // cadastroFilmesToolStripMenuItem
            // 
            this.cadastroFilmesToolStripMenuItem.Name = "cadastroFilmesToolStripMenuItem";
            this.cadastroFilmesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroFilmesToolStripMenuItem.Text = "Cadastro Filmes";
            // 
            // cadastroCategoriaToolStripMenuItem
            // 
            this.cadastroCategoriaToolStripMenuItem.Name = "cadastroCategoriaToolStripMenuItem";
            this.cadastroCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroCategoriaToolStripMenuItem.Text = "Cadastro Categoria";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaUsuárioToolStripMenuItem,
            this.consultaFilmesToolStripMenuItem,
            this.consultaCategoriaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultaUsuárioToolStripMenuItem
            // 
            this.consultaUsuárioToolStripMenuItem.Name = "consultaUsuárioToolStripMenuItem";
            this.consultaUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaUsuárioToolStripMenuItem.Text = "Consulta Usuário";
            // 
            // consultaFilmesToolStripMenuItem
            // 
            this.consultaFilmesToolStripMenuItem.Name = "consultaFilmesToolStripMenuItem";
            this.consultaFilmesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaFilmesToolStripMenuItem.Text = "Consulta Filmes";
            // 
            // consultaCategoriaToolStripMenuItem
            // 
            this.consultaCategoriaToolStripMenuItem.Name = "consultaCategoriaToolStripMenuItem";
            this.consultaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaCategoriaToolStripMenuItem.Text = "Consulta Categoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFilmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCategoriaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaFilmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCategoriaToolStripMenuItem;
    }
}

