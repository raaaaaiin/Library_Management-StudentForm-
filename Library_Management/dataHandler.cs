using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class dataHandler
    {
      
        private static string[,] book_info;
        private static string[] borrowed_book = new string[2];
        private static string[] slctd_book = new string[6];
        private static string[] user_std = new string[12];

        private string selected_stdId;
        
        public string selected_stdID
        {

            get { return selected_stdId; }

            set { selected_stdId = value; }

        }
        public int returnlength()
        {
            return book_info.GetLength(0);
        }
        public void populateuser_std(int index, string info)
        {
            user_std[index] = info;
        }
        public string returnuser_std(int index)
        {
            return user_std[index];
        }
       
        public void setbook_info(int counter)
        {
            book_info = new string[counter, 7];
        }
        public void populatebook_info(int counter, string data, int index)
        {
            book_info[counter, index] = data;
        }
        public string returnbook_info(int counter, int index)
        {
            return book_info[counter, index];
        }
        public void brbook_info(int counter, string data)
        {
            borrowed_book[counter] = data;
        }
        public string returnbrbook_info(int counter)
        {
            return borrowed_book[counter];
        }



    }
}
