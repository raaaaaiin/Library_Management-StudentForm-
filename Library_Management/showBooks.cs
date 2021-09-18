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
    public partial class showBooks : Form
    {
        public int index = 0;
        public int end = -1;
        function _func = new function();
        Books[] _book = new Books[15];
        dataHandler _cache = new dataHandler();
        menu _main;


        public showBooks(menu ths)
        {
            InitializeComponent();
            _main = ths;

        }

        public void forshow()
        {
            for (int x = 0; x <= 14; x++)
            {
                try
                {

                    _book[x].title = _cache.returnbook_info(index, 0);
                    _book[x].author = _cache.returnbook_info(index, 1);
                    _book[x].id = _cache.returnbook_info(index, 2);
                    //_book[x].Show_Info(__cache.returnbook_info(index, 0), __cache.returnbook_info(index, 1), __cache.returnbook_info(index, 2), __cache.returnbook_info(index, 3), __cache.returnbook_info(index, 4), __cache.returnbook_info(index, 5));
                    index++;
                    _book[x].Show();
                }
                catch
                {
                    _book[x].Hide();
                    end = index;

                }
            }
        }
        public void forinitiate()
        {

            for (int x = 0; x <= 14; x++)
            {
                flowLayoutPanel1.Hide();
                _book[x] = new Books(_main) { TopLevel = false };
                flowLayoutPanel1.Controls.AddRange(_book);
                flowLayoutPanel1.Show();


            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }


        public void fornext()
        {
            for (int x = 0; x <= 5; x++)
            {
                try
                {

                    _book[x].title = _cache.returnbook_info(index, 0);
                    _book[x].author = _cache.returnbook_info(index, 1);
                    _book[x].id = _cache.returnbook_info(index, 2);
                    _book[x].category = "Blank";
                    _book[x].index = index;
                    _book[x].information = _cache.returnbook_info(index, 5);
                    //_book[x].Show_Info(__cache.returnbook_info(index, 0), __cache.returnbook_info(index, 1), __cache.returnbook_info(index, 2), __cache.returnbook_info(index, 3), __cache.returnbook_info(index, 4), __cache.returnbook_info(index, 5));
                    index++;
                    _book[x].process();
                    _book[x].Show();

                }
                catch
                {
                    _book[x].Hide();
                    end = index;

                }
            }

        }

        private void Previous_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void showBooks_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {


            _func.overWritedatabook(search.Text);
            index = 0;
            fornext();
            
        }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            _func.overWritedatabook(search.Text);
            index = 0;
            fornext();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (index != _cache.returnlength())
            {
                fornext();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (index >= 5 && index <= 11)
            {
                index = 0;
                fornext();
            }
            else if (index >= 12)
            {
                index -= 6 * 2;
                fornext();
            }
            else
            {

            }
        }
        public void searcbar(bool indicator)
        {
            if(indicator == true)
            {
                search.Show();
            }
            else
            {
                search.Hide();
            }
        }
    }
}
