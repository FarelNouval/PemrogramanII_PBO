using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ats_1214070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 251);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void btnpilihmatkul_Click(object sender, EventArgs e)
        {
            string MessageError = "";

            if (string.IsNullOrEmpty(txtnim.Text))
            {
                MessageError += "NIM belum di isi. \n";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtnim.Text, @"^\d+$"))
            {
                MessageError += "NIM salah. \n";
            }

            if (string.IsNullOrEmpty(txtnama.Text))
            {
                MessageError += "Nama belum di isi. \n";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtnama.Text, "^[a-zA-Z]+$"))
            {
                MessageError += "Nama salah. \n";
            }

            if (rblaki.Checked == false && rbperempuan.Checked == false)
            {
                MessageError += "Jenis kelamin belum di isi. \n";
            }

            if (string.IsNullOrEmpty(txtalamat.Text))
            {
                MessageError += "Alamat belum di isi. \n";
            }

            if (string.IsNullOrEmpty(cbstudi.Text))
            {
                MessageError += "Program studi belum di isi. \n";
            }

            if (string.IsNullOrEmpty(txttahun.Text))
            {
                MessageError += "Tahun akademik belum di isi. \n";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txttahun.Text, @"^\d{4}/\d{4}$"))
            {
                MessageError += "Format tahun akademik salah. \n";
            }

            if (string.IsNullOrEmpty(txtsemester.Text))
            {
                MessageError += "Semester belum di isi. \n";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtsemester.Text, @"^[1-8]{1}$"))
            {
                MessageError += "Semester salah. \n";
            }

            if (!string.IsNullOrEmpty(MessageError))
            {
                MessageBox.Show(MessageError, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // lakukan proses pemilihan mata kuliah disini
            }
            if (string.IsNullOrEmpty(MessageError))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Sumbmit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                this.Size = new Size(816, 490);
            }


        }

        private void txtnim_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnim.Text))
            {
                errorProvider1.SetError(txtnim, "NIM belum di isi.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtnim.Text, @"^\d+$"))
            {
                errorProvider1.SetError(txtnim, "NIM wajib angka.");
            }
            else
            {
                errorProvider1.SetError(txtnim, "");
            }
        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnama.Text))
            {
                errorProvider1.SetError(txtnama, "Nama belum di isi.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtnama.Text, "^[a-zA-Z]+$"))
            {
                errorProvider1.SetError(txtnama, "Nama wajib huruf.");
            }
            else
            {
                errorProvider1.SetError(txtnama, "");
            }
        }

        private void txttahun_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttahun.Text))
            {
                errorProvider1.SetError(txttahun, "Tahun akademik belum di isi.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txttahun.Text, @"^\d{4}/\d{4}$"))
            {
                errorProvider1.SetError(txttahun, "Contoh format yang benar (2019/2020).");
            }
            else
            {
                errorProvider1.SetError(txttahun, "");
            }
        }

        private void txtsemester_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsemester.Text))
            {
                errorProvider1.SetError(txtsemester, "Semester belum di isi.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtsemester.Text, @"^[1-8]{1}$"))
            {
                errorProvider1.SetError(txtsemester, "Semester salah");
            }
            else
            {
                errorProvider1.SetError(txtsemester, "");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbkur2006_CheckedChanged(object sender, EventArgs e)
        {
            
                groupBox2.Enabled = rbkur2006.Checked;

                // Reset properti checkbox di groupBox2
                cblogistik.Enabled = true;
                cbrantaipasok.Enabled = true;

                // Nonaktifkan checkbox yang tidak sesuai dengan rbkur2006
                cblogistik.Enabled = !rbkur2006.Checked;
                cbrantaipasok.Enabled = !rbkur2006.Checked;
                cblogistik.Checked = false;
                cbrantaipasok.Checked = false;
            
        }

        private void rbkur2013_CheckedChanged(object sender, EventArgs e)
        {
            
                groupBox2.Enabled = rbkur2013.Checked;

                // Reset properti checkbox di groupBox2
                cbpkn.Enabled = true;
                cbfisika.Enabled = true;

                // Nonaktifkan checkbox yang tidak sesuai dengan rbkur2013
                cbpkn.Enabled = !rbkur2013.Checked;
                cbfisika.Enabled = !rbkur2013.Checked;
                cbpkn.Checked = false;
                cbfisika.Checked = false;
            
        }

        private void rbkurmerdeka_CheckedChanged(object sender, EventArgs e)
        {
            
                groupBox2.Enabled = rbkurmerdeka.Checked;

                // Reset properti checkbox di groupBox2
                cbmtk.Enabled = true;
                cbfisika.Enabled = true;
                cblogistik.Enabled = true;

                // Nonaktifkan checkbox yang tidak sesuai dengan rbkurmerdeka
                cbmtk.Enabled = !rbkurmerdeka.Checked;
                cbfisika.Enabled = !rbkurmerdeka.Checked;
                cblogistik.Enabled = !rbkurmerdeka.Checked;
                cbmtk.Checked = false;
                cbfisika.Checked = false;
                cblogistik.Checked = false;
            
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            string kurikulum = "";
            string matkul = "";
            string jekel = "";

            if (!rbkur2006.Checked && !rbkur2013.Checked && !rbkurmerdeka.Checked)
            {
                MessageBox.Show("Kurikulum harus di isi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cbmtk.Checked && !cbagama.Checked && !cbfisika.Checked && !cbjaringan.Checked && !cblogistik.Checked && !cbpemrog1.Checked && !cbpemrog2.Checked && !cbpemrog3.Checked && !cbpemrog4.Checked && !cbpkn.Checked && !cbrantaipasok.Checked && !cbsistem.Checked)
            {
                MessageBox.Show("Mata Kuliah harus di isi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbkur2006.Checked)
            {
                kurikulum = "Kurikulum 2006";
            }
            else if (rbkur2013.Checked)
            {
                kurikulum = "Kurikulum 2013";
            }
            else if (rbkurmerdeka.Checked)
            {
                kurikulum = "Kurikulum Merdeka";
            }

            if (cbmtk.Checked)
            {
                matkul += "Matematika, ";
            }
            if (cbpemrog1.Checked)
            {
                matkul += "Pemrograman 1, ";
            }
            if (cbpemrog2.Checked)
            {
                matkul += "Pemrograman 2, ";
            }
            if (cbpemrog3.Checked)
            {
                matkul += "Pemrograman 3, ";
            }
            if (cbpemrog4.Checked)
            {
                matkul += "Pemrograman4, ";
            }
            if (cbfisika.Checked)
            {
                matkul += "Fisika, ";
            }
            if (cbagama.Checked)
            {
                matkul += "Pendidikan Agama, ";
            }
            if (cbpkn.Checked)
            {
                matkul += "Pendidikan Kewarganegaraan, ";
            }
            if (cblogistik.Checked)
            {
                matkul += "Pengantar Logistik, ";
            }
            if (cbjaringan.Checked)
            {
                matkul += "Jaringan Komputer, ";
            }
            if (cbsistem.Checked)
            {
                matkul += "Sistem Operasi, ";
            }
            if (cbrantaipasok.Checked)
            {
                matkul += "Manajemen Rantai Pasok, ";
            }

            if (rblaki.Checked)
            {
                jekel = "Laki - Laki";
            }
            else if (rbperempuan.Checked)
            {
                jekel = "Perempuan";
            }

            MessageBox.Show(
                "NIM: " + txtnim.Text +
                "\nNama: " + txtnama.Text +
                "\nJenis Kelamin: " + jekel +
                "\nAlamat: " + txtalamat.Text +
                "\nProgram Studi: " + cbstudi.Text +
                "\nTahun Akademik: " + txttahun.Text +
                "\nSemester: " + txtsemester.Text +
                "\n=======================================" +
                "\nKurikulum: " + kurikulum +
                "\nMata Kuliah: " + matkul,
                "Informasi Data Submit",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txtalamat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtalamat.Text))
            {
                errorProvider1.SetError(txtalamat, "Alamat belum di isi.");
            }
            else
            {
                errorProvider1.SetError(txtalamat, "");
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                
                    ((TextBox)control).Text = string.Empty;
                
                else if (control is System.Windows.Forms.RadioButton)
                
                    ((System.Windows.Forms.RadioButton)control).Checked = false;
                
                else if (control is System.Windows.Forms.CheckBox)

                    ((System.Windows.Forms.CheckBox)control).Checked = false;
                else if (control is ComboBox)

                    ((ComboBox)control).SelectedIndex = -1;

                rbkur2006.Checked = false;
                rbkur2013.Checked = false;
                rbkurmerdeka.Checked = false;
                cbmtk.Checked = false;
                cbagama.Checked = false;
                cbfisika.Checked = false;
                cbjaringan.Checked = false;
                cblogistik.Checked = false;
                cbpemrog1.Checked = false;
                cbpemrog2.Checked = false;
                cbpemrog3.Checked = false;
                cbpemrog4.Checked = false;
                cbpkn.Checked = false;
                cbrantaipasok.Checked = false;
                cbsistem.Checked = false;
               

                
            }
            this.Size = new Size(816, 251);
        }
    }
}
