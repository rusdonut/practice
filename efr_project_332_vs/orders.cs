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

namespace efr_project_332
{
    public partial class orders : Form
    {
        string constr = "Data Source=DESKTOP-LIKML7J;Initial Catalog=repair_service;Integrated Security=True;Encrypt=False"; //строка подключения
        public int user_id = 0;
        public orders()
        {
            InitializeComponent();

            add2_btn.Click += add_btn_Click;
            edit2_btn.Click += edit_btn_Click;
            delete2_btn.Click += delete_btn_Click;
            refresh2_btn.Click += refresh_btn_Click;
        }

        private void orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repair_serviceDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.repair_serviceDataSet.orders);

            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            string query = "SELECT * FROM orders WHERE user_id = @user_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user_id", user_id);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            connection.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_order add_order = new add_order();

            add_order.Show();
        }

        private void orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //закрытие всей программы
        }

        private void refresh_btn_Click(object sender, EventArgs e) //обновление таблицы
        {
            try
            {
                SqlConnection connection = new SqlConnection(constr); //соединение
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM orders WHERE user_id = @user_id", connection);
                adapter.SelectCommand.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selRowInd = dataGridView1.SelectedRows[0].Index;
                    int order_id = (int)dataGridView1.Rows[selRowInd].Cells["orderidDataGridViewTextBoxColumn"].Value;

                    SqlConnection connection = new SqlConnection(constr); //соединение

                    connection.Open();
                    string query = "DELETE FROM orders WHERE order_id = @order_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@order_id", order_id);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                        MessageBox.Show("Заявка успешно удалена!\nОбновите таблицу", "", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Заявка не найдена!", "", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Выберите заявку!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            enter enter = new enter();
            this.Hide();
            enter.Show(); 
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            edit_order edit_order = new edit_order();
            edit_order.Show();
        }
    }
}
