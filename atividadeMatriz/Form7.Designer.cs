namespace atividadeMatriz
{
    partial class FrmTabuada
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
            btnWhile = new Button();
            btnFor = new Button();
            btnVoltar = new Button();
            btnLimpar = new Button();
            lblNum = new Label();
            btnDoWhile = new Button();
            lstTabuada = new ListBox();
            txtNum = new TextBox();
            SuspendLayout();
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(56, 242);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(120, 58);
            btnWhile.TabIndex = 59;
            btnWhile.Text = "Calcular While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(56, 146);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(120, 58);
            btnFor.TabIndex = 58;
            btnFor.Text = "Calcular For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(617, 344);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 61);
            btnVoltar.TabIndex = 57;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(393, 344);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(145, 61);
            btnLimpar.TabIndex = 56;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(56, 49);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(320, 20);
            lblNum.TabIndex = 55;
            lblNum.Text = "Digite o numero positivo que deseja adicionar:";
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(56, 344);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(120, 58);
            btnDoWhile.TabIndex = 54;
            btnDoWhile.Text = "Calcular Do-While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // lstTabuada
            // 
            lstTabuada.FormattingEnabled = true;
            lstTabuada.Location = new Point(543, 101);
            lstTabuada.Name = "lstTabuada";
            lstTabuada.Size = new Size(219, 184);
            lstTabuada.TabIndex = 53;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(376, 46);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 27);
            txtNum.TabIndex = 52;
            // 
            // FrmTabuada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWhile);
            Controls.Add(btnFor);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(lblNum);
            Controls.Add(btnDoWhile);
            Controls.Add(lstTabuada);
            Controls.Add(txtNum);
            Name = "FrmTabuada";
            Text = "Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWhile;
        private Button btnFor;
        private Button btnVoltar;
        private Button btnLimpar;
        private Label lblNum;
        private Button btnDoWhile;
        private ListBox lstTabuada;
        private TextBox txtNum;
    }
}