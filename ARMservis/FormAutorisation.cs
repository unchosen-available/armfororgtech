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
    public partial class FormAutorisation : Form
    {
        public FormAutorisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "admin") & (textBox2.Text == "123"))
            {
                FormGL FormAutorisation = new FormGL();
                Hide();
                FormAutorisation.Show();
            }
            else MessageBox.Show("Введен неверный пароль. Попробуйте еще раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAutorisation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
