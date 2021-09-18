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
    public partial class returnBox : Form
    {
        public int index = 0;
        public int end = 0;
        dataHandler _cache = new dataHandler();
        borrowedBooks[] _brbook = new borrowedBooks[8];
        function _func = new function();
        public returnBox()
        {
            InitializeComponent();
            
            forinitiate();
            forshow();
            
        }
        public void forshow()
        {

            index = 0;
            for (int x = 0; x <= 7; x++)
            {
                try
                {
                    _brbook[x].showInfo(_cache.returnbrbook_info(index));
                    index++;
                    _brbook[x].Show();
                }
                catch
                {
                    _brbook[x].Hide();
                    end = index;

                }
            }
        }
        public void forinitiate()
        {

            for (int x = 0; x <= 7; x++)
            {
                _brbook[x] = new borrowedBooks() { TopLevel = false };
                flowLayoutPanel1.Controls.AddRange(_brbook);
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
