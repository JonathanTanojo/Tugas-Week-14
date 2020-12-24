namespace Quiz_Panda
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
            this.labelkalimat = new System.Windows.Forms.Label();
            this.labelhuruf = new System.Windows.Forms.Label();
            this.labelmenjadi = new System.Windows.Forms.Label();
            this.textBoxkalimat = new System.Windows.Forms.TextBox();
            this.textBoxhuruf = new System.Windows.Forms.TextBox();
            this.textBoxmenjadi = new System.Windows.Forms.TextBox();
            this.buttonkonversi = new System.Windows.Forms.Button();
            this.labelhasil = new System.Windows.Forms.Label();
            this.labelperubahan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelkalimat
            // 
            this.labelkalimat.AutoSize = true;
            this.labelkalimat.Location = new System.Drawing.Point(43, 69);
            this.labelkalimat.Name = "labelkalimat";
            this.labelkalimat.Size = new System.Drawing.Size(94, 13);
            this.labelkalimat.TabIndex = 0;
            this.labelkalimat.Text = "Masukkan Kalimat";
            // 
            // labelhuruf
            // 
            this.labelhuruf.AutoSize = true;
            this.labelhuruf.Location = new System.Drawing.Point(43, 107);
            this.labelhuruf.Name = "labelhuruf";
            this.labelhuruf.Size = new System.Drawing.Size(80, 13);
            this.labelhuruf.TabIndex = 1;
            this.labelhuruf.Text = "Masukan Huruf";
            // 
            // labelmenjadi
            // 
            this.labelmenjadi.AutoSize = true;
            this.labelmenjadi.Location = new System.Drawing.Point(317, 106);
            this.labelmenjadi.Name = "labelmenjadi";
            this.labelmenjadi.Size = new System.Drawing.Size(44, 13);
            this.labelmenjadi.TabIndex = 2;
            this.labelmenjadi.Text = "Menjadi";
            // 
            // textBoxkalimat
            // 
            this.textBoxkalimat.Location = new System.Drawing.Point(168, 69);
            this.textBoxkalimat.Name = "textBoxkalimat";
            this.textBoxkalimat.Size = new System.Drawing.Size(100, 20);
            this.textBoxkalimat.TabIndex = 3;
            // 
            // textBoxhuruf
            // 
            this.textBoxhuruf.Location = new System.Drawing.Point(168, 107);
            this.textBoxhuruf.Name = "textBoxhuruf";
            this.textBoxhuruf.Size = new System.Drawing.Size(100, 20);
            this.textBoxhuruf.TabIndex = 4;
            // 
            // textBoxmenjadi
            // 
            this.textBoxmenjadi.Location = new System.Drawing.Point(385, 106);
            this.textBoxmenjadi.Name = "textBoxmenjadi";
            this.textBoxmenjadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxmenjadi.TabIndex = 5;
            // 
            // buttonkonversi
            // 
            this.buttonkonversi.Location = new System.Drawing.Point(64, 178);
            this.buttonkonversi.Name = "buttonkonversi";
            this.buttonkonversi.Size = new System.Drawing.Size(394, 23);
            this.buttonkonversi.TabIndex = 6;
            this.buttonkonversi.Text = "Konversi";
            this.buttonkonversi.UseVisualStyleBackColor = true;
            this.buttonkonversi.Click += new System.EventHandler(this.buttonkonversi_Click);
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Location = new System.Drawing.Point(46, 244);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(30, 13);
            this.labelhasil.TabIndex = 7;
            this.labelhasil.Text = "Hasil";
            // 
            // labelperubahan
            // 
            this.labelperubahan.AutoSize = true;
            this.labelperubahan.Location = new System.Drawing.Point(146, 244);
            this.labelperubahan.Name = "labelperubahan";
            this.labelperubahan.Size = new System.Drawing.Size(16, 13);
            this.labelperubahan.TabIndex = 8;
            this.labelperubahan.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 308);
            this.Controls.Add(this.labelperubahan);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.buttonkonversi);
            this.Controls.Add(this.textBoxmenjadi);
            this.Controls.Add(this.textBoxhuruf);
            this.Controls.Add(this.textBoxkalimat);
            this.Controls.Add(this.labelmenjadi);
            this.Controls.Add(this.labelhuruf);
            this.Controls.Add(this.labelkalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkalimat;
        private System.Windows.Forms.Label labelhuruf;
        private System.Windows.Forms.Label labelmenjadi;
        private System.Windows.Forms.TextBox textBoxkalimat;
        private System.Windows.Forms.TextBox textBoxhuruf;
        private System.Windows.Forms.TextBox textBoxmenjadi;
        private System.Windows.Forms.Button buttonkonversi;
        private System.Windows.Forms.Label labelhasil;
        private System.Windows.Forms.Label labelperubahan;
    }
}

