﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace invoPRO
{
    public partial class SupplierView : Form
    {


        public SupplierView()
        {
            InitializeComponent();
            tableload();
        }

        void clearTxtBoxes()
        {
            sid.Text = string.Empty;
            sname.Text = string.Empty;
            pname.Text = string.Empty;
            saddress.Text = string.Empty;
            stel.Text = string.Empty;
            tableload();
        }

   
        void tableload()
        {
            DBConnection Con = new DBConnection();
            try
            {
                // database table load to the tableGV
                Con.connectDB();
                String Myquery = "SELECT * FROM SupplierTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con.connection);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                usersgv.DataSource = ds.Tables[0];
                Con.closeConnectDB();

            }
            catch
            {

            }
        }

        void Guselect()
        {
            sid.Text = usersgv.SelectedRows[0].Cells[0].Value.ToString();
            sname.Text = usersgv.SelectedRows[0].Cells[1].Value.ToString();
            pname.Text = usersgv.SelectedRows[0].Cells[2].Value.ToString();
            saddress.Text = usersgv.SelectedRows[0].Cells[3].Value.ToString();
            stel.Text = usersgv.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void usersgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           Guselect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id = sid.Text;
            string name = sname.Text;
            string address = saddress.Text;
            string telnumber = stel.Text;

            Supplier supplier= new Supplier(id,name, address, telnumber);
            SupplierEvents supplierEvents = new SupplierEvents();

            if (supplierEvents.RegisterSupplier(supplier)==1)
            {
                clearTxtBoxes();
                MessageBox.Show("user successfully added");
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id=sid.Text;
            string name=sname.Text;

            string address=saddress.Text;
            string telnumber=stel.Text;

            Supplier supplier = new Supplier(id ,name,address,telnumber);
            SupplierEvents supplierEvents = new SupplierEvents();
            

            //update
            if (sid.Text == "")
            {
                MessageBox.Show("Enter Supplier id");
            }
            else
            {

                if(supplierEvents.UpdateSupplier(supplier) == 1)
                {
                    MessageBox.Show("Supplier has been updated");
                    clearTxtBoxes();
                }
                


            }
        }
        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
            string id = sid.Text;
            string name = sname.Text;
            string address = saddress.Text;
            string telnumber = stel.Text;

            
            Supplier supplier = new Supplier(id, name, address, telnumber);
            SupplierEvents supplierEvents = new SupplierEvents();

            if (sid.Text == "")
            {
                MessageBox.Show("Enter customer id");

            }
            else if(supplierEvents.DeleteSupplier(supplier)==1)
            {
                MessageBox.Show("supplier successfully deleted");
                clearTxtBoxes();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)

            //search button, write this so in a combo box produt would be loaded and can be searched
        {
            if (search.Text == "")
            {
                MessageBox.Show("Enter product name");

            }
            //else
            //{
            //    try
            //    {
            //        Con.Open();
          



            //        SqlCommand cmd = new SqlCommand("SELECT * FROM SupplierTbl WHERE Sproduct=@sprod", Con);
            //        cmd.Parameters.AddWithValue("@sprod", search.Text);
            //        cmd.ExecuteNonQuery();

            //        SqlCommandBuilder builder = new SqlCommandBuilder();
            //        var ds = new DataSet();
            //        cmd.Fill(ds);
            //        usersgv.DataSource = ds.Tables[0];
            //        Con.Close();


            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message);
            //    }
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearTxtBoxes();

        }
    }
}

