namespace Sy.Forms
{
    partial class ProductForm
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
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblKritikStok = new System.Windows.Forms.Label();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.nudKritikStok = new System.Windows.Forms.NumericUpDown();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.lblUurn = new System.Windows.Forms.Label();
            this.txtUurun = new System.Windows.Forms.TextBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKritikStok)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(12, 52);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(12, 24);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(48, 13);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "Ürün Adı";
            // 
            // lblKritikStok
            // 
            this.lblKritikStok.AutoSize = true;
            this.lblKritikStok.Location = new System.Drawing.Point(12, 80);
            this.lblKritikStok.Name = "lblKritikStok";
            this.lblKritikStok.Size = new System.Drawing.Size(55, 13);
            this.lblKritikStok.TabIndex = 2;
            this.lblKritikStok.Text = "Kritik Stok";
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(104, 17);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(120, 20);
            this.txtUrun.TabIndex = 3;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(104, 43);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 4;
            // 
            // nudKritikStok
            // 
            this.nudKritikStok.Location = new System.Drawing.Point(104, 78);
            this.nudKritikStok.Name = "nudKritikStok";
            this.nudKritikStok.Size = new System.Drawing.Size(120, 20);
            this.nudKritikStok.TabIndex = 5;
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(149, 119);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnKayıt.TabIndex = 6;
            this.btnKayıt.Text = "Kayıt";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // lblUurn
            // 
            this.lblUurn.AutoSize = true;
            this.lblUurn.Location = new System.Drawing.Point(165, 158);
            this.lblUurn.Name = "lblUurn";
            this.lblUurn.Size = new System.Drawing.Size(59, 13);
            this.lblUurn.TabIndex = 7;
            this.lblUurn.Text = "Urun Bilgisi";
            // 
            // txtUurun
            // 
            this.txtUurun.Location = new System.Drawing.Point(313, 21);
            this.txtUurun.Name = "txtUurun";
            this.txtUurun.Size = new System.Drawing.Size(278, 20);
            this.txtUurun.TabIndex = 8;
            this.txtUurun.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUurun_KeyUp);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(313, 61);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(278, 173);
            this.lstUrunler.TabIndex = 9;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.txtUurun);
            this.Controls.Add(this.lblUurn);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.nudKritikStok);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.lblKritikStok);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.lblFiyat);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKritikStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblKritikStok;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.NumericUpDown nudKritikStok;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Label lblUurn;
        private System.Windows.Forms.TextBox txtUurun;
        private System.Windows.Forms.ListBox lstUrunler;
    }
}