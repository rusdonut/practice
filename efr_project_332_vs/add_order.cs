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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace efr_project_332
{
    public partial class add_order : Form
    {
        string constr = "Data Source=DESKTOP-LIKML7J;Initial Catalog=repair_service;Integrated Security=True;Encrypt=False"; //строка подключения

        public add_order()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e) //кнопка "отмена"
        {
            this.Close();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            int order_id = 0;
            
            DateTime date = DateTime.Today; //получение сегодняшней даты
            string rev_date = date.ToString("yyyy-MM-dd"); //запись наоборот

            string item = item_txt.Text;
            string type = type_txt.Text;
            string description = description_txt.Text;
            int user_id = 2;
            int worker_id = 0;
            string status = "В ожидании";
            string comment = "";

            SqlConnection connection = new SqlConnection(constr); //строка соединения

            connection.Open();
            string query = "SELECT TOP 1 order_id FROM orders ORDER BY order_id DESC"; //запрос на получение последнего номера заказа
            SqlCommand command = new SqlCommand(query, connection);
            object result = command.ExecuteScalar();
            if (result != DBNull.Value)
                order_id = Convert.ToInt32(result) + 1;
            connection.Close();

            try
            {
                connection.Open();
                query = "INSERT INTO orders (order_id, date, item, type, description, user_id, worker_id, status, comment) VALUES (@order_id, @date, @item, @type, @description, @user_id, @worker_id, @status, @comment)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@order_id", order_id);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@item", item);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@worker_id", worker_id);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@comment", comment);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Заявка успешно создана!\nОбновите таблицу", "", MessageBoxButtons.OK);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
