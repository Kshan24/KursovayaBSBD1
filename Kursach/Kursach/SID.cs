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
    public partial class SID : Form
    {
        public SID()
        {
            InitializeComponent();
        }

        private void SID_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poezdDataSet.Poez_Route". При необходимости она может быть перемещена или удалена.
            this.poez_RouteTableAdapter.Fill(this.poezdDataSet.Poez_Route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poezdDataSet.Route_inf1". При необходимости она может быть перемещена или удалена.
            this.route_inf1TableAdapter.Fill(this.poezdDataSet.Route_inf1);

        }

        private void route_inf1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.route_inf1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.poezdDataSet);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formAdd = new Add();
            formAdd.Show();
            this.Hide();
        }
        string GetSelectedFieldName()
        {
            return
           poez_RouteDataGridView.Columns[poez_RouteDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            string columnName = "City_From";
            string columnName1 = "City_To";
            DataTable poez_RouteTable = poezdDataSet.Poez_Route;

            DataRow[] filteredRows = poez_RouteTable.Select($"{columnName} LIKE '%{searchText}%' OR {columnName1} LIKE '%{searchText}%'");

            if (filteredRows.Length > 0)
            {
                // Создать новый DataTable и добавить отфильтрованные строки
                DataTable filteredTable = poez_RouteTable.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                // Установить отфильтрованную таблицу в качестве источника данных DataGridView
                poez_RouteDataGridView.DataSource = filteredTable;
            }
            else
            {
                MessageBox.Show("Нет совпадений", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poez_RouteDataGridView.DataSource = poez_RouteTable; // Вернуть исходную таблицу в качестве источника данных
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}
