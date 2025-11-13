namespace atividadeMatriz
{
    partial class FrmCubo
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
            btnVoltar = new Button();
            btnLimpar = new Button();
            lblMatrizB = new Label();
            lblMatrizA = new Label();
            lblNum = new Label();
            btnCalcular = new Button();
            btnAdd = new Button();
            lstMatrizB = new ListBox();
            lstMatrizA = new ListBox();
            txtNum = new TextBox();
            btnPesquisar = new Button();
            lblPesquisa = new Label();
            txtPesquisa = new TextBox();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(298, 358);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 61);
            btnVoltar.TabIndex = 34;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(113, 358);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(145, 61);
            btnLimpar.TabIndex = 33;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblMatrizB
            // 
            lblMatrizB.AutoSize = true;
            lblMatrizB.Location = new Point(643, 72);
            lblMatrizB.Name = "lblMatrizB";
            lblMatrizB.Size = new Size(64, 20);
            lblMatrizB.TabIndex = 32;
            lblMatrizB.Text = "Matriz B";
            // 
            // lblMatrizA
            // 
            lblMatrizA.AutoSize = true;
            lblMatrizA.Location = new Point(415, 72);
            lblMatrizA.Name = "lblMatrizA";
            lblMatrizA.Size = new Size(65, 20);
            lblMatrizA.TabIndex = 31;
            lblMatrizA.Text = "Matriz A";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(37, 36);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(263, 20);
            lblNum.TabIndex = 30;
            lblNum.Text = "Digite o numero que deseja adicionar:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(138, 222);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 58);
            btnCalcular.TabIndex = 29;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Visible = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 58);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstMatrizB
            // 
            lstMatrizB.FormattingEnabled = true;
            lstMatrizB.Location = new Point(604, 107);
            lstMatrizB.Name = "lstMatrizB";
            lstMatrizB.Size = new Size(150, 184);
            lstMatrizB.TabIndex = 27;
            // 
            // lstMatrizA
            // 
            lstMatrizA.FormattingEnabled = true;
            lstMatrizA.Location = new Point(379, 107);
            lstMatrizA.Name = "lstMatrizA";
            lstMatrizA.Size = new Size(150, 184);
            lstMatrizA.TabIndex = 26;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(357, 33);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 27);
            txtNum.TabIndex = 25;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(544, 358);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(145, 61);
            btnPesquisar.TabIndex = 35;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(282, 320);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(264, 20);
            lblPesquisa.TabIndex = 37;
            lblPesquisa.Text = "Digite o numero que deseja pesquisar:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(552, 317);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(175, 27);
            txtPesquisa.TabIndex = 36;
            // 
            // FrmCubo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(lblMatrizB);
            Controls.Add(lblMatrizA);
            Controls.Add(lblNum);
            Controls.Add(btnCalcular);
            Controls.Add(btnAdd);
            Controls.Add(lstMatrizB);
            Controls.Add(lstMatrizA);
            Controls.Add(txtNum);
            Name = "FrmCubo";
            Text = "Form4";
            Load += FrmCubo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnLimpar;
        private Label lblMatrizB;
        private Label lblMatrizA;
        private Label lblNum;
        private Button btnCalcular;
        private Button btnAdd;
        private ListBox lstMatrizB;
        private ListBox lstMatrizA;
        private TextBox txtNum;
        private Button btnPesquisar;
        private Label lblPesquisa;
        private TextBox txtPesquisa;
    }
}