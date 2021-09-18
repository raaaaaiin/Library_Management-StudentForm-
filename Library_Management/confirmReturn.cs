using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class confirmReturn : Form
    {
        function _func = new function();
        dataHandler __cache = new dataHandler();
        menu _menu;
        private string bookID = "";
        public confirmReturn(string id, menu ths)
        {
            InitializeComponent();
            bookID = id;
            _menu = ths;
            _func.getingDate(bookID);
            brwDTe.Text = __cache.returnbrbook_info(0);
            exptdDTE.Text = __cache.returnbrbook_info(1);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            confirmpassword();
        }
        public void confirmpassword()
        {
            if (password.Text.Equals(__cache.returnuser_std(9)))
            {
                string booltrue = "true";
                _func.returnBook(booltrue, bookID);
                Messagebox MessageBox = new Messagebox("Returned Succesfully");
                MessageBox.Show();
                _func.showBrwBook();
                _menu.forshow();
                this.Dispose();

            }
            else
            {
                Messagebox MessageBox = new Messagebox("Incorrect Password");
                MessageBox.Show();
            }

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void updatecreditscore()
        {
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            int yy = datevalue.Year;
            int mn = datevalue.Month;
            int dd = datevalue.Day;
            int ddmn = DateTime.DaysInMonth(yy, mn);


            DateTime futurDate = Convert.ToDateTime(__cache.returnbrbook_info(1));
            DateTime todayDate = DateTime.Now;
            
            int days = ((todayDate - futurDate).Days - 1);

            MessageBox.Show(days.ToString());
            if (days > 0)
            {
                _func.updatecred(days.ToString());
                  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatecreditscore();
        }

        private void exptdDTE_Click(object sender, EventArgs e)
        {

        }
    }
}
