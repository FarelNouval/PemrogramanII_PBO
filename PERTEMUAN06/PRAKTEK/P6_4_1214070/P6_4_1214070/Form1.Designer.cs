namespace P6_4_1214070
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.tgl_lahir = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNohp = new System.Windows.Forms.TextBox();
            this.rb_Regular = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Super = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Php = new System.Windows.Forms.CheckBox();
            this.cb_Java = new System.Windows.Forms.CheckBox();
            this.cb_C = new System.Windows.Forms.CheckBox();
            this.cb_Python = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCode1 = new System.Windows.Forms.TextBox();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENDAFTARAN BOOTCAMP WITH FAREL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "No Handphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tanggal Lahir";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.comboBox1.Location = new System.Drawing.Point(398, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "-- Jenis Kelamin --";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(398, 81);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(147, 20);
            this.txtNama.TabIndex = 8;
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.Location = new System.Drawing.Point(398, 117);
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.Size = new System.Drawing.Size(200, 20);
            this.tgl_lahir.TabIndex = 9;
            this.tgl_lahir.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(398, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtNohp
            // 
            this.txtNohp.Location = new System.Drawing.Point(398, 237);
            this.txtNohp.Name = "txtNohp";
            this.txtNohp.Size = new System.Drawing.Size(147, 20);
            this.txtNohp.TabIndex = 12;
            this.txtNohp.Leave += new System.EventHandler(this.txtNohp_Leave);
            // 
            // rb_Regular
            // 
            this.rb_Regular.AutoSize = true;
            this.rb_Regular.Location = new System.Drawing.Point(16, 29);
            this.rb_Regular.Name = "rb_Regular";
            this.rb_Regular.Size = new System.Drawing.Size(62, 17);
            this.rb_Regular.TabIndex = 13;
            this.rb_Regular.TabStop = true;
            this.rb_Regular.Text = "Reguler";
            this.rb_Regular.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Super);
            this.groupBox1.Controls.Add(this.rb_Regular);
            this.groupBox1.Location = new System.Drawing.Point(192, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 78);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PIlihan Kelas";
            // 
            // rb_Super
            // 
            this.rb_Super.AutoSize = true;
            this.rb_Super.Location = new System.Drawing.Point(16, 52);
            this.rb_Super.Name = "rb_Super";
            this.rb_Super.Size = new System.Drawing.Size(53, 17);
            this.rb_Super.TabIndex = 14;
            this.rb_Super.TabStop = true;
            this.rb_Super.Text = "Super";
            this.rb_Super.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Php);
            this.groupBox2.Controls.Add(this.cb_Java);
            this.groupBox2.Controls.Add(this.cb_C);
            this.groupBox2.Controls.Add(this.cb_Python);
            this.groupBox2.Location = new System.Drawing.Point(385, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 78);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Bahasa";
            // 
            // cb_Php
            // 
            this.cb_Php.AutoSize = true;
            this.cb_Php.Location = new System.Drawing.Point(71, 52);
            this.cb_Php.Name = "cb_Php";
            this.cb_Php.Size = new System.Drawing.Size(48, 17);
            this.cb_Php.TabIndex = 18;
            this.cb_Php.Text = "PHP";
            this.cb_Php.UseVisualStyleBackColor = true;
            // 
            // cb_Java
            // 
            this.cb_Java.AutoSize = true;
            this.cb_Java.Location = new System.Drawing.Point(71, 29);
            this.cb_Java.Name = "cb_Java";
            this.cb_Java.Size = new System.Drawing.Size(49, 17);
            this.cb_Java.TabIndex = 16;
            this.cb_Java.Text = "Java";
            this.cb_Java.UseVisualStyleBackColor = true;
            // 
            // cb_C
            // 
            this.cb_C.AutoSize = true;
            this.cb_C.Location = new System.Drawing.Point(6, 52);
            this.cb_C.Name = "cb_C";
            this.cb_C.Size = new System.Drawing.Size(40, 17);
            this.cb_C.TabIndex = 17;
            this.cb_C.Text = "C#";
            this.cb_C.UseVisualStyleBackColor = true;
            // 
            // cb_Python
            // 
            this.cb_Python.AutoSize = true;
            this.cb_Python.Location = new System.Drawing.Point(6, 29);
            this.cb_Python.Name = "cb_Python";
            this.cb_Python.Size = new System.Drawing.Size(59, 17);
            this.cb_Python.TabIndex = 16;
            this.cb_Python.Text = "Python";
            this.cb_Python.UseVisualStyleBackColor = true;
            this.cb_Python.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Code 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(201, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Code 2";
            // 
            // txtCode1
            // 
            this.txtCode1.Location = new System.Drawing.Point(398, 490);
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.Size = new System.Drawing.Size(147, 20);
            this.txtCode1.TabIndex = 18;
            this.txtCode1.TextChanged += new System.EventHandler(this.txtCode1_TextChanged);
            this.txtCode1.Leave += new System.EventHandler(this.txtCode1_Leave);
            // 
            // txtCode2
            // 
            this.txtCode2.Location = new System.Drawing.Point(398, 532);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(147, 20);
            this.txtCode2.TabIndex = 19;
            this.txtCode2.TextChanged += new System.EventHandler(this.txtCode2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(297, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "MASUKKAN KODE PENDAFTARAN";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(240, 594);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 36);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(447, 594);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 36);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCode2);
            this.Controls.Add(this.txtCode1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNohp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.tgl_lahir);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BOOTCAMP WITH FAREL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.DateTimePicker tgl_lahir;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNohp;
        private System.Windows.Forms.RadioButton rb_Regular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Super;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_Python;
        private System.Windows.Forms.CheckBox cb_Php;
        private System.Windows.Forms.CheckBox cb_Java;
        private System.Windows.Forms.CheckBox cb_C;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCode1;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

