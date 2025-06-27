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
            btnSair = new Button();
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
            pictureBox1 = new PictureBox();
            funcionario1 = new Funcionario();
            menuLateral.SuspendLayout();
            containerLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuLateral
            // 
            menuLateral.BackColor = SystemColors.GradientActiveCaption;
            menuLateral.Controls.Add(btnSair);
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
            menuLateral.Size = new Size(220, 595);
            menuLateral.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.GradientActiveCaption;
            btnSair.Cursor = Cursors.Hand;
            btnSair.Dock = DockStyle.Top;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Location = new Point(0, 524);
            btnSair.Margin = new Padding(0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(220, 40);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.Cursor = Cursors.Hand;
            btnCaixa.Dock = DockStyle.Top;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCaixa.ForeColor = SystemColors.Highlight;
            btnCaixa.Location = new Point(0, 484);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(220, 40);
            btnCaixa.TabIndex = 11;
            btnCaixa.Text = "Caixa";
            btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            btnPedido.Cursor = Cursors.Hand;
            btnPedido.Dock = DockStyle.Top;
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPedido.ForeColor = SystemColors.Highlight;
            btnPedido.Location = new Point(0, 444);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(220, 40);
            btnPedido.TabIndex = 10;
            btnPedido.Text = "Pedido";
            btnPedido.UseVisualStyleBackColor = true;
            // 
            // btnAutor
            // 
            btnAutor.Cursor = Cursors.Hand;
            btnAutor.Dock = DockStyle.Top;
            btnAutor.FlatAppearance.BorderSize = 0;
            btnAutor.FlatStyle = FlatStyle.Flat;
            btnAutor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAutor.ForeColor = SystemColors.Highlight;
            btnAutor.Location = new Point(0, 404);
            btnAutor.Name = "btnAutor";
            btnAutor.Size = new Size(220, 40);
            btnAutor.TabIndex = 9;
            btnAutor.Text = "Autor";
            btnAutor.UseVisualStyleBackColor = true;
            // 
            // btnEditora
            // 
            btnEditora.Cursor = Cursors.Hand;
            btnEditora.Dock = DockStyle.Top;
            btnEditora.FlatAppearance.BorderSize = 0;
            btnEditora.FlatStyle = FlatStyle.Flat;
            btnEditora.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditora.ForeColor = SystemColors.Highlight;
            btnEditora.Location = new Point(0, 364);
            btnEditora.Name = "btnEditora";
            btnEditora.Size = new Size(220, 40);
            btnEditora.TabIndex = 8;
            btnEditora.Text = "Editora";
            btnEditora.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.Dock = DockStyle.Top;
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCategoria.ForeColor = SystemColors.Highlight;
            btnCategoria.Location = new Point(0, 324);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(220, 40);
            btnCategoria.TabIndex = 7;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnLivro
            // 
            btnLivro.Cursor = Cursors.Hand;
            btnLivro.Dock = DockStyle.Top;
            btnLivro.FlatAppearance.BorderSize = 0;
            btnLivro.FlatStyle = FlatStyle.Flat;
            btnLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLivro.ForeColor = SystemColors.Highlight;
            btnLivro.Location = new Point(0, 284);
            btnLivro.Name = "btnLivro";
            btnLivro.Size = new Size(220, 40);
            btnLivro.TabIndex = 6;
            btnLivro.Text = "Livro";
            btnLivro.UseVisualStyleBackColor = true;
            // 
            // btnTelefone
            // 
            btnTelefone.Cursor = Cursors.Hand;
            btnTelefone.Dock = DockStyle.Top;
            btnTelefone.FlatAppearance.BorderSize = 0;
            btnTelefone.FlatStyle = FlatStyle.Flat;
            btnTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTelefone.ForeColor = SystemColors.Highlight;
            btnTelefone.Location = new Point(0, 244);
            btnTelefone.Name = "btnTelefone";
            btnTelefone.Size = new Size(220, 40);
            btnTelefone.TabIndex = 5;
            btnTelefone.Text = "Telefone";
            btnTelefone.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCliente.ForeColor = SystemColors.Highlight;
            btnCliente.Location = new Point(0, 204);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(220, 40);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            btnFuncionario.Cursor = Cursors.Hand;
            btnFuncionario.Dock = DockStyle.Top;
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFuncionario.ForeColor = SystemColors.Highlight;
            btnFuncionario.Location = new Point(0, 164);
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
            containerLogo.Size = new Size(220, 164);
            containerLogo.TabIndex = 2;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe Print", 17F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titulo.Location = new Point(14, 35);
            titulo.Name = "titulo";
            titulo.Size = new Size(191, 40);
            titulo.TabIndex = 1;
            titulo.Text = "Livraria Online";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.icone_livros;
            logo.Location = new Point(71, 78);
            logo.Name = "logo";
            logo.Size = new Size(72, 72);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icone_livros;
            pictureBox1.Location = new Point(419, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // funcionario1
            // 
            funcionario1.Location = new Point(223, 0);
            funcionario1.Name = "funcionario1";
            funcionario1.Size = new Size(848, 595);
            funcionario1.TabIndex = 3;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 595);
            Controls.Add(funcionario1);
            Controls.Add(pictureBox1);
            Controls.Add(menuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            menuLateral.ResumeLayout(false);
            containerLogo.ResumeLayout(false);
            containerLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button btnSair;
        private Funcionario funcionario1;
    }
}