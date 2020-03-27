using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMservis
{
    public partial class FormGL : Form
    {
        public FormGL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClients secondForm = new FormClients();
            Hide();
            secondForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRemont secondForm = new FormRemont();
            Hide();
            secondForm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAddItems secondForm = new FormAddItems();
            Hide();
            secondForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormUslugi secondForm = new FormUslugi();
            Hide();
            secondForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormEditBD secondForm = new FormEditBD();
            Hide();
            secondForm.ShowDialog();
        }

        private void FormGL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormAutorisation FormGL = new FormAutorisation();
            Hide();
            FormGL.Show();
        }
    }
}
