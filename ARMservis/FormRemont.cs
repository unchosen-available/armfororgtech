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
    public partial class FormRemont : Form
    {
        public FormRemont()
        {
            InitializeComponent();
        }

        private void FormRemont_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.baseDataSet.Ремонт);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormGL FormRemont = new FormGL();
            Hide();
            FormRemont.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost FormRemont = new FormVedomost();
            Hide();
            FormRemont.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormWorkAdd FormRemont = new FormWorkAdd();
            Hide();
            FormRemont.ShowDialog();
        }

        private void FormRemont_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
