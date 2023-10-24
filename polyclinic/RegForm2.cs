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
    public partial class RegForm2 : Form
    {
        String numberPol;
        public RegForm2(String numberPol)
        {
            InitializeComponent();
            NameUser.Text = "Иванов Иван Иванович";
            NumbSerisUser.Text = "00 00 000000";
            KodPodrUser.Text = "000-000";
            this.NameUser.ForeColor = System.Drawing.Color.Gray;
            this.NumbSerisUser.ForeColor = System.Drawing.Color.Gray;
            this.KodPodrUser.ForeColor = System.Drawing.Color.Gray;
            this.numberPol = numberPol;


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


        private void NameUser_Enter(object sender, EventArgs e)
        {
            if (NameUser.Text == "Иванов Иван Иванович")
            {
                NameUser.Text = "";
                this.NameUser.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void NameUser_Leave(object sender, EventArgs e)
        {
            if (NameUser.Text == "")
            {
                NameUser.Text = "Иванов Иван Иванович";
                this.NameUser.ForeColor = System.Drawing.Color.Gray;

            }

        }

        private void NumbSerisUser_Enter(object sender, EventArgs e)
        {
            if (NumbSerisUser.Text == "00 00 000000")
            {
                NumbSerisUser.Text = "";
                this.NumbSerisUser.ForeColor = System.Drawing.Color.Black;
            }


        }

        private void NumbSerisUser_Leave(object sender, EventArgs e)
        {
            if (NumbSerisUser.Text == "")
            {
                NumbSerisUser.Text = "00 00 000000";
                this.NumbSerisUser.ForeColor = System.Drawing.Color.Gray;

            }

        }

        private void KodPodrUser_Enter(object sender, EventArgs e)
        {
            if (KodPodrUser.Text == "000-000")
            {
                KodPodrUser.Text = "";
                this.KodPodrUser.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void KodPodrUser_Leave(object sender, EventArgs e)
        {
            if (KodPodrUser.Text == "")
            {
                KodPodrUser.Text = "000-000";
                this.KodPodrUser.ForeColor = System.Drawing.Color.Gray;

            }

        }

        
        private void resume_Click(object sender, EventArgs e)
        { 
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `polyclinic`.`паспорт_пациента` " +
                "(`Номер_полиса_ОМС`, `Серия_и_номер`, `Кем_выдан`, `Код_подразделения`, `ФИО`, `Дата_выдачи`," +
                " `Адрес_регистрации`) VALUES (@nP, @sN, @wV, @kP, @fio, @dV, @aR)", db.getConnection());
            command.Parameters.Add("@nP", MySqlDbType.VarChar).Value = numberPol;
            command.Parameters.Add("@sN", MySqlDbType.VarChar).Value = NumbSerisUser.Text;
            command.Parameters.Add("@wV", MySqlDbType.VarChar).Value = WhoWidanUser.Text;
            command.Parameters.Add("@kP", MySqlDbType.VarChar).Value = KodPodrUser.Text;
            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = NameUser.Text;
            command.Parameters.Add("@dV", MySqlDbType.Date).Value = DataVUser.Value;
            command.Parameters.Add("@aR", MySqlDbType.VarChar).Value = AdressRegUser.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно введены все данные!");
            }
            else
                MessageBox.Show("Ошибка");
            db.closeConnection();

        }

        
    }
}
