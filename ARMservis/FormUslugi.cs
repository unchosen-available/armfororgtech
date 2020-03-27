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
    public partial class FormUslugi : Form
    {
        public FormUslugi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGL FormUslugi = new FormGL();
            Hide();
            FormUslugi.Show();
        }

        private void FormUslugi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormUslugi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.baseDataSet.Услуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDataSet.Услуги.AddУслугиRow(this.baseDataSet.Услуги.NewУслугиRow());
                услугиBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                услугиBindingSource.ResetBindings(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                услугиBindingSource.EndEdit();
                услугиTableAdapter.Update(this.baseDataSet.Услуги);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                услугиBindingSource.ResetBindings(false);
            }
        }
    }
}
