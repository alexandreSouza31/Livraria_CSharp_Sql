namespace Livraria
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnEntrar = new Button();
            caixaSenha = new Panel();
            panel4 = new Panel();
            inputSenha = new TextBox();
            btnSenha = new PictureBox();
            btnSenhaVisivel = new PictureBox();
            caixaLogin = new Panel();
            panel5 = new Panel();
            inputLogin = new TextBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            btnFechar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            caixaSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSenhaVisivel).BeginInit();
            caixaLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 491);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icone_livros;
            pictureBox2.Location = new Point(40, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1, 1);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            label2.Location = new Point(21, 238);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 1;
            label2.Text = "Bem-vindo(a) à";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 27F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 276);
            label1.Name = "label1";
            label1.Size = new Size(298, 64);
            label1.TabIndex = 0;
            label1.Text = "Livraria Online";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(caixaSenha);
            panel2.Controls.Add(caixaLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnFechar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 491);
            panel2.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.GradientActiveCaption;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(9, 289);
            btnEntrar.Margin = new Padding(0);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(200, 51);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // caixaSenha
            // 
            caixaSenha.BackColor = Color.White;
            caixaSenha.Controls.Add(panel4);
            caixaSenha.Controls.Add(inputSenha);
            caixaSenha.Controls.Add(btnSenha);
            caixaSenha.Controls.Add(btnSenhaVisivel);
            caixaSenha.Font = new Font("Segoe UI", 9F);
            caixaSenha.Location = new Point(6, 229);
            caixaSenha.Name = "caixaSenha";
            caixaSenha.Size = new Size(420, 45);
            caixaSenha.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(44, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 1);
            panel4.TabIndex = 6;
            // 
            // inputSenha
            // 
            inputSenha.BorderStyle = BorderStyle.None;
            inputSenha.Font = new Font("Segoe UI", 12F);
            inputSenha.Location = new Point(56, 13);
            inputSenha.MaxLength = 8;
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(360, 22);
            inputSenha.TabIndex = 6;
            inputSenha.UseSystemPasswordChar = true;
            inputSenha.TextChanged += inputSenha_TextChanged;
            // 
            // btnSenha
            // 
            btnSenha.Image = Properties.Resources.icone_senha1;
            btnSenha.Location = new Point(3, 3);
            btnSenha.Name = "btnSenha";
            btnSenha.Size = new Size(38, 39);
            btnSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSenha.TabIndex = 5;
            btnSenha.TabStop = false;
            btnSenha.Click += btnSenha_Click;
            // 
            // btnSenhaVisivel
            // 
            btnSenhaVisivel.Image = Properties.Resources.icone_senha_visivel;
            btnSenhaVisivel.Location = new Point(3, 3);
            btnSenhaVisivel.Name = "btnSenhaVisivel";
            btnSenhaVisivel.Size = new Size(38, 39);
            btnSenhaVisivel.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSenhaVisivel.TabIndex = 7;
            btnSenhaVisivel.TabStop = false;
            btnSenhaVisivel.Click += btnSenhaVisivel_Click;
            // 
            // caixaLogin
            // 
            caixaLogin.BackColor = Color.White;
            caixaLogin.Controls.Add(panel5);
            caixaLogin.Controls.Add(inputLogin);
            caixaLogin.Controls.Add(pictureBox3);
            caixaLogin.Location = new Point(6, 169);
            caixaLogin.Name = "caixaLogin";
            caixaLogin.Size = new Size(420, 45);
            caixaLogin.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(44, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(372, 1);
            panel5.TabIndex = 7;
            // 
            // inputLogin
            // 
            inputLogin.BorderStyle = BorderStyle.None;
            inputLogin.Font = new Font("Segoe UI", 12F);
            inputLogin.Location = new Point(44, 13);
            inputLogin.MaxLength = 20;
            inputLogin.Name = "inputLogin";
            inputLogin.Size = new Size(372, 22);
            inputLogin.TabIndex = 5;
            inputLogin.TextChanged += inputLogin_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icone_usuario1;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 35);
            label3.Name = "label3";
            label3.Size = new Size(105, 48);
            label3.TabIndex = 2;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.GradientActiveCaption;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnFechar.ForeColor = Color.Black;
            btnFechar.Location = new Point(226, 289);
            btnFechar.Margin = new Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(200, 51);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFecharApp_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            caixaSenha.ResumeLayout(false);
            caixaSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSenhaVisivel).EndInit();
            caixaLogin.ResumeLayout(false);
            caixaLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnFechar;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel caixaLogin;
        private Panel caixaSenha;
        private PictureBox btnSenha;
        private PictureBox pictureBox3;
        private TextBox inputSenha;
        private TextBox inputLogin;
        private Button btnEntrar;
        private Panel panel4;
        private Panel panel5;
        private PictureBox btnSenhaVisivel;
    }
}
