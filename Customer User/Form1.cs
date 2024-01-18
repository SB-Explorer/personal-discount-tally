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

namespace Customer_User
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SBA2001;Initial Catalog=MYDB;Integrated Security=True;Encrypt=False");
            con.Open();
            if (textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select ProductName,OriginalPrice,DiscountPrice,FinalPrice from STOCK where ProductId=@ProductId ", con);
                cmd.Parameters.AddWithValue("@ProductId", int.Parse(textBox1.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox2.Text = da.GetValue(0).ToString();
                    textBox3.Text = da.GetValue(1).ToString();
                    textBox4.Text = da.GetValue(2).ToString();
                    textBox5.Text = da.GetValue(3).ToString();
                }
                con.Close();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
            {
                textBox9.Text = (Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[7];
            arr[0] = textBox1.Text;
            arr[1] = textBox2.Text;
            arr[2] = textBox6.Text;
            arr[3] = textBox3.Text;
            arr[4] = textBox4.Text;
            arr[5] = textBox5.Text;
            arr[6] = textBox9.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);


            textBox8.Text = (Convert.ToDouble(textBox8.Text) + (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox6.Text))).ToString();
            textBox7.Text = (Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox9.Text)).ToString();



        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Length > 0)
            {
                textBox11.Text = (Convert.ToDouble(textBox7.Text) - Convert.ToDouble(textBox10.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
