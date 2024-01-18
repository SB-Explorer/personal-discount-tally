using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Abans_System
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //1.address of SQL server and database 
            string ConnectionString = "Data Source=SBA2001;Initial Catalog=MYDB;Integrated Security=True;Encrypt=False";
            //2.establish connection 
            SqlConnection con = new SqlConnection(ConnectionString);
            //3.open connection 
            con.Open();
            //4.prepare query 
            string ProductId = tbProductId.Text;
            string ProductName = tbProductName.Text;
            string OriginalPrice = tbOriginalPrice.Text;
            string DiscountPercentage = tbDiscountPercentage.Text;
            string DiscountPrice = tbDiscountPrice.Text;
            string FinalPrice = tbFinalPrice.Text;
            string Query = " INSERT INTO STOCK (ProductId,ProductName,OriginalPrice,DiscountPercentage,DiscountPrice,FinalPrice) VALUES ('" + ProductId + "','" + ProductName + "','" + OriginalPrice + "','" + DiscountPercentage + "','" + DiscountPrice + "','" + FinalPrice + "')";
            //5.execute query 
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            //6.close connection 
            con.Close();

            MessageBox.Show("Data has been saved");
        }
    }
}
