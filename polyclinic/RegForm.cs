using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polyclinic
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            NumberPolic.Text = "0000000000000000";
            passField.Text = "Введите пароль";
            passField.UseSystemPasswordChar = false;
            passField2.Text = "Повторите пароль";
            passField2.UseSystemPasswordChar = false;
            AdressfacktUser.Text = "г. Москва, ул. Профсоюзная, д. 10к2";
            EmailUser.Text = "ivanenko@gmail.ru";
            telephoneUser.Text = "+79000000000";
            this.NumberPolic.ForeColor = System.Drawing.Color.Gray;
            this.passField.ForeColor = System.Drawing.Color.Gray;
            this.passField2.ForeColor = System.Drawing.Color.Gray;
            this.AdressfacktUser.ForeColor = System.Drawing.Color.Gray;
            this.EmailUser.ForeColor = System.Drawing.Color.Gray;
            this.telephoneUser.ForeColor = System.Drawing.Color.Gray;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, this.NumberPolic.Size.Height);
            this.passField2.AutoSize = false;
            this.passField2.Size = new Size(this.passField2.Size.Width, this.NumberPolic.Size.Height);
        }

        public string getNumberPolic()
        {
            return this.NumberPolic.Text;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(3, 58, 72);

        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;

        }

        Point lastPoint;
        private void avtorizaciya_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void avtorizaciya_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void NumberPolic_Enter(object sender, EventArgs e)
        {
            if (NumberPolic.Text == "0000000000000000")
            {
                NumberPolic.Text = "";
                this.NumberPolic.ForeColor = System.Drawing.Color.Black;
            }
        }

        

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.UseSystemPasswordChar = true;
                this.passField.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void passField2_Enter(object sender, EventArgs e)
        {
            if (passField2.Text == "Повторите пароль")
            {
                passField2.Text = "";
                passField2.UseSystemPasswordChar = true;
                this.passField2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void AdressfacktUser_Enter(object sender, EventArgs e)
        {
            if (AdressfacktUser.Text == "г. Москва, ул. Профсоюзная, д. 10к2")
            {
                AdressfacktUser.Text = "";
                this.AdressfacktUser.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void EmailUser_Enter(object sender, EventArgs e)
        {
            if (EmailUser.Text == "ivanenko@gmail.ru")
            {
                EmailUser.Text = "";
                this.EmailUser.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void telephoneUser_Enter(object sender, EventArgs e)
        {
            if (telephoneUser.Text == "+79000000000")
            {
                telephoneUser.Text = "";
                this.telephoneUser.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void NumberPolic_Leave(object sender, EventArgs e)
        {
            if (NumberPolic.Text == "")
            {
                NumberPolic.Text = "0000000000000000";
                this.NumberPolic.ForeColor = System.Drawing.Color.Gray;
            }
        }


        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.UseSystemPasswordChar = false;
                this.passField.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void passField2_Leave(object sender, EventArgs e)
        {
            if (passField2.Text == "")
            {
                passField2.Text = "Повторите пароль";
                passField2.UseSystemPasswordChar = false;
                this.passField2.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void AdressfacktUser_Leave(object sender, EventArgs e)
        {
            if (AdressfacktUser.Text == "")
            {
                AdressfacktUser.Text = "г. Москва, ул. Профсоюзная, д. 10к2";
                this.AdressfacktUser.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void EmailUser_Leave(object sender, EventArgs e)
        {
            if (EmailUser.Text == "")
            {
                EmailUser.Text = "ivanenko@gmail.ru";
                this.EmailUser.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void telephoneUser_Leave(object sender, EventArgs e)
        {
            if (telephoneUser.Text == "")
            {
                telephoneUser.Text = "+79000000000";
                this.telephoneUser.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void resume_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `polyclinic`.`личные_данные` " +
                "(`Номер_полиса_ОМС`, `Дата_рождения`," +
                " `Фактический_адрес_проживания`) VALUES (@nP, @dR, @fA)", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("INSERT INTO `polyclinic`.`контакты` " +
                "(`Телефон`, `Почта`, `Номер_полиса_ОМС`)" +
                " VALUES (@nT, @email, @nP)", db.getConnection());
            MySqlCommand command3 = new MySqlCommand("INSERT INTO `polyclinic`.`данные_авторизации`" +
                " (`Номер_полиса_ОМС`, `Пароль`) VALUES (@nP, @pass)", db.getConnection());
            if (NumberPolic.Text.All(char.IsDigit) == true && NumberPolic.Text != "0000000000000000")
            {
                command.Parameters.Add("@nP", MySqlDbType.VarChar).Value = NumberPolic.Text;
                command2.Parameters.Add("@nP", MySqlDbType.VarChar).Value = NumberPolic.Text;
                command3.Parameters.Add("@nP", MySqlDbType.VarChar).Value = NumberPolic.Text;
            }
            command.Parameters.Add("@dR", MySqlDbType.Date).Value = dateBirthday.Value;
            command.Parameters.Add("@fA", MySqlDbType.VarChar).Value = AdressfacktUser.Text;
            if (telephoneUser.Text[0] == '+' && telephoneUser.Text != "+79000000000")
                command2.Parameters.Add("@nT", MySqlDbType.VarChar).Value = telephoneUser.Text;
            if (EmailUser.Text.Contains('@') && EmailUser.Text.Contains('.') && EmailUser.Text != "ivanenko@gmail.ru")
                command2.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailUser.Text;
            if (passField.Text == passField2.Text)
                command3.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1 && command3.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно введены все данные!");
                RegForm2 registerForm = new RegForm2(NumberPolic.Text);
                this.Hide();
                registerForm.Show();
            }
            else
                MessageBox.Show("Ошибка");
            db.closeConnection();
            

        }

    }
}
