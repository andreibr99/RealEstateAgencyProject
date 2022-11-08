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
    public partial class LogIn : Form
    {
        SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-7UTUNVD\\SQLEXPRESS; Initial Catalog=UserRegistrationDB.bacpac ;Integrated Security=True");
        public LogIn()
        {

            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Va rugam sa completati campurile Username si Parola");
            else
            {
                string query = "SELECT * from tblUser WHERE Username = '" + textBox1.Text.Trim() + "'and Password = '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, myCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    Form4 fourthForm = new Form4();
                    this.Hide();
                    fourthForm.Show();
                }
                else
                {
                    MessageBox.Show("Verifica Username-ul sau Parola!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}