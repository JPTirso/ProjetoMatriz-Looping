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
            btnVoltar.Location = new Point(513, 254);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(127, 46);
            btnVoltar.TabIndex = 24;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(312, 254);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(127, 46);
            btnLimpar.TabIndex = 23;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblMatrizB
            // 
            lblMatrizB.AutoSize = true;
            lblMatrizB.Location = new Point(542, 76);
            lblMatrizB.Name = "lblMatrizB";
            lblMatrizB.Size = new Size(50, 15);
            lblMatrizB.TabIndex = 22;
            lblMatrizB.Text = "Matriz B";
            // 
            // lblMatrizA
            // 
            lblMatrizA.AutoSize = true;
            lblMatrizA.Location = new Point(343, 76);
            lblMatrizA.Name = "lblMatrizA";
            lblMatrizA.Size = new Size(51, 15);
            lblMatrizA.TabIndex = 21;
            lblMatrizA.Text = "Matriz A";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(32, 40);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(252, 15);
            lblNum.TabIndex = 20;
            lblNum.Text = "Digite o numero positivo que deseja adicionar:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(106, 118);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 44);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Visible = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(106, 118);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 44);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstMatrizB
            // 
            lstMatrizB.FormattingEnabled = true;
            lstMatrizB.ItemHeight = 15;
            lstMatrizB.Location = new Point(508, 103);
            lstMatrizB.Margin = new Padding(3, 2, 3, 2);
            lstMatrizB.Name = "lstMatrizB";
            lstMatrizB.Size = new Size(132, 139);
            lstMatrizB.TabIndex = 17;
            // 
            // lstMatrizA
            // 
            lstMatrizA.FormattingEnabled = true;
            lstMatrizA.ItemHeight = 15;
            lstMatrizA.Location = new Point(312, 103);
            lstMatrizA.Margin = new Padding(3, 2, 3, 2);
            lstMatrizA.Name = "lstMatrizA";
            lstMatrizA.Size = new Size(132, 139);
            lstMatrizA.TabIndex = 16;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(312, 38);
            txtNum.Margin = new Padding(3, 2, 3, 2);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(110, 23);
            txtNum.TabIndex = 15;
            // 
            // FrmTroca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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