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
    public partial class booksDesc : Form
    {
        dataHandler _cache = new dataHandler();
        
        confirmBorrow _cborrow;
        private static string booknme, auth, bookId, pge, ctg, qty, inf;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public booksDesc(string book_name, string author, string id, string page, string quan, string info)
        {
            InitializeComponent();
            booknme = book_name;
            auth = author;
            bookId = id;
            pge = page;
            
            qty = quan;
            inf = info;
            forInf();

           
        }
        public void forInf()
        {
            Title.Text = booknme;
            Author.Text = auth;
            page.Text = pge;
            category.Text = ctg;
            description.Text = inf;
            qty2.Text = qty;
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = path.Remove(path.LastIndexOfAny(new char[] { '\\' }, path.LastIndexOf('\\') - 0));
            path += '\\';
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {

                pictureBox1.Image = Image.FromFile(path + "Books\\" + bookId + ".jpeg");
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(path + "Books\\default.jpeg");
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            _cborrow = new confirmBorrow(booknme,bookId,qty);
            _cborrow.ShowDialog();
        }
    }
}
