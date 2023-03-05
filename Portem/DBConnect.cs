using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portem
{
    class DBConnect
    {
        // Подключение к базе данных
        MySqlConnection DBConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=portem");

        // функция соединения с БД
        public void OpenConnection()
        {
            if (DBConnection.State == System.Data.ConnectionState.Closed)
                DBConnection.Open();
        }

        //функция закрывающее соеденение
        public void CloseConnection()
        {
            if (DBConnection.State == System.Data.ConnectionState.Open)
                DBConnection.Close();
        }

        //функция возврата соединения
        public MySqlConnection GetConnection()
        {
            return DBConnection;
        }
    }
}
