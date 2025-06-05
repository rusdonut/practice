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
    public partial class enter : Form
    {
        string constr = "Data Source=DESKTOP-LIKML7J;Initial Catalog=repair_service;Integrated Security=True;Encrypt=False"; //строка подключения

        public enter()
        {
            InitializeComponent();
            //this.AutoScaleMode = AutoScaleMode.Dpi;

            //инициализация полей
            login_txt.Text = "";
            password_txt.Text = "";

            //подключение обработчиков к событию TextChanged
            login_txt.TextChanged += text_check;
            password_txt.TextChanged += text_check;

            //изначально отключить кнопку
            text_check(null, null);
        }

        private void text_check(object sender, EventArgs e) //проверка на заполненность полей
        {
            if (string.IsNullOrWhiteSpace(login_txt.Text) || string.IsNullOrWhiteSpace(password_txt.Text))
                enter_btn.Enabled = false;
            else
                enter_btn.Enabled = true;
        }

        private void regist_lbl_Click(object sender, EventArgs e) //кнопка регистрации
        {
            regist regist = new regist();

            this.Hide();
            regist.Show();
        }

        private void enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //закрытие всей программы
        }

        private void enter_btn_Click(object sender, EventArgs e) //вход в программу
        {
            orders orders = new orders(); //форма заказы
            string login_org = login_txt.Text; //логин
            string password_org = password_txt.Text; //пароль
            string role = ""; //для записи роли из бд
            int id = 0;

            SqlConnection connection = new SqlConnection(constr); //строка соединения
           
            try
            {
                connection.Open();
                string query = "SELECT user_id FROM users where username = @login AND password = @password"; //запрос
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login_org); //передача логина в запросе
                command.Parameters.AddWithValue("@password", password_org); //передача пароля в запросе
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["user_id"] != DBNull.Value) //если значение не нулевое
                        orders.user_id = (int)reader["user_id"];
                }
                connection.Close();

                connection.Open();
                query = "SELECT role FROM users where username = @login AND password = @password"; //запрос
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login_org); //передача логина в запросе
                command.Parameters.AddWithValue("@password", password_org); //передача пароля в запросе

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["role"] != DBNull.Value) //если значение не нулевое
                    {
                        role = (string)reader["role"];

                        if (role == "user") //если роль пользователя
                        {
                            orders.Show();
                            this.Hide();
                        }
                    }
                }
                else
                    MessageBox.Show("Неверный логин или пароль!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void login_txt_KeyPress(object sender, KeyPressEventArgs e) //проверка кол-ва введённых символов в поле "логин"
        {
            if (login_txt.Text.Length == 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Введено максимальное кол-во символов!");
            }
        }

        private void password_txt_KeyPress(object sender, KeyPressEventArgs e) //проверка кол-ва введённых символов в поле "пароль"
        {
            if (password_txt.Text.Length == 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Введено максимальное кол-во символов!");
            }
        }
    }
}
