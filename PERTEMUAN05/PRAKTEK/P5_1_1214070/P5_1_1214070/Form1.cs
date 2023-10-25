using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_1214070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Hello Rel";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
