using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_System.Main.Data
{
    public class Conection_MySql
    {
        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String DataBase { get; set; }
        public static String User { get; set; }
        public static String Passord { get; set; }
        public static MySqlConnection GetConnection()
        {
            Server = "Localhost";
            DataBase = "Sistemacadastro";
            User = "root";
            Passord = "root";
            ConnectionString = $"Persist Security Info=False;server={Server};database={DataBase};uid={User};server={Server};database={DataBase};uid={User};pwd='{Passord}'";
            
            var conn = new MySqlConnection($"");

            try
            {
                conn.Open();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message, "Erro ao connectar");
                throw;
            }

            return conn ;
        }
    }
}
