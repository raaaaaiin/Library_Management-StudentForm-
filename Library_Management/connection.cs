using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;


namespace Library_Management
{
    class connection
    {
        public MySqlConnection condupe;
        public MySqlDataAdapter adp;
        public MySqlConnection con = new MySqlConnection("server=localhost;database=lib_mgmt;uid=root;pwd=root;");
        public MySqlCommand com = new MySqlCommand();
        public MySqlDataReader reader;
        public DataSet ds;

        public connection()
        {
            condupe = con;
            /*add = "localhost";
            db = "lib_mgmt";
            user = "root";
            pass = "root";*/



        }
        public void setCon(string add, string db, string user, string pass)
        {
            con = new MySqlConnection("server=" + add +
            ";database=" + db + ";" +
            "uid=" + user + "" +
            ";pwd=" + pass + ";");
            com = new MySqlCommand();
        }
        public void checkCon()
        {
            con.Open();
            con.Close();

        }

    }
}
