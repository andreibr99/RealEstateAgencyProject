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

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-7UTUNVD\\SQLEXPRESS; Initial Catalog=UserRegistrationDB.bacpac ;Integrated Security=True");
        //string connectionString = @"Data Source=USER-PC\\SQLEXPRESS; Initial Catalog=ProiectII ;Integrated Security=True";
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox6.Text == "")
                MessageBox.Show("Va rugam sa completati campurile Username si Parola");
            else if (textBox6.Text != textBox7.Text)
                MessageBox.Show("Parolele nu sunt identice");
            else
            {
                using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-7UTUNVD\\SQLEXPRESS; Initial Catalog=UserRegistrationDB.bacpac ;Integrated Security=True"));
                {
                    myCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", myCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Adress", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textBox6.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Inregistrarea a avut succes");
                    Clear();

                }
            }
        }
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text =textBox7.Text= "";
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
