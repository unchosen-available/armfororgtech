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
    public partial class FormEditBD : Form
    {
        public FormEditBD()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormGL FormEditBD = new FormGL();
            Hide();
            FormEditBD.Show();
        }

        private void FormEditBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormEditBD_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2();
            Form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 Form = new Form3();
            Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
