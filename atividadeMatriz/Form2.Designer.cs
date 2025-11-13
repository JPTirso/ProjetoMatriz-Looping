namespace atividadeMatriz
{
    partial class FrmMatriz1
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
            btnCalcular = new Button();
            btnAdd = new Button();
            lstMatrizB = new ListBox();
            lstMatrizA = new ListBox();
            txtNum = new TextBox();
            lblNum = new Label();
            lblMatrizA = new Label();
            lblMatrizB = new Label();
            btnVoltar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(88, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 58);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Visible = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(88, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 58);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstMatrizB
            // 
            lstMatrizB.FormattingEnabled = true;
            lstMatrizB.Location = new Point(548, 165);
            lstMatrizB.Name = "lstMatrizB";
            lstMatrizB.Size = new Size(150, 184);
            lstMatrizB.TabIndex = 7;
            // 
            // lstMatrizA
            // 
            lstMatrizA.FormattingEnabled = true;
            lstMatrizA.Location = new Point(323, 165);
            lstMatrizA.Name = "lstMatrizA";
            lstMatrizA.Size = new Size(150, 184);
            lstMatrizA.TabIndex = 6;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(272, 79);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 27);
            txtNum.TabIndex = 5;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(3, 82);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(263, 20);
            lblNum.TabIndex = 10;
            lblNum.Text = "Digite o numero que deseja adicionar:";
            lblNum.Click += lblNum_Click;
            // 
            // lblMatrizA
            // 
            lblMatrizA.AutoSize = true;
            lblMatrizA.Location = new Point(359, 130);
            lblMatrizA.Name = "lblMatrizA";
            lblMatrizA.Size = new Size(65, 20);
            lblMatrizA.TabIndex = 11;
            lblMatrizA.Text = "Matriz A";
            // 
            // lblMatrizB
            // 
            lblMatrizB.AutoSize = true;
            lblMatrizB.Location = new Point(587, 130);
            lblMatrizB.Name = "lblMatrizB";
            lblMatrizB.Size = new Size(64, 20);
            lblMatrizB.TabIndex = 12;
            lblMatrizB.Text = "Matriz B";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(587, 367);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 61);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(316, 367);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(145, 61);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FrmMatriz1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FrmMatriz1";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnAdd;
        private ListBox lstMatrizB;
        private ListBox lstMatrizA;
        private TextBox txtNum;
        private Label lblNum;
        private Label lblMatrizA;
        private Label lblMatrizB;
        private Button btnVoltar;
        private Button btnLimpar;
    }
}