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
    public partial class confirmBorrow : Form
    {
        String sDate = DateTime.Now.ToString();
        private string bkname,boolflse, bookID, dtRtrn, drtion,qty,dtBrrw;
        dataHandler __cache = new dataHandler();
        function _func = new function();
        string creditscore = "";

        private void password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void datereturn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void duration_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            int yy = datevalue.Year;
            int mn = datevalue.Month;
            int dd = datevalue.Day;
            int ddmn = DateTime.DaysInMonth(yy, mn);
            int mnret = 0;
            int ddret = 0;
            int yyret = yy;
            Dateborrow.Text = mn.ToString() + "/" + dd.ToString() + "/" + (yy.ToString());
            dtBrrw = Dateborrow.Text;

            if ((Convert.ToInt32(duration.Text) + dd) > ddmn)
            {
                ddret = (Convert.ToInt32(duration.Text) + dd) - ddmn;
                mnret = mn + 1;
                if (mnret > 12)
                {
                    mnret -= 12;
                    yyret = yy + 1;
                }
            }
            else
            {
                ddret = Convert.ToInt32(duration.Text) + dd;
                mnret = mn;
            }

            datereturn.Text = mnret.ToString() + "/" + ddret.ToString() + "/" + (yyret.ToString());
            dtRtrn = datereturn.Text;
        }

        private void Dateborrow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public confirmBorrow(string book, string ID,string qty)
        {
            

           
            bkname = book;  
            bookID = ID;
            InitializeComponent();
            creditscore = _func.getCredscore();
            _func.getDuration(creditscore, duration);
            Dateborrow.Enabled = false;
            datereturn.Enabled = false;
            this.qty = qty;

        }

        

        private void duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            int yy = datevalue.Year;
            int mn = datevalue.Month;
            int dd = datevalue.Day;
            int ddmn = DateTime.DaysInMonth(yy, mn);
            int mnret = 0;
            int ddret = 0;
            int yyret = yy;
            Dateborrow.Text = mn.ToString() + "/" + dd.ToString() + "/" + (yy.ToString());
            dtBrrw = Dateborrow.Text;

            if ((Convert.ToInt32(duration.Text) + dd) > ddmn)
            {
                ddret = (Convert.ToInt32(duration.Text) + dd) - ddmn;
                mnret = mn + 1;
                if (mnret > 12)
                {
                    mnret -= 12;
                    yyret = yy + 1;
                }
            }
            else
            {
                ddret = Convert.ToInt32(duration.Text) + dd;
                mnret = mn;
            }

            datereturn.Text = mnret.ToString() + "/" + ddret.ToString() + "/" + (yyret.ToString());
            dtRtrn = datereturn.Text;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            confirmpassword();
            
            
        }
        public void confirmpassword()
        {
            if (password.Text.Equals(__cache.returnuser_std(9)))
            {
                drtion = duration.Text;
                boolflse = "false";
                _func.bookOrder(bkname, boolflse, bookID,dtBrrw,dtRtrn,drtion,qty);
                Messagebox MessageBox = new Messagebox("Borrowed Succesfully");
                MessageBox.Show();
                this.Dispose();
            }
            else
            {
                Messagebox MessageBox = new Messagebox("Incorrect Password");
                MessageBox.Show();
            }

        }
        

    }
}
