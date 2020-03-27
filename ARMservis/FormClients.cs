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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.baseDataSet.Клиенты);
       
            

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddClient FormGL = new FormAddClient();
            Hide();
            FormGL.Show();
        }

        private void FormClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGL FormClients = new FormGL();
            Hide();
            FormClients.Show();
        }

        private void таблица1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    this.клиентыTableAdapter.Fill(this.baseDataSet.Клиенты);
                    клиентыBindingSource.DataSource = this.baseDataSet.Клиенты;
                }
                else
                {
                    var query = from o in this.baseDataSet.Клиенты
                                where o.Имя.Contains(textBox1.Text) || o.Фамилия == textBox1.Text || o.Телефон == textBox1.Text
                                select o;
                    клиентыBindingSource.DataSource = query.ToList();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
