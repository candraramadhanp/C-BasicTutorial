namespace AppLatihan1370
{
    partial class Form2
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
            this.lbJudul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.lbNama = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbJenisKelamin = new System.Windows.Forms.Label();
            this.pilihLaki = new System.Windows.Forms.RadioButton();
            this.pilihPerempuan = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonTampil = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbJudul
            // 
            this.lbJudul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbJudul.AutoSize = true;
            this.lbJudul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudul.Location = new System.Drawing.Point(43, 38);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(65, 25);
            this.lbJudul.TabIndex = 8;
            this.lbJudul.Text = "INPUT";
            this.lbJudul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "CandraPrasetya";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textNama
            // 
            this.textNama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textNama.Location = new System.Drawing.Point(145, 75);
            this.textNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(362, 25);
            this.textNama.TabIndex = 6;
            // 
            // lbNama
            // 
            this.lbNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(45, 78);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(40, 17);
            this.lbNama.TabIndex = 9;
            this.lbNama.Text = "Nama";
            this.lbNama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbJenisKelamin
            // 
            this.lbJenisKelamin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbJenisKelamin.AutoSize = true;
            this.lbJenisKelamin.Location = new System.Drawing.Point(45, 111);
            this.lbJenisKelamin.Name = "lbJenisKelamin";
            this.lbJenisKelamin.Size = new System.Drawing.Size(82, 17);
            this.lbJenisKelamin.TabIndex = 12;
            this.lbJenisKelamin.Text = "Jenis Kelamin";
            this.lbJenisKelamin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pilihLaki
            // 
            this.pilihLaki.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pilihLaki.AutoSize = true;
            this.pilihLaki.Location = new System.Drawing.Point(145, 111);
            this.pilihLaki.Name = "pilihLaki";
            this.pilihLaki.Size = new System.Drawing.Size(73, 21);
            this.pilihLaki.TabIndex = 14;
            this.pilihLaki.TabStop = true;
            this.pilihLaki.Text = "Laki-Laki";
            this.pilihLaki.UseVisualStyleBackColor = true;
            // 
            // pilihPerempuan
            // 
            this.pilihPerempuan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pilihPerempuan.AutoSize = true;
            this.pilihPerempuan.Location = new System.Drawing.Point(145, 138);
            this.pilihPerempuan.Name = "pilihPerempuan";
            this.pilihPerempuan.Size = new System.Drawing.Size(88, 21);
            this.pilihPerempuan.TabIndex = 15;
            this.pilihPerempuan.TabStop = true;
            this.pilihPerempuan.Text = "Perempuan";
            this.pilihPerempuan.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(420, 186);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 33);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonTampil
            // 
            this.buttonTampil.Location = new System.Drawing.Point(145, 186);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(87, 33);
            this.buttonTampil.TabIndex = 16;
            this.buttonTampil.Text = "Tampil";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(238, 186);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(87, 33);
            this.buttonHapus.TabIndex = 17;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 270);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonTampil);
            this.Controls.Add(this.pilihPerempuan);
            this.Controls.Add(this.pilihLaki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbJenisKelamin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbJudul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNama);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Show Name With Gender";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbJenisKelamin;
        private System.Windows.Forms.RadioButton pilihLaki;
        private System.Windows.Forms.RadioButton pilihPerempuan;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonTampil;
        private System.Windows.Forms.Button buttonHapus;
    }
}