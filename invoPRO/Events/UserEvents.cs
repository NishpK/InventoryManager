using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using invoPRO.Entities;

namespace invoPRO.Events
{
    internal class UserEvents
    {
        DBConnection Con = new DBConnection();

        public int LoginUser(string username, string password)
        {
            try
            {
                String Myquery = "SELECT * FROM UserTbl WHERE Uname= '" + username + "' AND Upassword= '" + password + "'";
                Con.connectDB();
                SqlDataAdapter sda = new SqlDataAdapter(Myquery, Con.connection);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);


                if (dtable.Rows.Count == 1) { return 1; }

                else { return 0;}

            }
            catch (Exception ex)
            { 
                string message  = "An error occured : " + ex.ToString();
                MessageBox.Show(message);
                return 2;
            }

            finally
            {
                Con.closeConnectDB();
            }
        }

        public int RegisterUser(User user)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl (FirstName, LastName, Uname, Upassword) VALUES(@FirstName,@LastName,@Uname,@Upassword)", Con.connection);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Uname", user.Username);
                cmd.Parameters.AddWithValue("@Upassword", user.Password);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();

                return 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return 0;
            }
        }

        public int UpdateUser(User user)
        {
            try
            {
               Con.connectDB();
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET FirstName = @FirstName, LastName = @LastName, Upassword = @Upassword WHERE Uname = @Uname", Con.connection);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Upassword", user.Password);
                cmd.Parameters.AddWithValue("@Uname", user.Username);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();

                return 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int DeleteUser(User user)
        {
            try
            {
                Con.connectDB();
                SqlCommand cmd = new SqlCommand("DELETE FROM UserTbl WHERE Uname = @Uname", Con.connection);
                cmd.Parameters.AddWithValue("@Uname", user.Username);
                cmd.ExecuteNonQuery();
                Con.closeConnectDB();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
