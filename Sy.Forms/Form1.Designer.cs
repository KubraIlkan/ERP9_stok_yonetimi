namespace Sy.Forms
{
    partial class Form1
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
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbGiris.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.btnKayitOl);
            this.gbGiris.Controls.Add(this.btnGirisYap);
            this.gbGiris.Location = new System.Drawing.Point(106, 42);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(207, 100);
            this.gbGiris.TabIndex = 0;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Giris";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(103, 41);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(75, 23);
            this.btnKayitOl.TabIndex = 1;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(6, 41);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldiniz.ForeColor = System.Drawing.Color.Red;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(109, 7);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(128, 13);
            this.lblHosgeldiniz.TabIndex = 3;
            this.lblHosgeldiniz.Text = "Hoşgeldin: Kamil Fıdıl";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.siparişlerToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 213);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 213);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.gbGiris);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbGiris.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGiris;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
    }
}

