using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class logIn : Form
    {
        connection _con;
        function _func = new function();
        fileHandler _filehandler =  new fileHandler();
        public logIn()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox1.Text.Equals("Username"))
            {
                Textbox1.Text = "";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

            bool auth = false;
            _func.logIn(Textbox1.Text, Textbox2.Text);
            auth = _func.authentication();
            if (auth == true)
            {
                menu manu = new menu();
                manu.Show();
                    this.Hide();
            }
            else
            {
                    Messagebox MessageBox = new Messagebox("Wrong Username or Password!");MessageBox.Show();
            }

            }
            catch
            {
                Messagebox MessageBox = new Messagebox("Connection to database failed!"); MessageBox.Show();
            }
            _func.readUser();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _filehandler.readFile();
                _con = new connection();
                _con.checkCon();

                label1.Text = "Connection Success";
                
                _func.loadDataBook();
            }
            catch
            {
                label1.Text = "Connection Failed";
                panel1.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbConfiguration _new = new dbConfiguration(this);
            _new.Show();
            this.Hide();
        }

        private void Textbox2_OnValueChanged(object sender, EventArgs e)
        {
            if (Textbox2.Text.Equals("Password"))
            {
                Textbox2.Text = "";
            }
        }
    }
}
