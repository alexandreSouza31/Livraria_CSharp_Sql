namespace Livraria
{
    partial class Funcionario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFuncionario = new Label();
            labelCodigo = new Label();
            labelLogin = new Label();
            labelNome = new Label();
            inputNome = new TextBox();
            inputLogin = new TextBox();
            inputSenha = new TextBox();
            labelSenha = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dgvRetornoPesquisa = new DataGridView();
            groupBoxPesquisarFuncionario = new GroupBox();
            textBox2 = new TextBox();
            inputPesquisarFuncionario = new TextBox();
            btnNovo = new Button();
            btnAlterar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnRemover = new Button();
            inputCodigoDB = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRetornoPesquisa).BeginInit();
            groupBoxPesquisarFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // labelFuncionario
            // 
            labelFuncionario.AutoSize = true;
            labelFuncionario.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFuncionario.ForeColor = SystemColors.Highlight;
            labelFuncionario.Location = new Point(303, 35);
            labelFuncionario.Name = "labelFuncionario";
            labelFuncionario.Size = new Size(213, 47);
            labelFuncionario.TabIndex = 0;
            labelFuncionario.Text = "Funcionário";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCodigo.ForeColor = SystemColors.Desktop;
            labelCodigo.Location = new Point(98, 169);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(79, 25);
            labelCodigo.TabIndex = 1;
            labelCodigo.Text = "Código:";
            labelCodigo.Visible = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = SystemColors.Desktop;
            labelLogin.Location = new Point(98, 249);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(66, 25);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "Login:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNome.ForeColor = SystemColors.Desktop;
            labelNome.Location = new Point(98, 209);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(70, 25);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome:";
            // 
            // inputNome
            // 
            inputNome.BorderStyle = BorderStyle.None;
            inputNome.Font = new Font("Segoe UI", 14F);
            inputNome.Location = new Point(178, 206);
            inputNome.MaxLength = 60;
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(411, 25);
            inputNome.TabIndex = 4;
            // 
            // inputLogin
            // 
            inputLogin.BorderStyle = BorderStyle.None;
            inputLogin.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            inputLogin.Location = new Point(178, 246);
            inputLogin.MaxLength = 20;
            inputLogin.Name = "inputLogin";
            inputLogin.Size = new Size(239, 25);
            inputLogin.TabIndex = 5;
            // 
            // inputSenha
            // 
            inputSenha.BorderStyle = BorderStyle.None;
            inputSenha.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            inputSenha.Location = new Point(178, 286);
            inputSenha.MaxLength = 8;
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(239, 25);
            inputSenha.TabIndex = 7;
            inputSenha.UseSystemPasswordChar = true;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Cursor = Cursors.Hand;
            labelSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSenha.ForeColor = SystemColors.Desktop;
            labelSenha.Location = new Point(98, 289);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(70, 25);
            labelSenha.TabIndex = 6;
            labelSenha.Text = "Senha:";
            labelSenha.MouseDown += labelSenha_MouseDown;
            labelSenha.MouseUp += labelSenha_MouseUp;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 1F);
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(178, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(411, 2);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 1F);
            textBox5.ForeColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(178, 310);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(239, 2);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ScrollBar;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 1F);
            textBox6.ForeColor = SystemColors.ScrollBar;
            textBox6.Location = new Point(178, 271);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(239, 2);
            textBox6.TabIndex = 10;
            // 
            // dgvRetornoPesquisa
            // 
            dgvRetornoPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRetornoPesquisa.GridColor = SystemColors.Highlight;
            dgvRetornoPesquisa.Location = new Point(98, 438);
            dgvRetornoPesquisa.MultiSelect = false;
            dgvRetornoPesquisa.Name = "dgvRetornoPesquisa";
            dgvRetornoPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRetornoPesquisa.Size = new Size(491, 132);
            dgvRetornoPesquisa.TabIndex = 11;
            dgvRetornoPesquisa.MouseDoubleClick += dgvRetornoPesquisa_MouseDoubleClick;
            // 
            // groupBoxPesquisarFuncionario
            // 
            groupBoxPesquisarFuncionario.Controls.Add(textBox2);
            groupBoxPesquisarFuncionario.Controls.Add(inputPesquisarFuncionario);
            groupBoxPesquisarFuncionario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxPesquisarFuncionario.Location = new Point(98, 362);
            groupBoxPesquisarFuncionario.Name = "groupBoxPesquisarFuncionario";
            groupBoxPesquisarFuncionario.Size = new Size(491, 66);
            groupBoxPesquisarFuncionario.TabIndex = 13;
            groupBoxPesquisarFuncionario.TabStop = false;
            groupBoxPesquisarFuncionario.Text = "Pesquisar Funcionario";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 1F);
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(82, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(411, 2);
            textBox2.TabIndex = 14;
            // 
            // inputPesquisarFuncionario
            // 
            inputPesquisarFuncionario.BorderStyle = BorderStyle.None;
            inputPesquisarFuncionario.Font = new Font("Segoe UI", 14F);
            inputPesquisarFuncionario.Location = new Point(82, 42);
            inputPesquisarFuncionario.MaxLength = 60;
            inputPesquisarFuncionario.Name = "inputPesquisarFuncionario";
            inputPesquisarFuncionario.Size = new Size(411, 25);
            inputPesquisarFuncionario.TabIndex = 14;
            inputPesquisarFuncionario.TextChanged += inputPesquisarFuncionario_TextChanged;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = SystemColors.GradientActiveCaption;
            btnNovo.Cursor = Cursors.Hand;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNovo.ForeColor = SystemColors.Highlight;
            btnNovo.Location = new Point(646, 175);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(100, 55);
            btnNovo.TabIndex = 14;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = SystemColors.GradientActiveCaption;
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAlterar.ForeColor = SystemColors.Highlight;
            btnAlterar.Location = new Point(646, 345);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(100, 55);
            btnAlterar.TabIndex = 15;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.GradientActiveCaption;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.Highlight;
            btnSalvar.Location = new Point(646, 260);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 55);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.GradientActiveCaption;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Highlight;
            btnCancelar.Location = new Point(646, 515);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 55);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = SystemColors.GradientActiveCaption;
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRemover.ForeColor = SystemColors.Highlight;
            btnRemover.Location = new Point(646, 430);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 55);
            btnRemover.TabIndex = 18;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // inputCodigoDB
            // 
            inputCodigoDB.AutoSize = true;
            inputCodigoDB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            inputCodigoDB.ForeColor = SystemColors.Desktop;
            inputCodigoDB.Location = new Point(178, 169);
            inputCodigoDB.Name = "inputCodigoDB";
            inputCodigoDB.Size = new Size(17, 25);
            inputCodigoDB.TabIndex = 19;
            inputCodigoDB.Text = " ";
            inputCodigoDB.Visible = false;
            // 
            // Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inputCodigoDB);
            Controls.Add(btnRemover);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnAlterar);
            Controls.Add(btnNovo);
            Controls.Add(groupBoxPesquisarFuncionario);
            Controls.Add(dgvRetornoPesquisa);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(inputSenha);
            Controls.Add(labelSenha);
            Controls.Add(inputLogin);
            Controls.Add(inputNome);
            Controls.Add(labelNome);
            Controls.Add(labelLogin);
            Controls.Add(labelCodigo);
            Controls.Add(labelFuncionario);
            Name = "Funcionario";
            Size = new Size(848, 595);
            ((System.ComponentModel.ISupportInitialize)dgvRetornoPesquisa).EndInit();
            groupBoxPesquisarFuncionario.ResumeLayout(false);
            groupBoxPesquisarFuncionario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFuncionario;
        private Label labelCodigo;
        private Label labelLogin;
        private Label labelNome;
        private TextBox inputNome;
        private TextBox inputLogin;
        private TextBox inputSenha;
        private Label labelSenha;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView dgvRetornoPesquisa;
        private GroupBox groupBoxPesquisarFuncionario;
        private TextBox inputPesquisarFuncionario;
        private TextBox textBox2;
        private Button btnNovo;
        private Button btnAlterar;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnRemover;
        private Label inputCodigoDB;
    }
}
