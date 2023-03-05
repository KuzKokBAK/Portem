using MySql.Data.MySqlClient;
using Portem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateItemButton_Click(object sender, EventArgs e)
        {
            CreateItemForm f2 = new CreateItemForm();
            f2.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            //получаем данные от пользователя
            string sTextHead = SearchTextBox.Text;

            if (sTextHead == "")
            {
                ItemTextBox.Clear();
                MessageBox.Show("Запрос пуст");
            }
                
            else
            {
                //подключились кБД
                DBConnect db = new DBConnect();
                //подключение команд
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                //выполняем через параметр command команды sql и указывает к какой БД подключаемся
                MySqlCommand command = new MySqlCommand("SELECT `ContentText` FROM `userforms` WHERE `Head` = @tH ", db.GetConnection());
                command.Parameters.Add("@tH", MySqlDbType.VarChar).Value = sTextHead;

                db.OpenConnection();

                string text = command.ExecuteScalar().ToString();
                ItemTextBox.Text = text;

                db.CloseConnection();
            }

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
