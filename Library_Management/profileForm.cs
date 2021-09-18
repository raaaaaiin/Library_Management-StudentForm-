using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class profileForm : Form
    {
        fileHandler _file = new fileHandler();
        dataHandler _cache = new dataHandler();
        Bitmap objBitmap;
        function _func = new function();
        public profileForm()
        {
            InitializeComponent();
            profileInfo();

        }
        public void profileInfo()
        {
            _func.readUser();
            studId.Text = _cache.returnuser_std(0);
            firstName.Text = _cache.returnuser_std(1);
            middleName.Text = _cache.returnuser_std(2);
            lastName.Text = _cache.returnuser_std(3);
            Suffix.Text = _cache.returnuser_std(4);
            studlvl.Text = _cache.returnuser_std(5);
            studSec.Text = _cache.returnuser_std(6);
            schlyr.Text = _cache.returnuser_std(7);
            userName.Text = _cache.returnuser_std(8);
            passWord.Text = _cache.returnuser_std(9);
            CrdtScr.Text = _func.getCredscore();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _func.updateInfo(userName.Text, passWord.Text);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            string dest = "";
            DialogResult result = openFileDialog1.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {
                    string source = openFileDialog1.FileName;
                    Bitmap resize = new Bitmap(Image.FromFile(source), new Size(150, 150));
                    dest = _file.path + "Images\\" + _func.returnid() + ".jpeg";
                    resize.Save(dest, ImageFormat.Jpeg);
                }
            }
            catch
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                string source = openFileDialog1.FileName;
                Bitmap resize = new Bitmap(Image.FromFile(source), new Size(150, 150));
                dest = _file.path + "Images\\" + _func.returnid() + ".jpeg";
                File.Delete(dest);
                resize.Save(dest, ImageFormat.Jpeg);
            }
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = path.Remove(path.LastIndexOfAny(new char[] { '\\' }, path.LastIndexOf('\\') - 0));

            path += '\\';
            bunifuPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                objBitmap = new Bitmap(Image.FromFile(path + "Images\\" + _func.returnid() + ".jpeg"), new Size(150, 150));

            }
            catch
            {
                objBitmap = new Bitmap(Image.FromFile(path + "Images\\default.jpeg"), new Size(150, 150));

            }
            bunifuPictureBox1.Image = objBitmap;

        }
    }
}
