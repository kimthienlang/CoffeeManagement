using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile accountProfile = new fAccountProfile();
            accountProfile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAdmin adminWindow = new fAdmin();
            this.Hide();
            adminWindow.ShowDialog();
            this.Show();
        }
    }
}
