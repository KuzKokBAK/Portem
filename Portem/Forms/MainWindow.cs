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
            ////получаем данные от пользователя
            //string TextHead = HeadTextBox.Text;
            //string TextContent = ContentTextBox.Text;

            ////подключились кБД
            //DBConnect db = new DBConnect();
            ////подключение команд
            //DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            ////выполняем через параметр command команды sql и указывает к какой БД подключаемся
            //MySqlCommand command = new MySqlCommand("SELECT * FROM `userforms` WHERE `Head` = @tH AND `ContentText` = @tC", db.GetConnection());
            //command.Parameters.Add("@tH", MySqlDbType.VarChar).Value = TextHead;
            //command.Parameters.Add("@tC", MySqlDbType.Text).Value = TextContent;

            ////все команды которые мы получили помещаем в объект table
            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            ////проверка записей
            ////если записей пользователя больше чем 0, значит таков пользователь есть
            //if (table.Rows.Count > 0)
            //    MessageBox.Show("yes");
            //else
            //    MessageBox.Show("no");
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
