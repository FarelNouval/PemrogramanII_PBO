namespace P9_1214070.view
{
    partial class FormBarang
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnrefresh = new System.Windows.Forms.Button();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.gbtombol = new System.Windows.Forms.GroupBox();
            this.gbform = new System.Windows.Forms.GroupBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbtable = new System.Windows.Forms.GroupBox();
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbtombol.SuspendLayout();
            this.gbform.SuspendLayout();
            this.gbtable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCariData);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(64, 32);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(258, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(102, 26);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(220, 20);
            this.tbNamaBarang.TabIndex = 4;
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
            // gbtombol
            // 
            this.gbtombol.Controls.Add(this.btnhapus);
            this.gbtombol.Controls.Add(this.btnubah);
            this.gbtombol.Controls.Add(this.btnsimpan);
            this.gbtombol.Controls.Add(this.btnrefresh);
            this.gbtombol.Location = new System.Drawing.Point(546, 354);
            this.gbtombol.Name = "gbtombol";
            this.gbtombol.Size = new System.Drawing.Size(328, 178);
            this.gbtombol.TabIndex = 6;
            this.gbtombol.TabStop = false;
            this.gbtombol.Text = "Tombol Action";
            // 
            // gbform
            // 
            this.gbform.Controls.Add(this.tbHarga);
            this.gbform.Controls.Add(this.label2);
            this.gbform.Controls.Add(this.tbNamaBarang);
            this.gbform.Controls.Add(this.label1);
            this.gbform.Location = new System.Drawing.Point(13, 320);
            this.gbform.Name = "gbform";
            this.gbform.Size = new System.Drawing.Size(510, 112);
            this.gbform.TabIndex = 5;
            this.gbform.TabStop = false;
            this.gbform.Text = "Form Input Barang";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(102, 63);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(220, 20);
            this.tbHarga.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
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
            // gbtable
            // 
            this.gbtable.Controls.Add(this.groupBox1);
            this.gbtable.Controls.Add(this.DataBarang);
            this.gbtable.Location = new System.Drawing.Point(12, 12);
            this.gbtable.Name = "gbtable";
            this.gbtable.Size = new System.Drawing.Size(867, 292);
            this.gbtable.TabIndex = 4;
            this.gbtable.TabStop = false;
            this.gbtable.Text = "Table Data Barang";
            // 
            // DataBarang
            // 
            this.DataBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(6, 19);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.Size = new System.Drawing.Size(855, 267);
            this.DataBarang.TabIndex = 0;
            this.DataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellClick);
            this.DataBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellContentClick);
            this.DataBarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataBarang_CellFormatting);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbtombol);
            this.Controls.Add(this.gbform);
            this.Controls.Add(this.gbtable);
            this.Name = "FormBarang";
            this.Text = "Form Barang";
            this.Load += new System.EventHandler(this.barang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbtombol.ResumeLayout(false);
            this.gbform.ResumeLayout(false);
            this.gbform.PerformLayout();
            this.gbtable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbtombol;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.GroupBox gbform;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbtable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataBarang;
    }
}