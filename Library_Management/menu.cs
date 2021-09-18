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
    public partial class menu : Form
    {
        public showBooks _bookshow;
        public stdprevilages _stdpriv;
        public bool indicator = false;
        public menu()
        {
            InitializeComponent();
            
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            _stdpriv = new stdprevilages(this);
            _stdpriv.TopLevel = false;
            _stdpriv.TopMost = true;
            prvlg.Controls.Add(_stdpriv);
            _stdpriv.Show();
            _bookshow = new showBooks(this) { TopLevel = false };
            bookshowing();
        }

        

        
        
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        public void bookshowing()
        {
            
            panel2.Controls.Add(_bookshow);
            _bookshow.Show();
            panel2.Show();
            _bookshow.forinitiate();
            forshow();
        }
        public void forshow()
        {
            _bookshow.index = 0;
            _bookshow.fornext();
        }
        public void hidesearch(bool indicatorz)
        {
            _bookshow.searcbar(indicatorz);

        }
    }
}
 