using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portem.Forms
{
    public partial class CreateItemForm : Form
    {
        public CreateItemForm()
        {
            InitializeComponent();
        }

        private void ReadItem()
        {
            
        }

        private void WriteItemButton_Click(object sender, EventArgs e)
        {
            if (HeadTextBox.Text == "" || ContentTextBox.Text == "")
            {
                MessageBox.Show("Нельзя регестрировать пустой запрос");return;
            }

            //проверку на уже существующее название, если оно такогo
            if (isFromExists()) return;
           

            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("INSERT  INTO `userforms` ( `Head`, `ContentText`) VALUES (@head, @contentText)", db.GetConnection());
            command.Parameters.Add("@head", MySqlDbType.VarChar).Value = HeadTextBox.Text;
            command.Parameters.Add("@contentText", MySqlDbType.Text).Value = ContentTextBox.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Ваша форма создана");
            else
                MessageBox.Show("Форма не была зарегестрирована на сервере");

            db.CloseConnection();
            Close();
        }


        //проверку на уже существующюю запись в БД
        public Boolean isFromExists()
        {

            DBConnect db = new DBConnect();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `userforms` WHERE `Head` = @tH", db.GetConnection());
            command.Parameters.Add("@tH", MySqlDbType.VarChar).Value = HeadTextBox.Text;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Форма с таким же название уже существует"); return true;
            }
            else return false;
                
        }

        private void ContentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
