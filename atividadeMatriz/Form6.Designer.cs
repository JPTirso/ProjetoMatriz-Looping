namespace atividadeMatriz
{
    partial class FrmTemperatura
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
            btnDoWhile = new Button();
            lstGraus = new ListBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(89, 73);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(120, 58);
            btnWhile.TabIndex = 59;
            btnWhile.Text = "Calcular While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(89, 169);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(120, 58);
            btnFor.TabIndex = 58;
            btnFor.Text = "Calcular For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(548, 344);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 61);
            btnVoltar.TabIndex = 57;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(89, 270);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(120, 58);
            btnDoWhile.TabIndex = 54;
            btnDoWhile.Text = "Calcular Do-While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // lstGraus
            // 
            lstGraus.FormattingEnabled = true;
            lstGraus.Location = new Point(389, 93);
            lstGraus.Name = "lstGraus";
            lstGraus.Size = new Size(219, 184);
            lstGraus.TabIndex = 53;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(329, 344);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(145, 61);
            btnLimpar.TabIndex = 56;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FrmTemperatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWhile);
            Controls.Add(btnFor);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(btnDoWhile);
            Controls.Add(lstGraus);
            Name = "FrmTemperatura";
            Text = "Conversor de graus";
            ResumeLayout(false);
        }

        #endregion

        private Button btnWhile;
        private Button btnFor;
        private Button btnVoltar;
        private Button btnDoWhile;
        private ListBox lstGraus;
        private Button btnLimpar;
    }
}