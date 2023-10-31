using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ButtonTampilkan_Click(object sender, EventArgs e)
        {
            string jadwal = "";
            string kelas = "";

            if (!rb_1.Checked && !rb_2.Checked && !rb_3.Checked && !rb_4.Checked)
            {
                MessageBox.Show("Pilih salah satu jadwal.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cb_Biola.Checked && !cb_Gitar.Checked && !cb_Saxophone.Checked && !cb_Konduktor.Checked && !cb_Piano.Checked && !cb_Drum.Checked && !cb_Vokal.Checked && !cb_Komposer.Checked)
            {
                MessageBox.Show("Pilih setidaknya satu kelas.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(cb_jekel.Text) || string.IsNullOrWhiteSpace(tgl_lahir.Text))
            {
                MessageBox.Show("Isi semua informasi pribadi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rb_1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (rb_2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (rb_3.Checked)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (rb_4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }

            if (cb_Biola.Checked)
            {
                kelas += "Biola, ";
            }
            if (cb_Gitar.Checked)
            {
                kelas += "Gitar, ";
            }
            if (cb_Saxophone.Checked)
            {
                kelas += "Saxophone, ";
            }
            if (cb_Konduktor.Checked)
            {
                kelas += "Konduktor, ";
            }
            if (cb_Piano.Checked)
            {
                kelas += "Piano, ";
            }
            if (cb_Drum.Checked)
            {
                kelas += "Drum, ";
            }
            if (cb_Vokal.Checked)
            {
                kelas += "Vokal, ";
            }
            if (cb_Komposer.Checked)
            {
                kelas += "Komposer, ";
            }

            // Menghilangkan tanda koma terakhir jika ada.
            if (!string.IsNullOrEmpty(kelas) && kelas.EndsWith(" "))
            {
                kelas = kelas.Substring(0, kelas.Length - 1);
            }

            MessageBox.Show(
                "Nama: " + txtNama.Text +
                "\nJenis Kelamin : " + cb_jekel.Text +
                "\nTanggal Lahir : " + tgl_lahir.Text +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal : " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
