namespace ats_1214070
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.rblaki = new System.Windows.Forms.RadioButton();
            this.rbperempuan = new System.Windows.Forms.RadioButton();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttahun = new System.Windows.Forms.TextBox();
            this.cbstudi = new System.Windows.Forms.ComboBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.btnpilihmatkul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbkur2006 = new System.Windows.Forms.RadioButton();
            this.rbkur2013 = new System.Windows.Forms.RadioButton();
            this.rbkurmerdeka = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbmtk = new System.Windows.Forms.CheckBox();
            this.cbpemrog1 = new System.Windows.Forms.CheckBox();
            this.cbpemrog2 = new System.Windows.Forms.CheckBox();
            this.cbpemrog3 = new System.Windows.Forms.CheckBox();
            this.cbpemrog4 = new System.Windows.Forms.CheckBox();
            this.cbfisika = new System.Windows.Forms.CheckBox();
            this.cbagama = new System.Windows.Forms.CheckBox();
            this.cbpkn = new System.Windows.Forms.CheckBox();
            this.cblogistik = new System.Windows.Forms.CheckBox();
            this.cbjaringan = new System.Windows.Forms.CheckBox();
            this.cbsistem = new System.Windows.Forms.CheckBox();
            this.cbrantaipasok = new System.Windows.Forms.CheckBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(110, 67);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(160, 20);
            this.txtnim.TabIndex = 5;
            this.txtnim.TextChanged += new System.EventHandler(this.txtnim_TextChanged);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(110, 94);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(160, 20);
            this.txtnama.TabIndex = 6;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // rblaki
            // 
            this.rblaki.AutoSize = true;
            this.rblaki.Location = new System.Drawing.Point(110, 124);
            this.rblaki.Name = "rblaki";
            this.rblaki.Size = new System.Drawing.Size(74, 17);
            this.rblaki.TabIndex = 7;
            this.rblaki.TabStop = true;
            this.rblaki.Text = "Laki - Laki";
            this.rblaki.UseVisualStyleBackColor = true;
            // 
            // rbperempuan
            // 
            this.rbperempuan.AutoSize = true;
            this.rbperempuan.Location = new System.Drawing.Point(191, 124);
            this.rbperempuan.Name = "rbperempuan";
            this.rbperempuan.Size = new System.Drawing.Size(79, 17);
            this.rbperempuan.TabIndex = 8;
            this.rbperempuan.TabStop = true;
            this.rbperempuan.Text = "Perempuan";
            this.rbperempuan.UseVisualStyleBackColor = true;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(110, 150);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(160, 47);
            this.txtalamat.TabIndex = 9;
            this.txtalamat.TextChanged += new System.EventHandler(this.txtalamat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tahun Akademik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Semester";
            // 
            // txttahun
            // 
            this.txttahun.Location = new System.Drawing.Point(481, 94);
            this.txttahun.Name = "txttahun";
            this.txttahun.Size = new System.Drawing.Size(133, 20);
            this.txttahun.TabIndex = 13;
            this.txttahun.TextChanged += new System.EventHandler(this.txttahun_TextChanged);
            // 
            // cbstudi
            // 
            this.cbstudi.FormattingEnabled = true;
            this.cbstudi.Items.AddRange(new object[] {
            "D3 - Teknik Informatika",
            "D4 - Teknik Informatika"});
            this.cbstudi.Location = new System.Drawing.Point(481, 65);
            this.cbstudi.Name = "cbstudi";
            this.cbstudi.Size = new System.Drawing.Size(133, 21);
            this.cbstudi.TabIndex = 14;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(481, 124);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(133, 20);
            this.txtsemester.TabIndex = 15;
            this.txtsemester.TextChanged += new System.EventHandler(this.txtsemester_TextChanged);
            // 
            // btnpilihmatkul
            // 
            this.btnpilihmatkul.Location = new System.Drawing.Point(497, 169);
            this.btnpilihmatkul.Name = "btnpilihmatkul";
            this.btnpilihmatkul.Size = new System.Drawing.Size(117, 28);
            this.btnpilihmatkul.TabIndex = 16;
            this.btnpilihmatkul.Text = "Pilih Mata Kuliah";
            this.btnpilihmatkul.UseVisualStyleBackColor = true;
            this.btnpilihmatkul.Click += new System.EventHandler(this.btnpilihmatkul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbkurmerdeka);
            this.groupBox1.Controls.Add(this.rbkur2013);
            this.groupBox1.Controls.Add(this.rbkur2006);
            this.groupBox1.Location = new System.Drawing.Point(27, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 121);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurikulum Pilihan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbkur2006
            // 
            this.rbkur2006.AutoSize = true;
            this.rbkur2006.Location = new System.Drawing.Point(7, 20);
            this.rbkur2006.Name = "rbkur2006";
            this.rbkur2006.Size = new System.Drawing.Size(98, 17);
            this.rbkur2006.TabIndex = 0;
            this.rbkur2006.TabStop = true;
            this.rbkur2006.Text = "Kurikulum 2006";
            this.rbkur2006.UseVisualStyleBackColor = true;
            this.rbkur2006.CheckedChanged += new System.EventHandler(this.rbkur2006_CheckedChanged);
            // 
            // rbkur2013
            // 
            this.rbkur2013.AutoSize = true;
            this.rbkur2013.Location = new System.Drawing.Point(7, 44);
            this.rbkur2013.Name = "rbkur2013";
            this.rbkur2013.Size = new System.Drawing.Size(98, 17);
            this.rbkur2013.TabIndex = 1;
            this.rbkur2013.TabStop = true;
            this.rbkur2013.Text = "Kurikulum 2013";
            this.rbkur2013.UseVisualStyleBackColor = true;
            this.rbkur2013.CheckedChanged += new System.EventHandler(this.rbkur2013_CheckedChanged);
            // 
            // rbkurmerdeka
            // 
            this.rbkurmerdeka.AutoSize = true;
            this.rbkurmerdeka.Location = new System.Drawing.Point(7, 68);
            this.rbkurmerdeka.Name = "rbkurmerdeka";
            this.rbkurmerdeka.Size = new System.Drawing.Size(116, 17);
            this.rbkurmerdeka.TabIndex = 2;
            this.rbkurmerdeka.TabStop = true;
            this.rbkurmerdeka.Text = "Kurikulum Merdeka";
            this.rbkurmerdeka.UseVisualStyleBackColor = true;
            this.rbkurmerdeka.CheckedChanged += new System.EventHandler(this.rbkurmerdeka_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbrantaipasok);
            this.groupBox2.Controls.Add(this.cbsistem);
            this.groupBox2.Controls.Add(this.cbjaringan);
            this.groupBox2.Controls.Add(this.cblogistik);
            this.groupBox2.Controls.Add(this.cbpkn);
            this.groupBox2.Controls.Add(this.cbagama);
            this.groupBox2.Controls.Add(this.cbfisika);
            this.groupBox2.Controls.Add(this.cbpemrog4);
            this.groupBox2.Controls.Add(this.cbpemrog3);
            this.groupBox2.Controls.Add(this.cbpemrog2);
            this.groupBox2.Controls.Add(this.cbpemrog1);
            this.groupBox2.Controls.Add(this.cbmtk);
            this.groupBox2.Location = new System.Drawing.Point(317, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 121);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mata Kuliah Pilihan";
            // 
            // cbmtk
            // 
            this.cbmtk.AutoSize = true;
            this.cbmtk.Location = new System.Drawing.Point(7, 20);
            this.cbmtk.Name = "cbmtk";
            this.cbmtk.Size = new System.Drawing.Size(81, 17);
            this.cbmtk.TabIndex = 0;
            this.cbmtk.Text = "Matematika";
            this.cbmtk.UseVisualStyleBackColor = true;
            // 
            // cbpemrog1
            // 
            this.cbpemrog1.AutoSize = true;
            this.cbpemrog1.Location = new System.Drawing.Point(7, 44);
            this.cbpemrog1.Name = "cbpemrog1";
            this.cbpemrog1.Size = new System.Drawing.Size(100, 17);
            this.cbpemrog1.TabIndex = 1;
            this.cbpemrog1.Text = "Pemrograman 1";
            this.cbpemrog1.UseVisualStyleBackColor = true;
            // 
            // cbpemrog2
            // 
            this.cbpemrog2.AutoSize = true;
            this.cbpemrog2.Location = new System.Drawing.Point(7, 68);
            this.cbpemrog2.Name = "cbpemrog2";
            this.cbpemrog2.Size = new System.Drawing.Size(100, 17);
            this.cbpemrog2.TabIndex = 2;
            this.cbpemrog2.Text = "Pemrograman 2";
            this.cbpemrog2.UseVisualStyleBackColor = true;
            // 
            // cbpemrog3
            // 
            this.cbpemrog3.AutoSize = true;
            this.cbpemrog3.Location = new System.Drawing.Point(7, 92);
            this.cbpemrog3.Name = "cbpemrog3";
            this.cbpemrog3.Size = new System.Drawing.Size(100, 17);
            this.cbpemrog3.TabIndex = 3;
            this.cbpemrog3.Text = "Pemrograman 3";
            this.cbpemrog3.UseVisualStyleBackColor = true;
            // 
            // cbpemrog4
            // 
            this.cbpemrog4.AutoSize = true;
            this.cbpemrog4.Location = new System.Drawing.Point(129, 20);
            this.cbpemrog4.Name = "cbpemrog4";
            this.cbpemrog4.Size = new System.Drawing.Size(100, 17);
            this.cbpemrog4.TabIndex = 4;
            this.cbpemrog4.Text = "Pemrograman 4";
            this.cbpemrog4.UseVisualStyleBackColor = true;
            // 
            // cbfisika
            // 
            this.cbfisika.AutoSize = true;
            this.cbfisika.Location = new System.Drawing.Point(129, 44);
            this.cbfisika.Name = "cbfisika";
            this.cbfisika.Size = new System.Drawing.Size(53, 17);
            this.cbfisika.TabIndex = 5;
            this.cbfisika.Text = "Fisika";
            this.cbfisika.UseVisualStyleBackColor = true;
            // 
            // cbagama
            // 
            this.cbagama.AutoSize = true;
            this.cbagama.Location = new System.Drawing.Point(129, 68);
            this.cbagama.Name = "cbagama";
            this.cbagama.Size = new System.Drawing.Size(115, 17);
            this.cbagama.TabIndex = 6;
            this.cbagama.Text = "Pendidikan Agama";
            this.cbagama.UseVisualStyleBackColor = true;
            // 
            // cbpkn
            // 
            this.cbpkn.AutoSize = true;
            this.cbpkn.Location = new System.Drawing.Point(129, 92);
            this.cbpkn.Name = "cbpkn";
            this.cbpkn.Size = new System.Drawing.Size(169, 17);
            this.cbpkn.TabIndex = 7;
            this.cbpkn.Text = "Pendidikan Kewarganegaraan";
            this.cbpkn.UseVisualStyleBackColor = true;
            // 
            // cblogistik
            // 
            this.cblogistik.AutoSize = true;
            this.cblogistik.Location = new System.Drawing.Point(312, 20);
            this.cblogistik.Name = "cblogistik";
            this.cblogistik.Size = new System.Drawing.Size(114, 17);
            this.cblogistik.TabIndex = 8;
            this.cblogistik.Text = "Pengantar Logistik";
            this.cblogistik.UseVisualStyleBackColor = true;
            // 
            // cbjaringan
            // 
            this.cbjaringan.AutoSize = true;
            this.cbjaringan.Location = new System.Drawing.Point(312, 44);
            this.cbjaringan.Name = "cbjaringan";
            this.cbjaringan.Size = new System.Drawing.Size(114, 17);
            this.cbjaringan.TabIndex = 9;
            this.cbjaringan.Text = "Jaringan Komputer";
            this.cbjaringan.UseVisualStyleBackColor = true;
            // 
            // cbsistem
            // 
            this.cbsistem.AutoSize = true;
            this.cbsistem.Location = new System.Drawing.Point(312, 68);
            this.cbsistem.Name = "cbsistem";
            this.cbsistem.Size = new System.Drawing.Size(96, 17);
            this.cbsistem.TabIndex = 10;
            this.cbsistem.Text = "Sistem Operasi";
            this.cbsistem.UseVisualStyleBackColor = true;
            // 
            // cbrantaipasok
            // 
            this.cbrantaipasok.AutoSize = true;
            this.cbrantaipasok.Location = new System.Drawing.Point(312, 92);
            this.cbrantaipasok.Name = "cbrantaipasok";
            this.cbrantaipasok.Size = new System.Drawing.Size(148, 17);
            this.cbrantaipasok.TabIndex = 11;
            this.cbrantaipasok.Text = "Manajemen Rantai Pasok";
            this.cbrantaipasok.UseVisualStyleBackColor = true;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(288, 402);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.btnsimpan.TabIndex = 19;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(381, 402);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(75, 23);
            this.btnbatal.TabIndex = 20;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnpilihmatkul);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.cbstudi);
            this.Controls.Add(this.txttahun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.rbperempuan);
            this.Controls.Add(this.rblaki);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtnim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pilihan Matkul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.RadioButton rblaki;
        private System.Windows.Forms.RadioButton rbperempuan;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttahun;
        private System.Windows.Forms.ComboBox cbstudi;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Button btnpilihmatkul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbkurmerdeka;
        private System.Windows.Forms.RadioButton rbkur2013;
        private System.Windows.Forms.RadioButton rbkur2006;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbrantaipasok;
        private System.Windows.Forms.CheckBox cbsistem;
        private System.Windows.Forms.CheckBox cbjaringan;
        private System.Windows.Forms.CheckBox cblogistik;
        private System.Windows.Forms.CheckBox cbpkn;
        private System.Windows.Forms.CheckBox cbagama;
        private System.Windows.Forms.CheckBox cbfisika;
        private System.Windows.Forms.CheckBox cbpemrog4;
        private System.Windows.Forms.CheckBox cbpemrog3;
        private System.Windows.Forms.CheckBox cbpemrog2;
        private System.Windows.Forms.CheckBox cbpemrog1;
        private System.Windows.Forms.CheckBox cbmtk;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

