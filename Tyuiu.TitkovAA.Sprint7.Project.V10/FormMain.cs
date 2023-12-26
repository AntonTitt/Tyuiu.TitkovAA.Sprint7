using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TitkovAA.Sprint7.Project.V10.Lib;

namespace Tyuiu.TitkovAA.Sprint7.Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


        }
        DataService dt = new DataService();

        string openFilePath;
        int cols, rows;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonStat_TAA_Click(object sender, EventArgs e)
        {
            FormStatistics ft = new FormStatistics();
            ft.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenZakaz_TAA_Click(object sender, EventArgs e)
        {
            openFileDialogTable_TAA.ShowDialog();
            openFilePath = openFileDialogTable_TAA.FileName;

            string[,] arrayValues = dt.LoadFromFileData(openFilePath);
            dataGridViewTableOrders_TAA.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTableOrders_TAA.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTableOrders_TAA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            if (dataGridViewTableOrders_TAA.Rows.Count != 0) { buttonRemZakaz_TAA.Enabled = true; }
        }

        private void buttonSaveZakaz_TAA_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_TAA.FileName = "Data.csv";
            saveFileDialogTable_TAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_TAA.ShowDialog();


            string path = saveFileDialogTable_TAA.FileName;

            FileInfo filInf = new FileInfo(path);
            bool fileExists = filInf.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTableOrders_TAA.RowCount;
            int columns = dataGridViewTableOrders_TAA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTableOrders_TAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTableOrders_TAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAddZakaz_TAA_Click(object sender, EventArgs e)
        {
            dataGridViewTableOrders_TAA.Rows.Add();
            buttonRemZakaz_TAA.Enabled = true;
        }

        private void buttonRemZakaz_TAA_Click(object sender, EventArgs e)
        {
            int ind = dataGridViewTableOrders_TAA.SelectedCells[0].RowIndex;
            dataGridViewTableOrders_TAA.Rows.RemoveAt(ind);
            if (dataGridViewTableOrders_TAA.Rows.Count == 0)
            {
                buttonRemZakaz_TAA.Enabled = false;
            }
        }

        private void textBoxSearch_TAA_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch_TAA != null)
            {
                if (textBoxSearch_TAA.Text == "thetruthxd")
                {
                    FormStatistics ft = new FormStatistics();
                    ft.Show();
                    //MessageBox.Show("2q34321");
                }
                string currentText = textBoxSearch_TAA.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_TAA.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && textBoxSearch_TAA.Text != string.Empty && cell.Value.ToString().Contains(textBoxSearch_TAA.Text))
                        {
                            cell.Style.BackColor = Color.Magenta;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void textBoxFilter_TAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFilter_TAA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewTableOrders_TAA.Rows)
            {
                if ((r.Cells[comboBoxColumnNames_TAA.SelectedIndex - 1].Value).ToString().ToUpper().Contains(textBoxFilter_TAA.Text.ToUpper()))
                {
                    dataGridViewTableOrders_TAA.Rows[r.Index].Visible = true;
                    dataGridViewTableOrders_TAA.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewTableOrders_TAA.CurrentCell = null;
                    dataGridViewTableOrders_TAA.Rows[r.Index].Visible = false;
                }
            }
        }

       

        private void chartStatistics_TAA_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemInstruction_TAA_Click(object sender, EventArgs e)
        {
            FormInfo formInstruction = new FormInfo();
            formInstruction.ShowDialog();
        }

        private void buttonGetStats_TAA_Click(object sender, EventArgs e)
        {
            chartStatistics_TAA.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Популярность товаров");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_TAA.Rows)
            {
                if (!row.IsNewRow && row.Cells[7] != null && row.Cells[7].Value != null)
                {
                    string label = row.Cells[5].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[7].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chartStatistics_TAA.Series.Add(series);
        }

        private void toolStripMenuItemAbout_TAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа содержит в себе данные\r О заказах", "О вот этом вот", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
