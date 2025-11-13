namespace atividadeMatriz
{
    partial class FrmComodo
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
            lblNum = new Label();
            btnDoWhile = new Button();
            lstAreac = new ListBox();
            txtComodo = new TextBox();
            btnFor = new Button();
            btnWhile = new Button();
            label1 = new Label();
            txtComp = new TextBox();
            label2 = new Label();
            txtLarg = new TextBox();
            txtAreaT = new TextBox();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(614, 349);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 61);
            btnVoltar.TabIndex = 44;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(390, 349);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(145, 61);
            btnLimpar.TabIndex = 43;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(53, 54);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(320, 20);
            lblNum.TabIndex = 40;
            lblNum.Text = "Digite o numero positivo que deseja adicionar:";
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(237, 322);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(120, 58);
            btnDoWhile.TabIndex = 39;
            btnDoWhile.Text = "Calcular Do-While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // lstAreac
            // 
            lstAreac.FormattingEnabled = true;
            lstAreac.Location = new Point(545, 78);
            lstAreac.Name = "lstAreac";
            lstAreac.Size = new Size(219, 184);
            lstAreac.TabIndex = 36;
            // 
            // txtComodo
            // 
            txtComodo.Location = new Point(373, 51);
            txtComodo.Name = "txtComodo";
            txtComodo.Size = new Size(125, 27);
            txtComodo.TabIndex = 35;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(132, 249);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(120, 58);
            btnFor.TabIndex = 45;
            btnFor.Text = "Calcular For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(31, 322);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(120, 58);
            btnWhile.TabIndex = 46;
            btnWhile.Text = "Calcular While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 201);
            label1.Name = "label1";
            label1.Size = new Size(320, 20);
            label1.TabIndex = 48;
            label1.Text = "Digite o numero positivo que deseja adicionar:";
            // 
            // txtComp
            // 
            txtComp.Location = new Point(373, 198);
            txtComp.Name = "txtComp";
            txtComp.Size = new Size(125, 27);
            txtComp.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 157);
            label2.Name = "label2";
            label2.Size = new Size(320, 20);
            label2.TabIndex = 50;
            label2.Text = "Digite o numero positivo que deseja adicionar:";
            // 
            // txtLarg
            // 
            txtLarg.Location = new Point(373, 154);
            txtLarg.Name = "txtLarg";
            txtLarg.Size = new Size(125, 27);
            txtLarg.TabIndex = 49;
            // 
            // txtAreaT
            // 
            txtAreaT.Location = new Point(545, 280);
            txtAreaT.Name = "txtAreaT";
            txtAreaT.Size = new Size(219, 27);
            txtAreaT.TabIndex = 51;
            // 
            // FrmComodo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAreaT);
            Controls.Add(label2);
            Controls.Add(txtLarg);
            Controls.Add(label1);
            Controls.Add(txtComp);
            Controls.Add(btnWhile);
            Controls.Add(btnFor);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(lblNum);
            Controls.Add(btnDoWhile);
            Controls.Add(lstAreac);
            Controls.Add(txtComodo);
            Name = "FrmComodo";
            Text = "Calcular area de comodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnLimpar;
        private Label lblNum;
        private Button btnDoWhile;
        private ListBox lstAreac;
        private TextBox txtComodo;
        private Button btnFor;
        private Button btnWhile;
        private Label label1;
        private TextBox txtComp;
        private Label label2;
        private TextBox txtLarg;
        private TextBox txtAreaT;
    }
}