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
    public partial class borrowedBooks : Form
    {
        Color native = Color.FromArgb(50, 50, 50);
        static int hakdok = 0;
        public borrowedBooks()
        {
            InitializeComponent();
            
        }
        public void showInfo(string title)
        {
            label1.Text = title;
        }

        private void form_hover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gold;
        }

        private void form_leave(object sender, EventArgs e)
        {
            panel1.BackColor = native;
        }

        private void label_hover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gold;
        }

        private void label_leave(object sender, EventArgs e)
        {
            panel1.BackColor = native;
        }
    }
}
