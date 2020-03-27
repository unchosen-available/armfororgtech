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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Ведомость". При необходимости она может быть перемещена или удалена.
            this.ведомостьTableAdapter.Fill(this.baseDataSet.Ведомость);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                textBox1.Focus();
                this.baseDataSet.Ведомость.AddВедомостьRow(this.baseDataSet.Ведомость.NewВедомостьRow());
                ведомостьBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ведомостьBindingSource.ResetBindings(false);
            }
         }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
           textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            ведомостьBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ведомостьBindingSource.EndEdit();
                ведомостьTableAdapter.Update(this.baseDataSet.Ведомость);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ведомостьBindingSource.ResetBindings(false);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (MessageBox.Show("Вы точно хотите удалить эту запись? ", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ведомостьBindingSource.RemoveCurrent();
        }
    }
}
