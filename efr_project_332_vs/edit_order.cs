using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace efr_project_332
{
    public partial class edit_order : Form
    {
        string constr = "Data Source=DESKTOP-LIKM3L7J;Initial Catalog=repair_service;Integrated Security=True;Encrypt=False"; //строка подключения

        public edit_order()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id_ord_ud = (int)id_order_cb.SelectedItem; //айди заявки
                string item = item_txt.Text; //оборудование
                string type = type_txt.Text; //тип
                string description = description_txt.Text; //описание

                SqlConnection connection = new SqlConnection(constr); //соединение
                connection.Open();
                string query = "UPDATE orders SET item = @item, type = @type, description = @description WHERE rder_id = @order_id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@item", item);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@order_id", id_ord_ud);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Изменения успешно сохранены!\nОбновите таблицу", "", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<int> ids = new List<int>(10);
        int count = 0;

        private void id_order_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            orders orders = new orders();
            int user_id = orders.user_id;

            //вывод данных на форму
            id_order_cb.DataSource = ids;

            SqlConnection connection = new SqlConnection(constr); //соединение
            int id_ord_ud = (int)id_order_cb.SelectedItem; //номер, выбранный пользователем

            string query = "SELECT item, type, description FROM orders WHERE order_id = @order_id"; //запрос на вывод в зависимости от айди
            SqlCommand sql_comm = new SqlCommand(query, connection);
            sql_comm.Parameters.AddWithValue("@order_id", id_ord_ud); //передача данных

            try
            {
                connection.Open();
                SqlDataReader reader = sql_comm.ExecuteReader();
                if (reader.Read())
                {
                    item_txt.Text = reader.GetString(0); //оборудование
                    type_txt.Text = reader.GetString(1); //тип
                    description_txt.Text = reader.GetString(2); //описание
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void edit_order_Load(object sender, EventArgs e)
        {
            orders orders = new orders();
            int user_id = orders.user_id;

            //запрос для получения списка заказов конкретного пользователя
            string query = "SELECT order_id FROM orders WHERE user_id = @user_id";

            SqlConnection connection = new SqlConnection(constr); //соединение
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user_id", user_id); //передача данных
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["order_id"];
                    ids.Add(id);
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
