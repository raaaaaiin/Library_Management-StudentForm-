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
    public partial class stdprevilages : Form
    {
        Books _book;
        dataHandler _cache = new dataHandler();
        Bitmap objBitmap;
        bool[] isPressed = { false, false, false, false, false, false, false, false };
        bool isResetable = false;
        menu _main;
        function _func = new function();
        
        public stdprevilages(menu ths)
        {
            InitializeComponent();
            _main = ths;

            bunifuPictureBox2.BorderRadius = 25;
            _book = new Books(_main);
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = path.Remove(path.LastIndexOfAny(new char[] { '\\' }, path.LastIndexOf('\\') - 0));

            path += '\\';
            bunifuPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                objBitmap = new Bitmap(Image.FromFile(path + "Images\\" + _func.returnid() + ".jpeg"), new Size(150, 150));

            }
            catch
            {
                objBitmap = new Bitmap(Image.FromFile(path + "Images\\default.jpeg"), new Size(150, 150));

            }
            bunifuPictureBox2.Image = objBitmap;

        }
        public void update()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = path.Remove(path.LastIndexOfAny(new char[] { '\\' }, path.LastIndexOf('\\') - 0));

            path += '\\';
            bunifuPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                objBitmap = new Bitmap(Image.FromFile(path + "Images\\" + _func.returnid() + ".jpeg"), new Size(150, 150));

            }
            catch
            {
                objBitmap = new Bitmap(Image.FromFile(path + "Images\\default.jpeg"), new Size(150, 150));

            }
            bunifuPictureBox2.Image = objBitmap;

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            if (isPressed[0] == false)
            {
                reset();
                
                isPressed[0] = true;


            }


        }
        private void lightup(System.Windows.Forms.Panel Lit)
        {

            panelsearch.BackColor = Color.FromArgb(100, 32, 32, 32);
            panelreturn.BackColor = Color.FromArgb(100, 32, 32, 32);
            panelprofile.BackColor = Color.FromArgb(100, 32, 32, 32);
            panellogout.BackColor = Color.FromArgb(100, 32, 32, 32);
            Lit.BackColor = Color.Gold;

        }
        private void lightup()
        {

            panelsearch.BackColor = Color.FromArgb(100, 32, 32, 32);
            panelreturn.BackColor = Color.FromArgb(100, 32, 32, 32);
            panelprofile.BackColor = Color.FromArgb(100, 32, 32, 32);
            panellogout.BackColor = Color.FromArgb(100, 32, 32, 32);

        }

        private void previlages_Load(object sender, EventArgs e)
        {
            lightup();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

            if (isPressed[1] == false)
            {
                reset();
                isPressed[1] = true;


            }

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

            if (isPressed[2] == false)
            {
                reset();
                isPressed[2] = true;

            }
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            lightup(panelsearch);
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {


            if (isPressed[4] == false)
            {
                reset();
                isPressed[4] = true;


            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            _book.setidentify("Return");
            lightup(panelreturn);
            _func.showBrwBook();
            _main.forshow();
            _main.hidesearch(false);
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            lightup(panelprofile);
            profileForm _pForm = new profileForm();
            _pForm.ShowDialog();
            
        }


        private void Logout_Click_1(object sender, EventArgs e)
        {
            logIn _new = new logIn();
            _new.Show();
            _main.Close();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            lightup(panelsearch);
            _book.setidentify("Search");
            _func.loadDataBook();
            _main.forshow();
            _main.hidesearch(true);
        } 

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            for (int i = 0; i != isPressed.Length; i++)
            {
                isPressed[i] = false;
            }
        }
    }
}
