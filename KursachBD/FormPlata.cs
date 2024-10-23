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
    public partial class FormPlata : Form
    {
        public FormPlata()
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
        private void pLATABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pLATABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursach_PerevezennyaDataSet);

        }

        private void FormPlata_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.PLATA". При необходимости она может быть перемещена или удалена.
            this.pLATATableAdapter.Fill(this.kursach_PerevezennyaDataSet.PLATA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sortColumn = ""; // Default column to sort
            string sortOrder = "";  // Default sorting order

            // Determine which column to sort by
            if (radioButton3.Checked)
                sortColumn = "ID_Plati";
            else if (radioButton4.Checked)
                sortColumn = "ID_Zamovlennya";
            else if (radioButton5.Checked)
                sortColumn = "SumaOplaty";
            else if (radioButton6.Checked)
                sortColumn = "DataOplaty";

            // Determine if sorting is ascending or descending
            if (radioButton1.Checked)
                sortOrder = "ASC";  // Ascending order
            else if (radioButton2.Checked)
                sortOrder = "DESC"; // Descending order

            // If a column is selected, apply the sort
            if (!string.IsNullOrEmpty(sortColumn))
            {
                // Apply sorting to the DataView
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.PLATA);
                dataView.Sort = $"{sortColumn} {sortOrder}";

                // Assign sorted DataView back to DataGridView
                pLATADataGridView.DataSource = dataView;
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
                selectedColumn = "ID_Plati";
            else if (radioButton4.Checked)
                selectedColumn = "ID_Zamovlennya";
            else if (radioButton5.Checked)
                selectedColumn = "SumaOplaty";
            else if (radioButton6.Checked)
                selectedColumn = "DataOplaty"; // Стовпець дати

            // Перевірка на вибраний стовпець
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.PLATA);

                // Для DateTime, фільтруємо за діапазоном
                if (selectedColumn == "DataOplaty")
                {
                    if (!string.IsNullOrEmpty(rangeStart) && !string.IsNullOrEmpty(rangeEnd))
                    {
                        // Форматуємо дати у рядок, щоб передати у RowFilter
                        DateTime startDate;
                        DateTime endDate;

                        // Перевірка на правильність формату дати
                        if (DateTime.TryParse(rangeStart, out startDate) && DateTime.TryParse(rangeEnd, out endDate))
                        {
                            string filter = $"({selectedColumn} >= #{startDate.ToString("MM/dd/yyyy")}#) AND ({selectedColumn} <= #{endDate.ToString("MM/dd/yyyy")}#)";
                            dataView.RowFilter = filter;
                        }
                        else
                        {
                            MessageBox.Show("Будь ласка, введіть дійсні дати у правильному форматі.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть дійсний діапазон для дати.");
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
                pLATADataGridView.DataSource = dataView;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть стовпець для пошуку.");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT K.Imya, K.Prizvyshche, P.SumaOplaty, P.DataOplaty
        FROM dbo.PLATA P
        JOIN dbo.ZAMOVLENNYA Z ON P.ID_Zamovlennya = Z.ID_Zamovlennya
        JOIN dbo.KLIENT K ON Z.ID_Klienta = K.ID_Klienta;";

            ExecuteQuery(query);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT P.DataOplaty, Z.DataZamovlennya, P.SumaOplaty
        FROM dbo.PLATA P
        JOIN dbo.ZAMOVLENNYA Z ON P.ID_Zamovlennya = Z.ID_Zamovlennya;";

            ExecuteQuery(query);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT P.SumaOplaty, P.DataOplaty, Z.DataDostavky
        FROM dbo.PLATA P
        JOIN dbo.ZAMOVLENNYA Z ON P.ID_Zamovlennya = Z.ID_Zamovlennya;";

            ExecuteQuery(query);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(SumaOplaty) AS TotalSumaOplaty FROM dbo.PLATA;";
            ExecuteAggregateQuery(query, "Загальна сума оплати: ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT MIN(SumaOplaty) AS MinSumaOplaty FROM dbo.PLATA;";
            ExecuteAggregateQuery(query, "Мінімальна сума оплати: ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "SELECT MAX(SumaOplaty) AS MaxSumaOplaty FROM dbo.PLATA;";
            ExecuteAggregateQuery(query, "Максимальна сума оплати: ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "SELECT AVG(SumaOplaty) AS AvgSumaOplaty FROM dbo.PLATA;";
            ExecuteAggregateQuery(query, "Середня сума оплати: ");
        }
        private void ExecuteAggregateQuery(string query, string messagePrefix)
        {
            string connectionString = "Data Source=Maksym;Initial Catalog=Kursach_Perevezennya;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    var result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        MessageBox.Show(messagePrefix + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Результат не знайдено.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: " + ex.Message);
                }
            }
        }
    }
}
