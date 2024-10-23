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
    public partial class FormZamovlennya : Form
    {
        public FormZamovlennya()
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
        private void zAMOVLENNYABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zAMOVLENNYABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursach_PerevezennyaDataSet);

        }

        private void FormZamovlennya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.ZAMOVLENNYA". При необходимости она может быть перемещена или удалена.
            this.zAMOVLENNYATableAdapter.Fill(this.kursach_PerevezennyaDataSet.ZAMOVLENNYA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sortColumn = ""; // Default column to sort
            string sortOrder = "";  // Default sorting order

            // Determine which column to sort by
            if (radioButton3.Checked)
                sortColumn = "ID_Zamovlennya";
            else if (radioButton4.Checked)
                sortColumn = "ID_Klienta";
            else if (radioButton5.Checked)
                sortColumn = "DataZamovlennya";
            else if (radioButton6.Checked)
                sortColumn = "DataDostavky";

            // Determine if sorting is ascending or descending
            if (radioButton1.Checked)
                sortOrder = "ASC";  // Ascending order
            else if (radioButton2.Checked)
                sortOrder = "DESC"; // Descending order

            // If a column is selected, apply the sort
            if (!string.IsNullOrEmpty(sortColumn))
            {
                // Apply sorting to the DataView
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.ZAMOVLENNYA);
                dataView.Sort = $"{sortColumn} {sortOrder}";

                // Assign sorted DataView back to DataGridView
                zAMOVLENNYADataGridView.DataSource = dataView;
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
                selectedColumn = "ID_Zamovlennya";
            else if (radioButton4.Checked)
                selectedColumn = "ID_Klienta";
            else if (radioButton5.Checked)
                selectedColumn = "DataZamovlennya";
            else if (radioButton6.Checked)
                selectedColumn = "DataDostavky"; // Стовпець дати

            // Перевірка на вибраний стовпець
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.ZAMOVLENNYA);

                // Для DateTime, фільтруємо за діапазоном
                if (selectedColumn == "DataZamovlennya" || selectedColumn == "DataDostavky")
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
                zAMOVLENNYADataGridView.DataSource = dataView;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть стовпець для пошуку.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT Z.ID_Zamovlennya, Z.DataZamovlennya, K.Imya, K.Prizvyshche
        FROM dbo.ZAMOVLENNYA Z
        JOIN dbo.KLIENT K ON Z.ID_Klienta = K.ID_Klienta;";

            ExecuteQuery(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT Z.ID_Zamovlennya, P.SumaOplaty, Z.DataZamovlennya, P.DataOplaty
        FROM dbo.ZAMOVLENNYA Z
        JOIN dbo.PLATA P ON Z.ID_Zamovlennya = P.ID_Zamovlennya;";

            ExecuteQuery(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT Z.ID_Zamovlennya, Z.DataZamovlennya, Z.DataDostavky
        FROM dbo.ZAMOVLENNYA Z;";

            ExecuteQuery(query);
        }
    }
}
