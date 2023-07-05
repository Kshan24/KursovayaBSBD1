using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Poez_Route : Form
    {
        
       
        public Poez_Route()
        {
            InitializeComponent();
        }

        private void Poez_Route_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poezdDataSet.Ticket_Sum". При необходимости она может быть перемещена или удалена.
            this.ticket_SumTableAdapter.Fill(this.poezdDataSet.Ticket_Sum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poezdDataSet.Route_inf1". При необходимости она может быть перемещена или удалена.
            this.route_inf1TableAdapter.Fill(this.poezdDataSet.Route_inf1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poezdDataSet.Poez_Route". При необходимости она может быть перемещена или удалена.
            this.poez_RouteTableAdapter.Fill(this.poezdDataSet.Poez_Route);
            
           
        }

        string GetSelectedFieldName()
        {
            return
           poez_RouteDataGridView.Columns[poez_RouteDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }



        private void Poez_Route_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
"Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
DialogResult.Yes;
          
        }

        private void poez_RouteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.poez_RouteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.poezdDataSet);

        }


        private void poez_RouteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       //private void Search(DataGridView dgw)
         // {
         //   dgw.Rows.Clear();
         //   string searchString = $"select"
        //}

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               poez_RouteBindingSource.Find(GetSelectedFieldName(),
               textBox1.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                poez_RouteBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                poez_RouteBindingSource.Position = 0;
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void coupeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void poez_RouteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = poez_RouteDataGridView.Rows[e.RowIndex];
                string selectedPoezID = selectedRow.Cells["ID_Poez"].Value.ToString();

                DataView filteredView = new DataView(poezdDataSet.Route_inf1);
                filteredView.RowFilter = $"ID_Poez = {selectedPoezID}";
                route_inf1DataGridView.DataSource = filteredView;
            }

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}
