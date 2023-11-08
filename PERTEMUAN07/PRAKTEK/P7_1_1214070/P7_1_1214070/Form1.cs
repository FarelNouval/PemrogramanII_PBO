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

namespace P7_1_1214070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(356, 217);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtnama1.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }

            if (string.IsNullOrWhiteSpace(txtprodi2.Text))
            {
                errorMessage += "Prodi belum diisi\n";
            }

            if (string.IsNullOrWhiteSpace(txtkelas3.Text))
            {
                errorMessage += "Kelas belum diisi\n";
            }

            else if (!Regex.IsMatch(txtprodi2.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Sumbmit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                this.Size = new Size(356, 487);
            }


            else
            {
                MessageBox.Show(
                    errorMessage,
                   "Informasi Data Sumbmit",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning
                   );
            }

        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSenin.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTravelling.Enabled = false; cbTravelling.Checked = false;
                cbTidur.Enabled = true; cbTidur.Checked = false;
            }
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinggu.Checked)
            {
                cbKuliah.Enabled = false;
                cbTravelling.Enabled = true;
                cbTidur.Enabled = true;
            }

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // textBoxNama.Text = null;
            //textBoxProdi.Text = null;
            //textBoxKelas.Text = null;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)

                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)

                    ((RadioButton)control).Checked = false;
                else if (control is RadioButton)

                    ((RadioButton)control).Checked = false;
                /*else if (control is ComboBox)

                        ((ComboBox)control).SelectedIndex = -1;*/
            }
            this.Size = new Size(356, 217);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string hari = "";
            string kegiatan = "";

            if (rbSenin.Checked)
            {
                hari = "Senin";
            }
            else if (rbMinggu.Checked)
            {
                hari = "Minggu";
            }

            if (cbKuliah.Checked)
            {
                kegiatan += "Kuliah, ";
            }
            if (cbTravelling.Checked)
            {
                kegiatan += "Travelling, ";
            }
            if (cbTidur.Checked)
            {
                kegiatan += "Tidur, ";
            }

            MessageBox.Show(
                "Nama: " + txtnama1.Text +
                "\nProdi : " + txtprodi2.Text +
                "\nKelas : " + txtkelas3.Text +
                "\nPilihan Hari : " + hari +
                "\nPilihan Kegiatan : " + kegiatan,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
