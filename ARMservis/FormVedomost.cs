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
    public partial class FormVedomost : Form
    {
        public FormVedomost()
        {
            InitializeComponent();
        }

        private void FormVedomost_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ведомостьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ведомостьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void FormVedomost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Ведомость". При необходимости она может быть перемещена или удалена.
            this.ведомостьTableAdapter.Fill(this.baseDataSet.Ведомость);

        }
    }
}
