using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachBD
{
    public partial class FormTransport : Form
    {
        public FormTransport()
        {
            InitializeComponent();
        }
        private void ExecuteQuery(string query)
        {
            // Рядок підключення до бази даних
            string connectionString = "Data Source=Maksym;Initial Catalog=Kursach_Perevezennya;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Створення нового DataTable для зберігання результатів запиту
                    DataTable dataTable = new DataTable();

                    // Виконання запиту через SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);

                    // Прив'язка нових даних до DataGridView
                    dataGridView1.DataSource = dataTable; // Прив'язка нових даних до DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: " + ex.Message);
                }
            }
        }
        private void tRANSPORTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRANSPORTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursach_PerevezennyaDataSet);

        }

        private void FormTransport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.TRANSPORT". При необходимости она может быть перемещена или удалена.
            this.tRANSPORTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.TRANSPORT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sortColumn = ""; // Default column to sort
            string sortOrder = "";  // Default sorting order

            // Determine which column to sort by
            if (radioButton3.Checked)
                sortColumn = "ID_Transporta";
            else if (radioButton4.Checked)
                sortColumn = "Nomer";
            else if (radioButton5.Checked)
                sortColumn = "Model";
            else if (radioButton6.Checked)
                sortColumn = "Marka";
            else if (radioButton7.Checked)
                sortColumn = "Status";

            // Determine if sorting is ascending or descending
            if (radioButton1.Checked)
                sortOrder = "ASC";  // Ascending order
            else if (radioButton2.Checked)
                sortOrder = "DESC"; // Descending order

            // If a column is selected, apply the sort
            if (!string.IsNullOrEmpty(sortColumn))
            {
                // Apply sorting to the DataView
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.TRANSPORT);
                dataView.Sort = $"{sortColumn} {sortOrder}";

                // Assign sorted DataView back to DataGridView
                tRANSPORTDataGridView.DataSource = dataView;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть стовпець для сортування.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedColumn = ""; // Стовпець для фільтрації
            string rangeStart = textBox1.Text; // Отримати початок діапазону з першого текстового поля
            string rangeEnd = textBox2.Text;   // Отримати кінець діапазону з другого текстового поля

            // Визначити, який радіокнопка для вибору стовпця вибрана
            if (radioButton3.Checked)
                selectedColumn = "ID_Transporta";
            else if (radioButton4.Checked)
                selectedColumn = "Nomer";
            else if (radioButton5.Checked)
                selectedColumn = "Model";
            else if (radioButton6.Checked)
                selectedColumn = "Marka";
            else if (radioButton7.Checked)
                selectedColumn = "Status";
            // Перевірка на вибраний стовпець
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.TRANSPORT);

                // Для текстових даних, пошук за підрядком
                if (selectedColumn == "Nomer" || selectedColumn == "Model" || selectedColumn == "Marka" || selectedColumn == "Status")
                {
                    if (!string.IsNullOrEmpty(rangeStart))
                    {
                        // Використовуємо лише перше текстове поле для текстових стовпців, ігноруємо друге текстове поле
                        string filter = $"{selectedColumn} LIKE '{rangeStart}%'";
                        dataView.RowFilter = filter;
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть текст для пошуку.");
                        return;
                    }
                }
                else
                {
                    // Для числових даних, фільтруємо за діапазоном
                    if (!string.IsNullOrEmpty(rangeStart) && !string.IsNullOrEmpty(rangeEnd))
                    {
                        string filter = $"{selectedColumn} >= {rangeStart} AND {selectedColumn} <= {rangeEnd}";
                        dataView.RowFilter = filter;
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть дійсний діапазон для числових значень.");
                        return;
                    }
                }

                // Призначаємо відфільтровані дані назад до DataGridView
                tRANSPORTDataGridView.DataSource = dataView;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть стовпець для пошуку.");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT T.Model, T.Nomer, T.Marka, V.Imya, V.Prizvyshche
        FROM dbo.TRANSPORT T
        JOIN dbo.REYS R ON T.ID_Transporta = R.ID_Transporta
        JOIN dbo.VODIY V ON R.ID_Vodiya = V.ID_Vodiya;";

            ExecuteQuery(query);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT T.Status, T.Model, T.Marka, T.Nomer
        FROM dbo.TRANSPORT T;";

            ExecuteQuery(query);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT T.Nomer, T.Model, T.Marka, COUNT(R.ID_Reysu) AS KilkistReysiv
        FROM dbo.TRANSPORT T
        JOIN dbo.REYS R ON T.ID_Transporta = R.ID_Transporta
        GROUP BY T.Nomer, T.Model, T.Marka;";

            ExecuteQuery(query);
        }
    }
}
