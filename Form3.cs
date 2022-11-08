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
    public partial class Form3 : Form
    {
        SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-7UTUNVD\\SQLEXPRESS; Initial Catalog=AgentieDB ;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataAdapter adapter;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Agentie", myCon);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_oferte_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Oferta", myCon);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_apartamente_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Spatiu", myCon);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_detalii_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Tip", myCon);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
