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
    public partial class FormAddItems : Form
    {
        public FormAddItems()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGL FormAddItems = new FormGL();
            Hide();
            FormAddItems.Show();
        }

        private void FormAddItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAddItems_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Комплектующее". При необходимости она может быть перемещена или удалена.
            this.комплектующееTableAdapter.Fill(this.baseDataSet.Комплектующее);
            this.baseDataSet.Комплектующее.AddКомплектующееRow(this.baseDataSet.Комплектующее.NewКомплектующееRow());
            комплектующееBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                комплектующееBindingSource.EndEdit();
                комплектующееTableAdapter.Update(this.baseDataSet.Комплектующее);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неизвестная ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                комплектующееBindingSource.ResetBindings(false);
            }
            this.baseDataSet.Комплектующее.AddКомплектующееRow(this.baseDataSet.Комплектующее.NewКомплектующееRow());
            комплектующееBindingSource.MoveLast();
        }
    }
}
