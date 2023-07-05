using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kursach
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void ticket_SumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticket_SumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.poezdDataSet);

        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poezdDataSet.Ticket_Sum". При необходимости она может быть перемещена или удалена.
            this.ticket_SumTableAdapter.Fill(this.poezdDataSet.Ticket_Sum);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID_Poez = textBoxIDPoez.Text;
            string Month_Start = textBoxMonthStart.Text;
            string Month_End = textBoxMonthEnd.Text;
            string Total_Coupe = textBoxTotalCoupe.Text;
            string Total_Plaz = textBoxTotalPlaz.Text;
            DataTable dataTable = poezdDataSet.Ticket_Sum;
            DataRow newRow = dataTable.NewRow();
           
            newRow["ID_Poez"] = ID_Poez;
            newRow["Month_Start"] = Month_Start;
            newRow["Month_End"] = Month_End;
            newRow["Total_Coupe"] = Total_Coupe;
            newRow["Total_Plaz"] = Total_Plaz;
            dataTable.Rows.Add(newRow);
            ticket_SumBindingSource.ResetBindings(false);

            textBoxIDPoez.Text = "";
            textBoxMonthStart.Text = "";
            textBoxMonthEnd.Text = "";
            textBoxTotalCoupe.Text = "";
            textBoxTotalPlaz.Text = "";
            ticket_SumDataGridView.Refresh();
            MessageBox.Show("Данные успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void iD_PoezTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}
