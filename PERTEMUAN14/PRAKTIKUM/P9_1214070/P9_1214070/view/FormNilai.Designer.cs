namespace P9_1214070.view
{
    partial class FormNilai
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
            this.components = new System.ComponentModel.Container();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbnpm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbtombol = new System.Windows.Forms.GroupBox();
            this.btnhapus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbform = new System.Windows.Forms.GroupBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbnilai = new System.Windows.Forms.TextBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.cbmatkul = new System.Windows.Forms.ComboBox();
            this.gbtable = new System.Windows.Forms.GroupBox();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbtombol.SuspendLayout();
            this.gbform.SuspendLayout();
            this.gbtable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(64, 26);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(258, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.tbCariData);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(540, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Pencarian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(528, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbnpm
            // 
            this.cbnpm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnpm.FormattingEnabled = true;
            this.cbnpm.Location = new System.Drawing.Point(74, 84);
            this.cbnpm.Name = "cbnpm";
            this.cbnpm.Size = new System.Drawing.Size(215, 21);
            this.cbnpm.TabIndex = 3;
            this.cbnpm.SelectedIndexChanged += new System.EventHandler(this.cbnpm_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(6, 102);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(316, 23);
            this.btnubah.TabIndex = 2;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(6, 62);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(316, 23);
            this.btnsimpan.TabIndex = 1;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(6, 19);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(316, 23);
            this.btnrefresh.TabIndex = 0;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NPM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbtombol
            // 
            this.gbtombol.Controls.Add(this.btnhapus);
            this.gbtombol.Controls.Add(this.btnubah);
            this.gbtombol.Controls.Add(this.btnsimpan);
            this.gbtombol.Controls.Add(this.btnrefresh);
            this.gbtombol.Location = new System.Drawing.Point(540, 407);
            this.gbtombol.Name = "gbtombol";
            this.gbtombol.Size = new System.Drawing.Size(328, 178);
            this.gbtombol.TabIndex = 6;
            this.gbtombol.TabStop = false;
            this.gbtombol.Text = "Tombol Action";
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(6, 140);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(316, 23);
            this.btnhapus.TabIndex = 3;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkul";
            // 
            // gbform
            // 
            this.gbform.Controls.Add(this.tbnama);
            this.gbform.Controls.Add(this.tbnilai);
            this.gbform.Controls.Add(this.cbkategori);
            this.gbform.Controls.Add(this.cbmatkul);
            this.gbform.Controls.Add(this.cbnpm);
            this.gbform.Controls.Add(this.label4);
            this.gbform.Controls.Add(this.label3);
            this.gbform.Controls.Add(this.label2);
            this.gbform.Controls.Add(this.label1);
            this.gbform.Location = new System.Drawing.Point(13, 320);
            this.gbform.Name = "gbform";
            this.gbform.Size = new System.Drawing.Size(510, 181);
            this.gbform.TabIndex = 5;
            this.gbform.TabStop = false;
            this.gbform.Text = "Form Data Nilai";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(295, 84);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(209, 20);
            this.tbnama.TabIndex = 15;
            // 
            // tbnilai
            // 
            this.tbnilai.Location = new System.Drawing.Point(74, 112);
            this.tbnilai.Name = "tbnilai";
            this.tbnilai.Size = new System.Drawing.Size(215, 20);
            this.tbnilai.TabIndex = 14;
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.cbkategori.Location = new System.Drawing.Point(74, 50);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(215, 21);
            this.cbkategori.TabIndex = 13;
            // 
            // cbmatkul
            // 
            this.cbmatkul.FormattingEnabled = true;
            this.cbmatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Pemrograman IV",
            "Literasi Data",
            "SIstem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.cbmatkul.Location = new System.Drawing.Point(74, 20);
            this.cbmatkul.Name = "cbmatkul";
            this.cbmatkul.Size = new System.Drawing.Size(215, 21);
            this.cbmatkul.TabIndex = 12;
            this.cbmatkul.SelectedIndexChanged += new System.EventHandler(this.cbmatkul_SelectedIndexChanged);
            // 
            // gbtable
            // 
            this.gbtable.Controls.Add(this.groupBox1);
            this.gbtable.Controls.Add(this.DataNilai);
            this.gbtable.Location = new System.Drawing.Point(12, 12);
            this.gbtable.Name = "gbtable";
            this.gbtable.Size = new System.Drawing.Size(867, 292);
            this.gbtable.TabIndex = 4;
            this.gbtable.TabStop = false;
            this.gbtable.Text = "Table Data Nilai";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(6, 19);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.Size = new System.Drawing.Size(855, 267);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.Location = new System.Drawing.Point(114, 50);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 28);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbtombol);
            this.Controls.Add(this.gbform);
            this.Controls.Add(this.gbtable);
            this.Name = "FormNilai";
            this.Text = "Form Nilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.Click += new System.EventHandler(this.FormNilai_Click);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbtombol.ResumeLayout(false);
            this.gbform.ResumeLayout(false);
            this.gbform.PerformLayout();
            this.gbtable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbnpm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbtombol;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.GroupBox gbform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbtable;
        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.ComboBox cbmatkul;
        private System.Windows.Forms.TextBox tbnilai;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Button btnExport;
    }
}