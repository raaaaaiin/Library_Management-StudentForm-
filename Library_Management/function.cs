using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    class function : connection
    {
        dataHandler _cache = new dataHandler();
        private Boolean authuser = false, authpass = false;
        public int laststdindex = 0;
        public string role = "";
        public static string id = "";
        public string returnid()
        {
            return id;
        }
        public void fill(string column, System.Windows.Forms.ComboBox selected, string table)
        {

            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Select * from " + table + "";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[column].ToString().Length != 0)
                    {
                        selected.Items.Add(reader[column].ToString());
                    }
                    else
                    {

                    }


                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        public void logIn(String username, string password)
        {
            int counter = 0;
            try
            {
                
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Select * from user_acc where Username = '" + username + "' and Password = '" + password + "'";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    role = (reader["role"].ToString());
                    id = (reader["UID"].ToString());
                    counter++;

                }
                con.Close();
            }
            catch 
            {

                con.Close();
            }
            if (counter == 1)
            {
                authpass = true;
                authuser = true;
            }
            else
            {
                authpass = false;
                authuser = false;
            }
            
        }
        public bool authentication()
        {
                return authuser == true && authpass == true;
        }
        public void loadDataBook()
        {
            readBook();

            int counter = 0;
            try
            {

                con.Open();
                com = con.CreateCommand();
                com.CommandText = "Select ID, Title, Author, Page,Information, Quantity from book order by ID desc";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    _cache.populatebook_info(counter, reader[1].ToString(), 0);
                    _cache.populatebook_info(counter, reader[2].ToString(), 1);
                    _cache.populatebook_info(counter, reader[0].ToString(), 2);
                    _cache.populatebook_info(counter, reader[3].ToString(), 3);
                    _cache.populatebook_info(counter, reader[5].ToString(), 4);
                    _cache.populatebook_info(counter, reader[4].ToString(), 5);

                    counter++;
                }
                con.Close();

            }
            catch 
            {
                con.Close();

            }
        }
        public void overWritedatabook(string search)
        {
            overWritereadBook(search);

            int counter = 0;
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "Select ID, Title, Author, Page, Information, Quantity from book where ID = '%" + search + "%'or Title like '%" + search + "%' or Author = '%" + search + "%'";
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                _cache.populatebook_info(counter, reader[1].ToString(), 0);
                _cache.populatebook_info(counter, reader[2].ToString(), 1);
                _cache.populatebook_info(counter, reader[0].ToString(), 2);
                _cache.populatebook_info(counter, reader[3].ToString(), 3);
                _cache.populatebook_info(counter, reader[5].ToString(), 4);
                _cache.populatebook_info(counter, reader[4].ToString(), 5);


                counter++;
            }
            con.Close();
        }
        public void overWritereadBook(string search)
        {
            int counter = 0;
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandText = "Select ID, Title, Author, Page, Information, Quantity from book where ID = '%" + search + "%' or Title like '%" + search + "%' or Author = '%" + search + "%'";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    counter++;
                }
            }
            catch 
            {
                con.Close();
            }
            con.Close();
            _cache.setbook_info(counter);
        }
        public void readUser()
        {
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Select * from stud_info user_acc where UID = '" + id + "'";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    _cache.populateuser_std(0, reader[0].ToString());
                    _cache.populateuser_std(1, reader[1].ToString());
                    _cache.populateuser_std(2, reader[2].ToString());
                    _cache.populateuser_std(3, reader[3].ToString());
                    _cache.populateuser_std(4, reader[4].ToString());
                    _cache.populateuser_std(5, reader[5].ToString());
                    _cache.populateuser_std(6, reader[6].ToString());
                    _cache.populateuser_std(7, reader[7].ToString());

                }
                con.Close();
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Select * from user_acc where UID = '" + id + "'";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    _cache.populateuser_std(8, reader[1].ToString());
                    _cache.populateuser_std(9, reader[2].ToString());
                }
                con.Close();

            }
            catch
            {
                con.Close();
            }
        }
        public void updateInfo(string user, string pass)
        {
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Update user_acc set Username = '" + user + "', Password = '" + pass + "' where UID = '"+id+"'";
                com.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                con.Close();
            }
        }
        public void readBook()
        {
            int counter = 0;
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandText = "Select ID from book order by ID desc";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    counter++;
                }
            }
            catch 
            {
                con.Close();
            }
            con.Close();
            _cache.setbook_info(counter);
        }
        public void getDuration(string credscore, Bunifu.UI.WinForms.BunifuDropdown durationlist)
        {
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "SELECT duration FROM borrow_duration where creditscore >= '" + credscore + "' order by duration desc";
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                durationlist.Items.Add(reader[0].ToString());
            }
            con.Close();
        }
        public string getCredscore()
        {
            string cred = "";
            con.Open();
            com = con.CreateCommand();
            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = "Select credit_score from stud_status where id = '" + _cache.returnuser_std(0) + "'";
            reader = com.ExecuteReader();
            while (reader.Read())
            {

                cred = (reader[0].ToString());



            }
            con.Close();
            return cred;
        }
        public void bookOrder(string book_name, string boolfalse, string bookID, string bdate, string rdate,string duration,string qty)
        {
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Insert into book_records(Student_id, Borrowed_book, isReturned, book_id, Borrowed_date, Expected_return, borrow_duration) values('" + id + "','" + book_name + "','" + boolfalse + "','" + bookID + "','" +bdate+ "','" + rdate + "','" + duration + "')";
                com.ExecuteNonQuery();
                con.Close();
                int qt = Convert.ToInt32(qty);
                string updtQTY = (qt - 1).ToString();
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Update book set Quantity = '" + updtQTY + "'where ID = '"+bookID+"'";
                com.ExecuteNonQuery();
                con.Close();
                
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }
        public void showBrwBook()
        {
            readbrwBook();
            try
            {
                int counter = 0;
                string blflse = "false";
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Select book_id,book.Author, book_records.Borrowed_book from book inner join book_records on book.ID = book_records.book_id where Student_id = '" + id + "' and isReturned ='"+blflse+ "'";
                reader = com.ExecuteReader();
                while (reader.Read())
                {

                    _cache.populatebook_info(counter, reader[0].ToString(), 2);
                    _cache.populatebook_info(counter, reader["Borrowed_book"].ToString(), 0);
                    _cache.populatebook_info(counter, reader["Author"].ToString(), 1);
                    counter++;
                }
                con.Close();
                
            }
            catch 
            {
                con.Close();
            }
        }
        public void readbrwBook()
        {
            int counter = 0;
            string blflse = "false";
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandText = "Select book_id,book.Author, book_records.Borrowed_book from book inner join book_records on book.ID = book_records.book_id where Student_id = '" + id + "' and isReturned ='" + blflse + "'";
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    counter++;
                }
                con.Close();
               
            }
            catch 
            {
                con.Close();
            }
            con.Close();
            _cache.setbook_info(counter);
        }
        public void returnBook(string booltrue,string bookID)
        {
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Update book_records set isReturned = '" + booltrue + "' where book_id = '" + bookID + "' and Student_id ='" +id+"'";
                com.ExecuteNonQuery();
                con.Close();
            }
            catch 
            {
                con.Close();
            }
        }
        public void getingDate(string bookID)
        {
            
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandText = "Select Expected_return, Borrowed_date from book_records where Student_id = '"+id+"'and book_id = '"+bookID+"'";
                reader = com.ExecuteReader();
                while (reader.Read())
                {

                    _cache.brbook_info(0, reader["Borrowed_date"].ToString());
                    _cache.brbook_info(1, reader["Expected_return"].ToString());
                }
                con.Close();

            }
            catch 
            {
                con.Close();
            }
        }
        public void updatecred(string cred)

        {
            try
            {
                con.Open();
                com = con.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Update stud_status set credit_score = (`credit_score` - '"+cred+"') where id = '"+ id +"'";
                com.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                con.Close();
            }
        }

    }
    

}




 