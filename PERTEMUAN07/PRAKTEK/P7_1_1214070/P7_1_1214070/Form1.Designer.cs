namespace P7_1_1214070
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
            this.txtNama = new System.Windows.Forms.Label();
            this.txtProdi = new System.Windows.Forms.Label();
            this.txtKelas = new System.Windows.Forms.Label();
            this.txtprodi2 = new System.Windows.Forms.TextBox();
            this.txtkelas3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSenin = new System.Windows.Forms.RadioButton();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbTravelling = new System.Windows.Forms.CheckBox();
            this.cbTidur = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.txtnama1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.AutoSize = true;
            this.txtNama.Location = new System.Drawing.Point(51, 36);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(35, 13);
            this.txtNama.TabIndex = 0;
            this.txtNama.Text = "Nama";
            // 
            // txtProdi
            // 
            this.txtProdi.AutoSize = true;
            this.txtProdi.Location = new System.Drawing.Point(51, 68);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(31, 13);
            this.txtProdi.TabIndex = 1;
            this.txtProdi.Text = "Prodi";
            // 
            // txtKelas
            // 
            this.txtKelas.AutoSize = true;
            this.txtKelas.Location = new System.Drawing.Point(51, 104);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(33, 13);
            this.txtKelas.TabIndex = 2;
            this.txtKelas.Text = "Kelas";
            // 
            // txtprodi2
            // 
            this.txtprodi2.Location = new System.Drawing.Point(178, 68);
            this.txtprodi2.Name = "txtprodi2";
            this.txtprodi2.Size = new System.Drawing.Size(126, 20);
            this.txtprodi2.TabIndex = 4;
            // 
            // txtkelas3
            // 
            this.txtkelas3.Location = new System.Drawing.Point(178, 101);
            this.txtkelas3.Name = "txtkelas3";
            this.txtkelas3.Size = new System.Drawing.Size(126, 20);
            this.txtkelas3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "LIST KEGIATAN";
            // 
            // rbSenin
            // 
            this.rbSenin.AutoSize = true;
            this.rbSenin.Location = new System.Drawing.Point(51, 240);
            this.rbSenin.Name = "rbSenin";
            this.rbSenin.Size = new System.Drawing.Size(52, 17);
            this.rbSenin.TabIndex = 7;
            this.rbSenin.TabStop = true;
            this.rbSenin.Text = "Senin";
            this.rbSenin.UseVisualStyleBackColor = true;
            this.rbSenin.CheckedChanged += new System.EventHandler(this.rbSenin_CheckedChanged);
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(51, 263);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(60, 17);
            this.rbMinggu.TabIndex = 8;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu";
            this.rbMinggu.UseVisualStyleBackColor = true;
            this.rbMinggu.CheckedChanged += new System.EventHandler(this.rbMinggu_CheckedChanged);
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Location = new System.Drawing.Point(51, 314);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(55, 17);
            this.cbKuliah.TabIndex = 9;
            this.cbKuliah.Text = "Kuliah";
            this.cbKuliah.UseVisualStyleBackColor = true;
            // 
            // cbTravelling
            // 
            this.cbTravelling.AutoSize = true;
            this.cbTravelling.Location = new System.Drawing.Point(51, 338);
            this.cbTravelling.Name = "cbTravelling";
            this.cbTravelling.Size = new System.Drawing.Size(72, 17);
            this.cbTravelling.TabIndex = 10;
            this.cbTravelling.Text = "Travelling";
            this.cbTravelling.UseVisualStyleBackColor = true;
            // 
            // cbTidur
            // 
            this.cbTidur.AutoSize = true;
            this.cbTidur.Location = new System.Drawing.Point(51, 362);
            this.cbTidur.Name = "cbTidur";
            this.cbTidur.Size = new System.Drawing.Size(62, 17);
            this.cbTidur.TabIndex = 11;
            this.cbTidur.Text = "Tiduran";
            this.cbTidur.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(104, 405);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(211, 404);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(104, 142);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(75, 23);
            this.btnCek.TabIndex = 14;
            this.btnCek.Text = "Cek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(211, 141);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 15;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // txtnama1
            // 
            this.txtnama1.Location = new System.Drawing.Point(178, 28);
            this.txtnama1.Name = "txtnama1";
            this.txtnama1.Size = new System.Drawing.Size(126, 20);
            this.txtnama1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 448);
            this.Controls.Add(this.txtnama1);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbTidur);
            this.Controls.Add(this.cbTravelling);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.rbMinggu);
            this.Controls.Add(this.rbSenin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkelas3);
            this.Controls.Add(this.txtprodi2);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNama;
        private System.Windows.Forms.Label txtProdi;
        private System.Windows.Forms.Label txtKelas;
        private System.Windows.Forms.TextBox txtprodi2;
        private System.Windows.Forms.TextBox txtkelas3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSenin;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbTravelling;
        private System.Windows.Forms.CheckBox cbTidur;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.TextBox txtnama1;
    }
}

