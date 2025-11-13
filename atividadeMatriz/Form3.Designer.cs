namespace atividadeMatriz
{
    partial class FrmTroca
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
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(586, 339);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 61);
            btnVoltar.TabIndex = 24;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(356, 339);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(145, 61);
            btnLimpar.TabIndex = 23;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblMatrizB
            // 
            lblMatrizB.AutoSize = true;
            lblMatrizB.Location = new Point(620, 102);
            lblMatrizB.Name = "lblMatrizB";
            lblMatrizB.Size = new Size(64, 20);
            lblMatrizB.TabIndex = 22;
            lblMatrizB.Text = "Matriz B";
            // 
            // lblMatrizA
            // 
            lblMatrizA.AutoSize = true;
            lblMatrizA.Location = new Point(392, 102);
            lblMatrizA.Name = "lblMatrizA";
            lblMatrizA.Size = new Size(65, 20);
            lblMatrizA.TabIndex = 21;
            lblMatrizA.Text = "Matriz A";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(36, 54);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(320, 20);
            lblNum.TabIndex = 20;
            lblNum.Text = "Digite o numero positivo que deseja adicionar:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(121, 222);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 58);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Visible = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(121, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 58);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstMatrizB
            // 
            lstMatrizB.FormattingEnabled = true;
            lstMatrizB.Location = new Point(581, 137);
            lstMatrizB.Name = "lstMatrizB";
            lstMatrizB.Size = new Size(150, 184);
            lstMatrizB.TabIndex = 17;
            // 
            // lstMatrizA
            // 
            lstMatrizA.FormattingEnabled = true;
            lstMatrizA.Location = new Point(356, 137);
            lstMatrizA.Name = "lstMatrizA";
            lstMatrizA.Size = new Size(150, 184);
            lstMatrizA.TabIndex = 16;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(356, 51);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 27);
            txtNum.TabIndex = 15;
            // 
            // FrmTroca
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
            Name = "FrmTroca";
            Text = "Troca de Sinais";
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
    }
}