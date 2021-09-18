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
    public partial class Books : Form
    {
        menu _main;
        function _func = new function();
        dataHandler __cache = new dataHandler();
        Bitmap objBitmap;
        Color changer;
        public string id = "";
        public string title = "";
        public string author = "";
        public string category = "";
        public string information = "";
        public int index = 0;
        public static string identify = "";
        
        public void setidentify(String ident)
        {
            identify = ident;
        }
        
        public Books(menu ths)
        {
            InitializeComponent();

            _main = ths;
            //bunifuPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //bunifuPictureBox1.BorderRadius = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void process()
        {
           
            label1.Text = title;
            setauth.Text = author;
            setcat.Text = category;
            infos.Text = information;
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = path.Remove(path.LastIndexOfAny(new char[] { '\\' }, path.LastIndexOf('\\') - 0));

            path += '\\';
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                objBitmap = new Bitmap(Image.FromFile(path + "Books\\" + id + ".jpeg"), new Size(150, 150));

            }
            catch
            {
                objBitmap = new Bitmap(Image.FromFile(path + "Books\\default.jpeg"), new Size(150, 150));

            }
            pictureBox1.Image = objBitmap;


        }
        //public void Show_Info(string book_name,string author, string id,string page,string quan, string info)
        //{
        //    this.book = book_name;
        //    this.auth = author;
        //    this.id = id;
        //    this.pg = page;

        //    this.qty = quan;
        //    this.inf = info;
        //    string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        //    path = path.Remove(path.LastIndexOfAny(new char[] { '\\' }, path.LastIndexOf('\\') - 0));

        //    path += '\\';
        //    //bunifuPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    try
        //    {
        //        objBitmap = new Bitmap(Image.FromFile(path + "Books\\" + id + ".jpeg"), new Size(150, 150));

        //    }
        //    catch
        //    {
        //        objBitmap = new Bitmap(Image.FromFile(path + "Books\\default.jpeg"), new Size(150, 150));

        //    }
        //    //bunifuPictureBox1.Image = objBitmap;


        //}
        

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void clicky(object sender, EventArgs e)
        {
            if (identify.Equals("Return"))
            {
                confirmReturn _cReturn = new confirmReturn(this.id, _main);
                _cReturn.ShowDialog();
            }
            else
            {
                
                booksDesc bdesc = new booksDesc(title, author, id, __cache.returnbook_info(index,3), __cache.returnbook_info(index, 4), __cache.returnbook_info(index, 5));
                bdesc.ShowDialog();
            }
        }



        private void Goldy(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gold;
        }

        private void Plainey(object sender, EventArgs e)
        {
            panel2.BackColor = changer;
        }

        private void book_click(object sender, EventArgs e)
        {
            
        }

        private void form_click2(object sender, EventArgs e)
        {
           
        }
        public void ifClick()
        {

            
            
        }
        
        public void display(string id, string title, string author)
        {
            label1.Text = title;
            setauth.Text = author;
            this.id = id;

        }
    }
}
