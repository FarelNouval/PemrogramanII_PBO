namespace P5_4_1214070
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cb_jekel = new System.Windows.Forms.ComboBox();
            this.tgl_lahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Komposer = new System.Windows.Forms.CheckBox();
            this.cb_Vokal = new System.Windows.Forms.CheckBox();
            this.cb_Drum = new System.Windows.Forms.CheckBox();
            this.cb_Piano = new System.Windows.Forms.CheckBox();
            this.cb_Konduktor = new System.Windows.Forms.CheckBox();
            this.cb_Saxophone = new System.Windows.Forms.CheckBox();
            this.cb_Gitar = new System.Windows.Forms.CheckBox();
            this.cb_Biola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.ButtonTampilkan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(367, 51);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(213, 20);
            this.txtNama.TabIndex = 4;
            // 
            // cb_jekel
            // 
            this.cb_jekel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_jekel.FormattingEnabled = true;
            this.cb_jekel.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cb_jekel.Location = new System.Drawing.Point(367, 84);
            this.cb_jekel.Name = "cb_jekel";
            this.cb_jekel.Size = new System.Drawing.Size(124, 24);
            this.cb_jekel.TabIndex = 5;
            this.cb_jekel.Text = "--Pilih Jenis Kelamin--";
            this.cb_jekel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.Location = new System.Drawing.Point(367, 122);
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.Size = new System.Drawing.Size(200, 20);
            this.tgl_lahir.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Komposer);
            this.groupBox1.Controls.Add(this.cb_Vokal);
            this.groupBox1.Controls.Add(this.cb_Drum);
            this.groupBox1.Controls.Add(this.cb_Piano);
            this.groupBox1.Controls.Add(this.cb_Konduktor);
            this.groupBox1.Controls.Add(this.cb_Saxophone);
            this.groupBox1.Controls.Add(this.cb_Gitar);
            this.groupBox1.Controls.Add(this.cb_Biola);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // cb_Komposer
            // 
            this.cb_Komposer.AutoSize = true;
            this.cb_Komposer.Location = new System.Drawing.Point(160, 144);
            this.cb_Komposer.Name = "cb_Komposer";
            this.cb_Komposer.Size = new System.Drawing.Size(81, 17);
            this.cb_Komposer.TabIndex = 14;
            this.cb_Komposer.Text = "Komposer";
            this.cb_Komposer.UseVisualStyleBackColor = true;
            // 
            // cb_Vokal
            // 
            this.cb_Vokal.AutoSize = true;
            this.cb_Vokal.Location = new System.Drawing.Point(160, 106);
            this.cb_Vokal.Name = "cb_Vokal";
            this.cb_Vokal.Size = new System.Drawing.Size(58, 17);
            this.cb_Vokal.TabIndex = 13;
            this.cb_Vokal.Text = "Vokal";
            this.cb_Vokal.UseVisualStyleBackColor = true;
            // 
            // cb_Drum
            // 
            this.cb_Drum.AutoSize = true;
            this.cb_Drum.Location = new System.Drawing.Point(160, 71);
            this.cb_Drum.Name = "cb_Drum";
            this.cb_Drum.Size = new System.Drawing.Size(55, 17);
            this.cb_Drum.TabIndex = 9;
            this.cb_Drum.Text = "Drum";
            this.cb_Drum.UseVisualStyleBackColor = true;
            // 
            // cb_Piano
            // 
            this.cb_Piano.AutoSize = true;
            this.cb_Piano.Location = new System.Drawing.Point(160, 37);
            this.cb_Piano.Name = "cb_Piano";
            this.cb_Piano.Size = new System.Drawing.Size(58, 17);
            this.cb_Piano.TabIndex = 9;
            this.cb_Piano.Text = "Piano";
            this.cb_Piano.UseVisualStyleBackColor = true;
            // 
            // cb_Konduktor
            // 
            this.cb_Konduktor.AutoSize = true;
            this.cb_Konduktor.Location = new System.Drawing.Point(23, 145);
            this.cb_Konduktor.Name = "cb_Konduktor";
            this.cb_Konduktor.Size = new System.Drawing.Size(84, 17);
            this.cb_Konduktor.TabIndex = 9;
            this.cb_Konduktor.Text = "Konduktor";
            this.cb_Konduktor.UseVisualStyleBackColor = true;
            // 
            // cb_Saxophone
            // 
            this.cb_Saxophone.AutoSize = true;
            this.cb_Saxophone.Location = new System.Drawing.Point(23, 107);
            this.cb_Saxophone.Name = "cb_Saxophone";
            this.cb_Saxophone.Size = new System.Drawing.Size(89, 17);
            this.cb_Saxophone.TabIndex = 12;
            this.cb_Saxophone.Text = "Saxophone";
            this.cb_Saxophone.UseVisualStyleBackColor = true;
            // 
            // cb_Gitar
            // 
            this.cb_Gitar.AutoSize = true;
            this.cb_Gitar.Location = new System.Drawing.Point(23, 72);
            this.cb_Gitar.Name = "cb_Gitar";
            this.cb_Gitar.Size = new System.Drawing.Size(53, 17);
            this.cb_Gitar.TabIndex = 9;
            this.cb_Gitar.Text = "Gitar";
            this.cb_Gitar.UseVisualStyleBackColor = true;
            this.cb_Gitar.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cb_Biola
            // 
            this.cb_Biola.AutoSize = true;
            this.cb_Biola.Location = new System.Drawing.Point(23, 37);
            this.cb_Biola.Name = "cb_Biola";
            this.cb_Biola.Size = new System.Drawing.Size(54, 17);
            this.cb_Biola.TabIndex = 11;
            this.cb_Biola.Text = "Biola";
            this.cb_Biola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_4);
            this.groupBox2.Controls.Add(this.rb_3);
            this.groupBox2.Controls.Add(this.rb_2);
            this.groupBox2.Controls.Add(this.rb_1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(437, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 197);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Location = new System.Drawing.Point(25, 143);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(150, 17);
            this.rb_4.TabIndex = 10;
            this.rb_4.TabStop = true;
            this.rb_4.Text = "Minggu, 13.00 - 17.00";
            this.rb_4.UseVisualStyleBackColor = true;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(25, 106);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(198, 17);
            this.rb_3.TabIndex = 9;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rb_3.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(25, 71);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(195, 17);
            this.rb_2.TabIndex = 1;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(25, 37);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(186, 17);
            this.rb_1.TabIndex = 0;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Senin && Rabu, 14.00 - 16.00";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // ButtonTampilkan
            // 
            this.ButtonTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonTampilkan.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTampilkan.Location = new System.Drawing.Point(299, 403);
            this.ButtonTampilkan.Name = "ButtonTampilkan";
            this.ButtonTampilkan.Size = new System.Drawing.Size(75, 23);
            this.ButtonTampilkan.TabIndex = 9;
            this.ButtonTampilkan.Text = "Tampilkan";
            this.ButtonTampilkan.UseVisualStyleBackColor = false;
            this.ButtonTampilkan.Click += new System.EventHandler(this.ButtonTampilkan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(437, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Selesai";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonTampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tgl_lahir);
            this.Controls.Add(this.cb_jekel);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ASTRA MUSIC SCHOOL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cb_jekel;
        private System.Windows.Forms.DateTimePicker tgl_lahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_Biola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_4;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.CheckBox cb_Gitar;
        private System.Windows.Forms.CheckBox cb_Komposer;
        private System.Windows.Forms.CheckBox cb_Vokal;
        private System.Windows.Forms.CheckBox cb_Drum;
        private System.Windows.Forms.CheckBox cb_Piano;
        private System.Windows.Forms.CheckBox cb_Konduktor;
        private System.Windows.Forms.CheckBox cb_Saxophone;
        private System.Windows.Forms.Button ButtonTampilkan;
        private System.Windows.Forms.Button button1;
    }
}

