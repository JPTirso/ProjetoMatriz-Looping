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
            lblLarg = new Label();
            txtLarg = new TextBox();
            txtAreaT = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(157, 37);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(105, 46);
            btnVoltar.TabIndex = 44;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(6, 37);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 46);
            btnLimpar.TabIndex = 43;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 12F);
            lblNum.Location = new Point(6, 19);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(361, 21);
            lblNum.TabIndex = 40;
            lblNum.Text = "Digite o numero de comodos que deseja adicionar:";
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(291, 39);
            btnDoWhile.Margin = new Padding(3, 2, 3, 2);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(105, 44);
            btnDoWhile.TabIndex = 39;
            btnDoWhile.Text = "Calcular Do-While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // lstAreac
            // 
            lstAreac.FormattingEnabled = true;
            lstAreac.ItemHeight = 15;
            lstAreac.Location = new Point(6, 42);
            lstAreac.Margin = new Padding(3, 2, 3, 2);
            lstAreac.Name = "lstAreac";
            lstAreac.Size = new Size(256, 124);
            lstAreac.TabIndex = 36;
            // 
            // txtComodo
            // 
            txtComodo.Font = new Font("Segoe UI", 12F);
            txtComodo.Location = new Point(6, 42);
            txtComodo.Margin = new Padding(3, 2, 3, 2);
            txtComodo.Name = "txtComodo";
            txtComodo.PlaceholderText = "3";
            txtComodo.Size = new Size(161, 29);
            txtComodo.TabIndex = 35;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(6, 40);
            btnFor.Margin = new Padding(3, 2, 3, 2);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(105, 44);
            btnFor.TabIndex = 45;
            btnFor.Text = "Calcular For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(151, 40);
            btnWhile.Margin = new Padding(3, 2, 3, 2);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(105, 44);
            btnWhile.TabIndex = 46;
            btnWhile.Text = "Calcular While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 127);
            label1.Name = "label1";
            label1.Size = new Size(311, 21);
            label1.TabIndex = 48;
            label1.Text = "Digite o comprimento que deseja adicionar:";
            // 
            // txtComp
            // 
            txtComp.Font = new Font("Segoe UI", 12F);
            txtComp.Location = new Point(6, 150);
            txtComp.Margin = new Padding(3, 2, 3, 2);
            txtComp.Name = "txtComp";
            txtComp.PlaceholderText = "3;3;3";
            txtComp.Size = new Size(161, 29);
            txtComp.TabIndex = 47;
            // 
            // lblLarg
            // 
            lblLarg.AutoSize = true;
            lblLarg.Font = new Font("Segoe UI", 12F);
            lblLarg.Location = new Point(6, 73);
            lblLarg.Name = "lblLarg";
            lblLarg.Size = new Size(266, 21);
            lblLarg.TabIndex = 50;
            lblLarg.Text = "Digite a largura que deseja adicionar:";
            // 
            // txtLarg
            // 
            txtLarg.Font = new Font("Segoe UI", 12F);
            txtLarg.Location = new Point(6, 96);
            txtLarg.Margin = new Padding(3, 2, 3, 2);
            txtLarg.Name = "txtLarg";
            txtLarg.PlaceholderText = "3;3;3";
            txtLarg.Size = new Size(161, 29);
            txtLarg.TabIndex = 49;
            // 
            // txtAreaT
            // 
            txtAreaT.Location = new Point(6, 191);
            txtAreaT.Margin = new Padding(3, 2, 3, 2);
            txtAreaT.Name = "txtAreaT";
            txtAreaT.Size = new Size(256, 23);
            txtAreaT.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNum);
            groupBox1.Controls.Add(txtComodo);
            groupBox1.Controls.Add(lblLarg);
            groupBox1.Controls.Add(txtComp);
            groupBox1.Controls.Add(txtLarg);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 219);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFor);
            groupBox2.Controls.Add(btnDoWhile);
            groupBox2.Controls.Add(btnWhile);
            groupBox2.Location = new Point(12, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 89);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "Botões Calcular";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lstAreac);
            groupBox3.Controls.Add(txtAreaT);
            groupBox3.Location = new Point(420, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 219);
            groupBox3.TabIndex = 54;
            groupBox3.TabStop = false;
            groupBox3.Text = "Áreas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(256, 21);
            label2.TabIndex = 51;
            label2.Text = "Essas são as áreas de cada comodo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 168);
            label3.Name = "label3";
            label3.Size = new Size(231, 21);
            label3.TabIndex = 52;
            label3.Text = "Essa é a área total da residência:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLimpar);
            groupBox4.Controls.Add(btnVoltar);
            groupBox4.Location = new Point(420, 237);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(268, 89);
            groupBox4.TabIndex = 55;
            groupBox4.TabStop = false;
            groupBox4.Text = "Outros Botôes";
            // 
            // FrmComodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmComodo";
            Text = "Calcular area de comodos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label lblLarg;
        private TextBox txtLarg;
        private TextBox txtAreaT;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private GroupBox groupBox4;
    }
}