using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
"Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
DialogResult.Yes;

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Кабачков Иван Алексеевич,720-1,2023", "О программе",
MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void toolStripMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Кабачков Иван Алексеевич,720-1,2023", "О программе",
MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void poez_RouteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.poez_RouteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.poezdDataSet);

        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poezdDataSet.Poez_Route". При необходимости она может быть перемещена или удалена.
            this.poez_RouteTableAdapter.Fill(this.poezdDataSet.Poez_Route);
            dateTimePicker1.MinDate = new DateTime(2023, 7, 4);
            dateTimePicker1.MaxDate = new DateTime(2023, 9, 30);
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               
            var formPoez_Route = new Poez_Route();
            formPoez_Route.Show();
            this.Hide();
        }

        private void poez_RouteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSID = new SID();
            formSID.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formSID = new SID();
            formSID.Show();
            this.Hide();
        }
    }
}
