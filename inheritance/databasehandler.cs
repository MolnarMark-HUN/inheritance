using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace inheritance
{
    public class databasehandler
    {
        MySqlConnection connect;
        public databasehandler()
        {
            string username = "root";
            string password = "";
            string host = "localhost";
            string dbname = "Trabant";
            string connectionstring = $"username={username};password={password};host={host};database={dbname}";
            connect = new MySqlConnection(connectionstring);
        }
        public void readall()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM cars";
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    int id = read.GetInt32(read.GetOrdinal("id"));
                    int year = read.GetInt32(read.GetOrdinal("year"));
                    string make = read.GetString(read.GetOrdinal("make"));
                    string model = read.GetString(read.GetOrdinal("model"));
                    string color = read.GetString(read.GetOrdinal("color"));
                    int hp = read.GetInt32(read.GetOrdinal("hp"));
                    car onecar = new car();
                    onecar.id = id;
                    onecar.hp = hp;
                    onecar.make = make;
                    onecar.model = model;
                    onecar.color = color;
                    onecar.year = year;
                    car.cars.Add(onecar);
                }
                read.Close();
                command.Dispose();
                connect.Close();
                MessageBox.Show("Siker");
                

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"Error");
            }
        }

    }
}
