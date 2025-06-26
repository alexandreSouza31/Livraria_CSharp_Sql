namespace Livraria
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuLateral = new Panel();
            btnCaixa = new Button();
            btnPedido = new Button();
            btnAutor = new Button();
            btnEditora = new Button();
            btnCategoria = new Button();
            btnLivro = new Button();
            btnTelefone = new Button();
            btnCliente = new Button();
            btnFuncionario = new Button();
            containerLogo = new Panel();
            titulo = new Label();
            logo = new PictureBox();
            btnFechar = new Button();
            menuLateral.SuspendLayout();
            containerLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // menuLateral
            // 
            menuLateral.BackColor = SystemColors.GradientActiveCaption;
            menuLateral.Controls.Add(btnFechar);
            menuLateral.Controls.Add(btnCaixa);
            menuLateral.Controls.Add(btnPedido);
            menuLateral.Controls.Add(btnAutor);
            menuLateral.Controls.Add(btnEditora);
            menuLateral.Controls.Add(btnCategoria);
            menuLateral.Controls.Add(btnLivro);
            menuLateral.Controls.Add(btnTelefone);
            menuLateral.Controls.Add(btnCliente);
            menuLateral.Controls.Add(btnFuncionario);
            menuLateral.Controls.Add(containerLogo);
            menuLateral.Dock = DockStyle.Left;
            menuLateral.Location = new Point(0, 0);
            menuLateral.Name = "menuLateral";
            menuLateral.Size = new Size(220, 654);
            menuLateral.TabIndex = 0;
            menuLateral.Paint += menuLateral_Paint;
            // 
            // btnCaixa
            // 
            btnCaixa.Dock = DockStyle.Top;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCaixa.Location = new Point(0, 514);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(220, 40);
            btnCaixa.TabIndex = 11;
            btnCaixa.Text = "Caixa";
            btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            btnPedido.Dock = DockStyle.Top;
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPedido.Location = new Point(0, 474);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(220, 40);
            btnPedido.TabIndex = 10;
            btnPedido.Text = "Pedido";
            btnPedido.UseVisualStyleBackColor = true;
            // 
            // btnAutor
            // 
            btnAutor.Dock = DockStyle.Top;
            btnAutor.FlatAppearance.BorderSize = 0;
            btnAutor.FlatStyle = FlatStyle.Flat;
            btnAutor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAutor.Location = new Point(0, 434);
            btnAutor.Name = "btnAutor";
            btnAutor.Size = new Size(220, 40);
            btnAutor.TabIndex = 9;
            btnAutor.Text = "Autor";
            btnAutor.UseVisualStyleBackColor = true;
            // 
            // btnEditora
            // 
            btnEditora.Dock = DockStyle.Top;
            btnEditora.FlatAppearance.BorderSize = 0;
            btnEditora.FlatStyle = FlatStyle.Flat;
            btnEditora.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditora.Location = new Point(0, 394);
            btnEditora.Name = "btnEditora";
            btnEditora.Size = new Size(220, 40);
            btnEditora.TabIndex = 8;
            btnEditora.Text = "Editora";
            btnEditora.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            btnCategoria.Dock = DockStyle.Top;
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCategoria.Location = new Point(0, 354);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(220, 40);
            btnCategoria.TabIndex = 7;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnLivro
            // 
            btnLivro.Dock = DockStyle.Top;
            btnLivro.FlatAppearance.BorderSize = 0;
            btnLivro.FlatStyle = FlatStyle.Flat;
            btnLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLivro.Location = new Point(0, 314);
            btnLivro.Name = "btnLivro";
            btnLivro.Size = new Size(220, 40);
            btnLivro.TabIndex = 6;
            btnLivro.Text = "Livro";
            btnLivro.UseVisualStyleBackColor = true;
            // 
            // btnTelefone
            // 
            btnTelefone.Dock = DockStyle.Top;
            btnTelefone.FlatAppearance.BorderSize = 0;
            btnTelefone.FlatStyle = FlatStyle.Flat;
            btnTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTelefone.Location = new Point(0, 274);
            btnTelefone.Name = "btnTelefone";
            btnTelefone.Size = new Size(220, 40);
            btnTelefone.TabIndex = 5;
            btnTelefone.Text = "Telefone";
            btnTelefone.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCliente.Location = new Point(0, 234);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(220, 40);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            btnFuncionario.Dock = DockStyle.Top;
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFuncionario.Location = new Point(0, 194);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(220, 40);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "Funcionário";
            btnFuncionario.UseVisualStyleBackColor = true;
            // 
            // containerLogo
            // 
            containerLogo.Controls.Add(titulo);
            containerLogo.Controls.Add(logo);
            containerLogo.Dock = DockStyle.Top;
            containerLogo.Location = new Point(0, 0);
            containerLogo.Name = "containerLogo";
            containerLogo.Size = new Size(220, 194);
            containerLogo.TabIndex = 2;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe Print", 17F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titulo.Location = new Point(12, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(191, 40);
            titulo.TabIndex = 1;
            titulo.Text = "Livraria Online";
            titulo.Click += titulo_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.icone_livros;
            logo.Location = new Point(22, 41);
            logo.Name = "logo";
            logo.Size = new Size(172, 115);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Click += pictureBox1_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.GradientActiveCaption;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnFechar.ForeColor = Color.Black;
            btnFechar.Location = new Point(43, 599);
            btnFechar.Margin = new Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(133, 51);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 654);
            Controls.Add(menuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            menuLateral.ResumeLayout(false);
            containerLogo.ResumeLayout(false);
            containerLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuLateral;
        private PictureBox logo;
        private Label titulo;
        private Button btnFuncionario;
        private Panel containerLogo;
        private Button btnCaixa;
        private Button btnPedido;
        private Button btnAutor;
        private Button btnEditora;
        private Button btnCategoria;
        private Button btnLivro;
        private Button btnTelefone;
        private Button btnCliente;
        private Button btnFechar;
    }
}