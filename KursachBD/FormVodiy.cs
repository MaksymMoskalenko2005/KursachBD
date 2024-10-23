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
    public partial class FormVodiy : Form
    {
        public FormVodiy()
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
        private void vODIYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vODIYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursach_PerevezennyaDataSet);

        }

        private void FormVodiy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.VODIY". При необходимости она может быть перемещена или удалена.
            this.vODIYTableAdapter.Fill(this.kursach_PerevezennyaDataSet.VODIY);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sortColumn = ""; // Default column to sort
            string sortOrder = "";  // Default sorting order

            // Determine which column to sort by
            if (radioButton3.Checked)
                sortColumn = "ID_Vodiya";
            else if (radioButton4.Checked)
                sortColumn = "Imya";
            else if (radioButton5.Checked)
                sortColumn = "Prizvyshche";
            else if (radioButton6.Checked)
                sortColumn = "Stazh";
            else if (radioButton7.Checked)
                sortColumn = "Telefon";

            // Determine if sorting is ascending or descending
            if (radioButton1.Checked)
                sortOrder = "ASC";  // Ascending order
            else if (radioButton2.Checked)
                sortOrder = "DESC"; // Descending order

            // If a column is selected, apply the sort
            if (!string.IsNullOrEmpty(sortColumn))
            {
                // Apply sorting to the DataView
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.VODIY);
                dataView.Sort = $"{sortColumn} {sortOrder}";

                // Assign sorted DataView back to DataGridView
                vODIYDataGridView.DataSource = dataView;
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
                selectedColumn = "ID_Vodiya";
            else if (radioButton4.Checked)
                selectedColumn = "Imya";
            else if (radioButton5.Checked)
                selectedColumn = "Prizvyshche";
            else if (radioButton6.Checked)
                selectedColumn = "Stazh";
            else if (radioButton7.Checked)
                selectedColumn = "Telefon";
            // Перевірка на вибраний стовпець
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.VODIY);

                // Для текстових даних, пошук за підрядком
                if (selectedColumn == "Imya" || selectedColumn == "Prizvyshche" || selectedColumn == "Telefon")
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
                vODIYDataGridView.DataSource = dataView;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть стовпець для пошуку.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT V.Imya, V.Prizvyshche, V.Stazh, M.PochtovaTochka, M.KincevaTochka
        FROM dbo.VODIY V
        JOIN dbo.REYS R ON V.ID_Vodiya = R.ID_Vodiya
        JOIN dbo.MARSHRUT M ON R.ID_Marshruta = M.ID_Marshruta;";

            ExecuteQuery(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT V.Imya, V.Prizvyshche, V.Stazh, T.Nomer, T.Model
        FROM dbo.VODIY V
        JOIN dbo.REYS R ON V.ID_Vodiya = R.ID_Vodiya
        JOIN dbo.TRANSPORT T ON R.ID_Transporta = T.ID_Transporta;";

            ExecuteQuery(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT V.Imya, V.Prizvyshche, V.Stazh, COUNT(R.ID_Reysu) AS KilkistReysiv
        FROM dbo.VODIY V
        JOIN dbo.REYS R ON V.ID_Vodiya = R.ID_Vodiya
        GROUP BY V.Imya, V.Prizvyshche, V.Stazh;";

            ExecuteQuery(query);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(Stazh) AS TotalStazh FROM dbo.VODIY;";
            ExecuteAggregateQuery(query, "Загальний стаж: ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT MIN(Stazh) AS MinStazh FROM dbo.VODIY;";
            ExecuteAggregateQuery(query, "Мінімальний стаж: ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "SELECT MAX(Stazh) AS MaxStazh FROM dbo.VODIY;";
            ExecuteAggregateQuery(query, "Максимальний стаж: ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "SELECT AVG(Stazh) AS AvgStazh FROM dbo.VODIY;";
            ExecuteAggregateQuery(query, "Середній стаж: ");
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
