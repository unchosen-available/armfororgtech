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
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClients FormAddClient = new FormClients();
            Hide();
            FormAddClient.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDataSet.Клиенты.AddКлиентыRow(this.baseDataSet.Клиенты.NewКлиентыRow());
                клиентыBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                клиентыBindingSource.ResetBindings(false);
            }
        }

        private void FormAddClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.baseDataSet.Клиенты);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                клиентыBindingSource.EndEdit();
                клиентыTableAdapter.Update(this.baseDataSet.Клиенты);;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                клиентыBindingSource.ResetBindings(false);
            }
        }
    }
}
