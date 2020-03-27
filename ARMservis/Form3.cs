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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.baseDataSet.Ремонт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                textBox1.Focus();
                this.baseDataSet.Ремонт.AddРемонтRow(this.baseDataSet.Ремонт.NewРемонтRow());
                ремонтBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ремонтBindingSource.ResetBindings(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ремонтBindingSource.EndEdit();
                ремонтTableAdapter.Update(this.baseDataSet.Ремонт);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ремонтBindingSource.ResetBindings(false);
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
            ремонтBindingSource.ResetBindings(false);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (MessageBox.Show("Вы точно хотите удалить эту запись? ", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ремонтBindingSource.RemoveCurrent();
        }
    }
}
