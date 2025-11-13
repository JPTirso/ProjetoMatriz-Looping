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
            btnCalcular.Location = new Point(77, 140);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 44);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Visible = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(77, 140);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstMatrizB
            // 
            lstMatrizB.FormattingEnabled = true;
            lstMatrizB.ItemHeight = 15;
            lstMatrizB.Location = new Point(480, 124);
            lstMatrizB.Margin = new Padding(3, 2, 3, 2);
            lstMatrizB.Name = "lstMatrizB";
            lstMatrizB.Size = new Size(132, 139);
            lstMatrizB.TabIndex = 7;
            // 
            // lstMatrizA
            // 
            lstMatrizA.FormattingEnabled = true;
            lstMatrizA.ItemHeight = 15;
            lstMatrizA.Location = new Point(283, 124);
            lstMatrizA.Margin = new Padding(3, 2, 3, 2);
            lstMatrizA.Name = "lstMatrizA";
            lstMatrizA.Size = new Size(132, 139);
            lstMatrizA.TabIndex = 6;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(238, 59);
            txtNum.Margin = new Padding(3, 2, 3, 2);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(110, 23);
            txtNum.TabIndex = 5;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(3, 62);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(207, 15);
            lblNum.TabIndex = 10;
            lblNum.Text = "Digite o numero que deseja adicionar:";
            lblNum.Click += lblNum_Click;
            // 
            // lblMatrizA
            // 
            lblMatrizA.AutoSize = true;
            lblMatrizA.Location = new Point(314, 98);
            lblMatrizA.Name = "lblMatrizA";
            lblMatrizA.Size = new Size(51, 15);
            lblMatrizA.TabIndex = 11;
            lblMatrizA.Text = "Matriz A";
            // 
            // lblMatrizB
            // 
            lblMatrizB.AutoSize = true;
            lblMatrizB.Location = new Point(514, 98);
            lblMatrizB.Name = "lblMatrizB";
            lblMatrizB.Size = new Size(50, 15);
            lblMatrizB.TabIndex = 12;
            lblMatrizB.Text = "Matriz B";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(514, 275);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(127, 46);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(276, 275);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(127, 46);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FrmMatriz1
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
            Name = "FrmMatriz1";
            Text = "Quadrado";
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