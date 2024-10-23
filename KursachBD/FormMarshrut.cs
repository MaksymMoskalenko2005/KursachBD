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
    public partial class FormMarshrut : Form
    {
        public FormMarshrut()
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


        private void mARSHRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mARSHRUTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursach_PerevezennyaDataSet);

        }

        private void FormMarshrut_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.MARSHRUT". При необходимости она может быть перемещена или удалена.
            this.mARSHRUTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.MARSHRUT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sortColumn = ""; // Default column to sort
            string sortOrder = "";  // Default sorting order

            // Determine which column to sort by
            if (radioButton3.Checked)
                sortColumn = "ID_Marshruta";
            else if (radioButton4.Checked)
                sortColumn = "PochtovaTochka";
            else if (radioButton5.Checked)
                sortColumn = "KincevaTochka";
            else if (radioButton6.Checked)
                sortColumn = "Dystanciya";
            else if (radioButton7.Checked)
                sortColumn = "ID_Zamovlennya";

            // Determine if sorting is ascending or descending
            if (radioButton1.Checked)
                sortOrder = "ASC";  // Ascending order
            else if (radioButton2.Checked)
                sortOrder = "DESC"; // Descending order

            // If a column is selected, apply the sort
            if (!string.IsNullOrEmpty(sortColumn))
            {
                // Apply sorting to the DataView
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.MARSHRUT);
                dataView.Sort = $"{sortColumn} {sortOrder}";

                // Assign sorted DataView back to DataGridView
                mARSHRUTDataGridView.DataSource = dataView;
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
                selectedColumn = "ID_Marshruta";
            else if (radioButton4.Checked)
                selectedColumn = "PochtovaTochka";
            else if (radioButton5.Checked)
                selectedColumn = "KincevaTochka";
            else if (radioButton6.Checked)
                selectedColumn = "Dystanciya";
            else if (radioButton7.Checked)
                selectedColumn = "ID_Zamovlennya";
            // Перевірка на вибраний стовпець
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.MARSHRUT);

                // Для текстових даних, пошук за підрядком
                if (selectedColumn == "PochtovaTochka" || selectedColumn == "KincevaTochka")
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
                mARSHRUTDataGridView.DataSource = dataView;
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
        SELECT M.PochtovaTochka AS PochtovaTochka, 
               M.KincevaTochka AS KincevaTochka, 
               V.Imya AS ImyaVodiya, 
               V.Prizvyshche AS PrizvyshcheVodiya
        FROM dbo.VODIY V
        INNER JOIN dbo.REYS R ON V.ID_Vodiya = R.ID_Vodiya
        INNER JOIN dbo.MARSHRUT M ON R.ID_Marshruta = M.ID_Marshruta;";

            ExecuteQuery(query);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT T.Nomer AS TransportNomer, 
               T.Model AS TransportModel, 
               M.PochtovaTochka AS MarshrutStart, 
               M.KincevaTochka AS MarshrutKinec
        FROM dbo.TRANSPORT T
        INNER JOIN dbo.REYS R ON T.ID_Transporta = R.ID_Transporta
        INNER JOIN dbo.MARSHRUT M ON R.ID_Marshruta = M.ID_Marshruta;";

            ExecuteQuery(query);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT M.PochtovaTochka AS MarshrutStart, 
               M.KincevaTochka AS MarshrutKinec, 
               COUNT(R.ID_Reysu) AS KilkistReysiv
        FROM dbo.MARSHRUT M
        INNER JOIN dbo.REYS R ON M.ID_Marshruta = R.ID_Marshruta
        GROUP BY M.PochtovaTochka, M.KincevaTochka;";

            ExecuteQuery(query);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(Dystanciya) AS TotalDystanciya FROM dbo.MARSHRUT;";
            ExecuteAggregateQuery(query, "Загальна відстань: ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT MIN(Dystanciya) AS MinDystanciya FROM dbo.MARSHRUT;";
            ExecuteAggregateQuery(query, "Мінімальна відстань: ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "SELECT MAX(Dystanciya) AS MaxDystanciya FROM dbo.MARSHRUT;";
            ExecuteAggregateQuery(query, "Максимальна відстань: ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "SELECT AVG(Dystanciya) AS AvgDystanciya FROM dbo.MARSHRUT;";
            ExecuteAggregateQuery(query, "Середня відстань: ");
        }

        // Метод для виконання запиту та виводу результату в MessageBox
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
