using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P6_4_1214070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            //VALIDASI TEXTBOX NAMA
            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, " Nama tidak boleh kosong dong!");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else
            {
                if ((txtNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtNama, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "");
                }
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //VALIDASI TEXTBOX EMAIL
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, " Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                // REGEX VALIDATOR
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah!\nContoh: dadang@gmail.com");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtNohp_Leave(object sender, EventArgs e)
        {
            //VALIDASI TEXTBOX EMAIL
            if (txtNohp.Text == "")
            {
                //REQUIRED VALIDATOR
                epWarning.SetError(txtNohp, "No Handphone tidak boleh kosong!");
                epWrong.SetError(txtNohp, "");
                epCorrect.SetError(txtNohp, "");
            }
            else
            {
                if ((txtNohp.Text).All(Char.IsNumber))
                {
                    // Validasi panjang teks (10 karakter)
                    if (txtNohp.Text.Length >= 10) 
                    {
                        epWarning.SetError(txtNohp, "");
                        epWrong.SetError(txtNohp, "");
                        epCorrect.SetError(txtNohp, "Betul!");
                    }
                    else
                    {
                        //LENGTH  VALIDATOR
                        epWrong.SetError(txtNohp, "No Handphone harus memiliki panjang 10 karakter.");
                        epWarning.SetError(txtNohp, "");
                        epCorrect.SetError(txtNohp, "");
                    }
                }
                else
                {
                    epWrong.SetError(txtNohp, "Inputan hanya boleh angka!");
                    epWarning.SetError(txtNohp, "");
                    epCorrect.SetError(txtNohp, "");
                }
            }
        }

        private void txtCode1_Leave(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isValid = true; // Menandai apakah semua validasi berhasil

            string kelas = "";
            string bahasa = "";
            string errorMessage = "";

            // VALIDASI UNTUK RADIO BUTTON
            if (rb_Regular.Checked == false && rb_Super.Checked == false)
            {
                // REQUIRED VALIDATOR
                MessageBox.Show("Pilih salah satu kelas (Regular atau Super).", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            if (rb_Regular.Checked)
            {
                kelas = "Regular";
            }
            else if (rb_Super.Checked)
            {
                kelas = "Super";
            }

            // VALIDASI CHECKBOX
            if (!(cb_Python.Checked || cb_Java.Checked || cb_C.Checked || cb_Php.Checked))
            {
                // REQUIRED VALIDATOR
                MessageBox.Show("Pilih setidaknya satu bahasa pemrograman.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            if (cb_Python.Checked)
            {
                bahasa += "Python, ";
            }
            if (cb_C.Checked)
            {
                bahasa += "C#, ";
            }
            if (cb_Java.Checked)
            {
                bahasa += "Java, ";
            }
            if (cb_Php.Checked)
            {
                bahasa += "PHP, ";
            }

            // VALIDASI 
            if (string.IsNullOrWhiteSpace(txtNama.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || 
                string.IsNullOrWhiteSpace(comboBox1.Text) || 
                string.IsNullOrWhiteSpace(txtNohp.Text) || 
                string.IsNullOrWhiteSpace(txtCode1.Text) ||
                string.IsNullOrWhiteSpace(txtCode2.Text))
            {
                // REQUIRED VALIDATOR
                MessageBox.Show("Ada yang belum di isi!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            // Validasi Nama
            else if (!IsValidName(txtNama.Text))
            {
                isValid = false;
                MessageBox.Show("Input nama dengan benar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // VALIDASI EMAIL 
            else if (!Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                errorMessage += "salah\n";
            }


            // Mengecek semua validasi sebelum menampilkan pesan informasi
            if (isValid)
            {
                MessageBox.Show(
                    "Nama: " + txtNama.Text +
                    "\nTanggal Lahir : " + tgl_lahir.Text +
                    "\nJenis Kelamin : " + comboBox1.Text +
                    "\nEmail : " + txtEmail.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Bahasa : " + bahasa +
                    "\nCode Pendaftaran 1 : " + txtCode1.Text +
                    "\nCode Pendaftaran 2 : " + txtCode2.Text,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // VALIDASI NAMA
        private bool IsValidName(string name)
        {
            return !string.IsNullOrEmpty(name) && name.All(char.IsLetter);
        }
        private bool IsValidEmail(string name)
        {
            return !string.IsNullOrEmpty(name) && name.All(char.IsLetter);
        }


        private void ResetForm()
        {
            txtCode1.Clear();
        }

        private void txtCode1_TextChanged(object sender, EventArgs e)
        {
            // VALIDASI  TEXT TIDAK BOLEH KOSONG
            if (txtCode1.Text == "")
            {
                //REQUIRED VALIDATOR
                epWarning.SetError(txtCode1, "Code 1 tidak boleh kosong!");
                epWrong.SetError(txtCode1, "");
                epCorrect.SetError(txtCode1, "");
            }
            else
            {
                // VALIDASI UPPER CASE TEXTBOX
                if ((txtCode1.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(txtCode1, "");
                    epWrong.SetError(txtCode1, "");
                    epCorrect.SetError(txtCode1, "Betul!");
                }
                else if ((txtCode1.Text).Any(Char.IsLower))
                {
                    epWarning.SetError(txtCode1, "");
                    epWrong.SetError(txtCode1, "Harus menggunakan huruf kapital!");
                    epCorrect.SetError(txtCode1, "");
                }
            }
        }

        private void txtCode2_TextChanged(object sender, EventArgs e)
        {
            if (txtCode2.Text == "")
            {
                //REQUIRED VALIDATOR
                epWarning.SetError(txtCode2, "Code 2 tidak boleh kosong!");
                epWrong.SetError(txtCode2, "");
                epCorrect.SetError(txtCode2, "");
            }
            else
            {
                // VALIDASI LOWER CASE TEXTBOX
                if ((txtCode2.Text).Any(Char.IsUpper))
                {
                    epWarning.SetError(txtCode2, "");
                    epWrong.SetError(txtCode2, "Tidak boleh menggunakan huruf kapital!");
                    epCorrect.SetError(txtCode2, "");
                }
                else if ((txtCode2.Text).All(Char.IsLower))
                {
                    epWarning.SetError(txtCode2, "");
                    epWrong.SetError(txtCode2, "");
                    epCorrect.SetError(txtCode2, "Betul!");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
