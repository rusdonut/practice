using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class regist : Form
    {
        string constr = "Data Source=DESKTOP-LIKML7J;Initial Catalog=repair_service;Integrated Security=True;Encrypt=False"; //строка подключения

        public regist()
        {
            InitializeComponent();

            //инициализация полей
            login_txt.Text = "";
            password_txt.Text = "";
            surname_txt.Text = "";
            name_txt.Text = "";
            lastname_txt.Text = "";
            number_txt.Text = "";

            //подключение обработчиков к событию TextChanged
            login_txt.TextChanged += text_check;
            password_txt.TextChanged += text_check;
            surname_txt.TextChanged += text_check;
            name_txt.TextChanged += text_check;
            lastname_txt.TextChanged += text_check;
            number_txt.TextChanged += text_check;

            //изначально отключить кнопку
            text_check(null, null);
        }

        enter enter = new enter(); //форма входа

        private void back_lbl_Click(object sender, EventArgs e) //кнопка "вернуться назад"
        {
            enter.Show();
            this.Close();
        }

        private void regist_btn_Click(object sender, EventArgs e) //кнопка "зарегистрироваться"
        {
            string username = login_txt.Text;
            string password = password_txt.Text;
            string role = "user";
            string surname = surname_txt.Text;
            string name = name_txt.Text;
            string last_name = lastname_txt.Text;
            int number = Convert.ToInt32(number_txt.Text);
            int user_id = 0; //для кол-ва записей в бд

            SqlConnection connection = new SqlConnection(constr); //строка соединения

            connection.Open();
            string query = "SELECT TOP 1 user_id FROM users ORDER BY user_id DESC"; //запрос на получение последнего номера заказа
            SqlCommand command = new SqlCommand(query, connection);
            object result = command.ExecuteScalar();
            if (result != DBNull.Value)
                user_id = Convert.ToInt32(result) + 1;
            connection.Close();

            try
            {
                connection.Open();
                query = "INSERT INTO users (user_id, username, password, role, surname, name, last_name, number) VALUES (@user_id, @username, @password, @role, @surname, @name, @last_name, @number)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@last_name", last_name);
                command.Parameters.AddWithValue("@number", number);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Регистрация прошла успешно!", "", MessageBoxButtons.OK);

                enter.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void text_check(object sender, EventArgs e) //проверка для кнопки, если какое-то из полей пустое, то кнопка будет недоступна
        {
            if (string.IsNullOrWhiteSpace(login_txt.Text) || 
                string.IsNullOrWhiteSpace(password_txt.Text) ||
                string.IsNullOrWhiteSpace(surname_txt.Text) ||
                string.IsNullOrWhiteSpace(name_txt.Text) ||
                string.IsNullOrWhiteSpace(lastname_txt.Text) ||
                string.IsNullOrWhiteSpace(number_txt.Text))
                regist_btn.Enabled = false;
            else
                regist_btn.Enabled = true;
        }

        private void number_txt_KeyPress(object sender, KeyPressEventArgs e) //проверка ввода данных в поле "номер телефона"
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //проверка на то, чтобы были только цифры
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать только цифры!");
            }

            if (number_txt.Text.Length == 5 && !char.IsControl(e.KeyChar)) //проверка на кол-во цифр в поле
            {
                e.Handled = true;
                MessageBox.Show("Введено максимальное кол-во цифр!");
            }
        }

        private void surname_txt_KeyPress(object sender, KeyPressEventArgs e) //проверка ввода даннных в поле "фамилия"
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //проверка на то, чтобы были только буквы
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать только буквы!");
            }

            if (surname_txt.Text.Length == 20 && !char.IsControl(e.KeyChar)) //проверка на кол-во символов в поле
            {
                e.Handled = true;
                MessageBox.Show("Введено максимальное кол-во букв!");
            }
        }

        private void name_txt_KeyPress(object sender, KeyPressEventArgs e) //проверка ввода данных в поле "имя"
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //проверка на то, чтобы были только буквы
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать только буквы!");
            }

            if (name_txt.Text.Length == 20 && !char.IsControl(e.KeyChar)) //проверка на кол-во символов в поле
            {
                e.Handled = true;
                MessageBox.Show("Введено максимальное кол-во букв!");
            }
        }

        private void lastname_txt_KeyPress(object sender, KeyPressEventArgs e) //проверка ввода данных в поле "отчество"
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //проверка на то, чтобы были только буквы
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать только буквы!");
            }

            if (lastname_txt.Text.Length == 20 && !char.IsControl(e.KeyChar)) //проверка на кол-во символов в поле
            {
                e.Handled = true;
                MessageBox.Show("Введено максимальное кол-во букв!");
            }
        }

        private void login_txt_KeyPress(object sender, KeyPressEventArgs e) //проверка кол-ва символов в поле "логин"
        {
            if (login_txt.Text.Length == 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Введено максимальное кол-во символов!");
            }
        }

        private void password_txt_KeyPress(object sender, KeyPressEventArgs e) //проверка кол-ва символов в поле "пароль"
        {
            if (password_txt.Text.Length == 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Введено максимальное кол-во символов!");
            }
        }
    }
}
