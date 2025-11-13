namespace atividadeMatriz
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mtsMenu = new MenuStrip();
            programasToolStripMenuItem = new ToolStripMenuItem();
            matrizAoQuadradoToolStripMenuItem = new ToolStripMenuItem();
            trocaDeSinaisToolStripMenuItem = new ToolStripMenuItem();
            matrizAoCuboToolStripMenuItem = new ToolStripMenuItem();
            loopingToolStripMenuItem = new ToolStripMenuItem();
            ex1ToolStripMenuItem = new ToolStripMenuItem();
            ex2ToolStripMenuItem = new ToolStripMenuItem();
            ex3ToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            mtsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mtsMenu
            // 
            mtsMenu.ImageScalingSize = new Size(20, 20);
            mtsMenu.Items.AddRange(new ToolStripItem[] { programasToolStripMenuItem, loopingToolStripMenuItem, sairToolStripMenuItem });
            mtsMenu.Location = new Point(0, 0);
            mtsMenu.Name = "mtsMenu";
            mtsMenu.Padding = new Padding(5, 2, 0, 2);
            mtsMenu.Size = new Size(700, 24);
            mtsMenu.TabIndex = 0;
            mtsMenu.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { matrizAoQuadradoToolStripMenuItem, trocaDeSinaisToolStripMenuItem, matrizAoCuboToolStripMenuItem });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(76, 20);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // matrizAoQuadradoToolStripMenuItem
            // 
            matrizAoQuadradoToolStripMenuItem.Name = "matrizAoQuadradoToolStripMenuItem";
            matrizAoQuadradoToolStripMenuItem.Size = new Size(180, 22);
            matrizAoQuadradoToolStripMenuItem.Text = "Matriz ao Quadrado";
            matrizAoQuadradoToolStripMenuItem.Click += matrizAoQuadradoToolStripMenuItem_Click;
            // 
            // trocaDeSinaisToolStripMenuItem
            // 
            trocaDeSinaisToolStripMenuItem.Name = "trocaDeSinaisToolStripMenuItem";
            trocaDeSinaisToolStripMenuItem.Size = new Size(180, 22);
            trocaDeSinaisToolStripMenuItem.Text = "Troca de Sinais";
            trocaDeSinaisToolStripMenuItem.Click += trocaDeSinaisToolStripMenuItem_Click;
            // 
            // matrizAoCuboToolStripMenuItem
            // 
            matrizAoCuboToolStripMenuItem.Name = "matrizAoCuboToolStripMenuItem";
            matrizAoCuboToolStripMenuItem.Size = new Size(180, 22);
            matrizAoCuboToolStripMenuItem.Text = "Matriz ao Cubo";
            matrizAoCuboToolStripMenuItem.Click += matrizAoCuboToolStripMenuItem_Click;
            // 
            // loopingToolStripMenuItem
            // 
            loopingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ex1ToolStripMenuItem, ex2ToolStripMenuItem, ex3ToolStripMenuItem });
            loopingToolStripMenuItem.Name = "loopingToolStripMenuItem";
            loopingToolStripMenuItem.Size = new Size(63, 20);
            loopingToolStripMenuItem.Text = "Looping";
            // 
            // ex1ToolStripMenuItem
            // 
            ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            ex1ToolStripMenuItem.Size = new Size(180, 22);
            ex1ToolStripMenuItem.Text = "Ex 1";
            ex1ToolStripMenuItem.Click += ex1ToolStripMenuItem_Click;
            // 
            // ex2ToolStripMenuItem
            // 
            ex2ToolStripMenuItem.Name = "ex2ToolStripMenuItem";
            ex2ToolStripMenuItem.Size = new Size(180, 22);
            ex2ToolStripMenuItem.Text = "Ex 2";
            ex2ToolStripMenuItem.Click += ex2ToolStripMenuItem_Click;
            // 
            // ex3ToolStripMenuItem
            // 
            ex3ToolStripMenuItem.Name = "ex3ToolStripMenuItem";
            ex3ToolStripMenuItem.Size = new Size(180, 22);
            ex3ToolStripMenuItem.Text = "Ex 3";
            ex3ToolStripMenuItem.Click += ex3ToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(mtsMenu);
            MainMenuStrip = mtsMenu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            Text = "Menu";
            mtsMenu.ResumeLayout(false);
            mtsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mtsMenu;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem matrizAoQuadradoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem trocaDeSinaisToolStripMenuItem;
        private ToolStripMenuItem matrizAoCuboToolStripMenuItem;
        private ToolStripMenuItem loopingToolStripMenuItem;
        private ToolStripMenuItem ex1ToolStripMenuItem;
        private ToolStripMenuItem ex2ToolStripMenuItem;
        private ToolStripMenuItem ex3ToolStripMenuItem;
    }
}
