using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Connect
    {
        public static SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = USER-ПК\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Алиев");
            //connection.ConnectionString = @"Data Source = USER-ПК\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Алиев";
            try
            {
                connection.Open();
             //   MessageBox.Show("Успешное подключение");
            } catch
            {
                MessageBox.Show("Не удалось установить соединение.");
                Environment.Exit(0);
            }
            return connection;
        }
     //   Data Source = USER - ПК\SQLEXPRESS;Integrated Security = SSPI; Initial Catalog = Алиев
    }
}
