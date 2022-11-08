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
    public partial class Form4 : Form
    {
        SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-7UTUNVD\\SQLEXPRESS; Initial Catalog=AgentieDB ;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataAdapter adapter;
        WindowsFormsApp1.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void tabPage1_Click(object sender, EventArgs e)
        {
            //Agentie
            myCon.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Agentie", myCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            myCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_agentiiNume.Text != "" && textBox_agentiiEmail.Text != "")
            {

                service.InsertAgentii(textBox_agentiiNume.Text.ToString(), textBox_agentiiEmail.Text.ToString());
                textBox_agentiiNume.Text = "";
                textBox_agentiiEmail.Text = "";
                textBox_agentiiId.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost inserate!");
                dt = (DataTable)dataGridView1.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Agentie", myCon);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                myCon.Close();
            }
            else MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void button_agentiiIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_agentiiStergere_Click(object sender, EventArgs e)
        {
            try
            {
                service.DeleteAgentii(Int16.Parse(textBox_agentiiId.Text.ToString()));
                textBox_agentiiId.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost șterse!");
                dt = (DataTable)dataGridView1.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Agentie", myCon);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                myCon.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button_agentiiModificare_Click(object sender, EventArgs e)
        {
            try
            {
                service.UpdateAgentii(Int16.Parse(textBox_updateId.Text.ToString()), textBox_updateNume.Text.ToString(), textBox_updateEmail.Text.ToString());
                textBox_updateId.Text = "";
                textBox_updateNume.Text = "";
                textBox_updateEmail.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost modificate!");
                dt = (DataTable)dataGridView1.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Agentie", myCon);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                myCon.Close();
            }
            catch (Exception )
            {

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           // Spatiu
            myCon.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Spatiu", myCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            myCon.Close();
        }

        private void button2_insertSpatii_Click(object sender, EventArgs e)
        {
            if (textBox_SpatiiAdresa.Text != "" && textBox_insertSpatiiZona.Text != "" && textBox_insertSpatiiSupraf.Text != "" && textBox_insertSpatiiIdTip.Text != "")
            {

                service.InsertSpatiu(textBox_SpatiiAdresa.Text.ToString(), Int16.Parse(textBox_insertSpatiiZona.Text.ToString()), Int16.Parse(textBox_insertSpatiiSupraf.Text.ToString()), Int16.Parse(textBox_insertSpatiiIdTip.Text.ToString()));
                textBox_SpatiiAdresa.Text = "";
                textBox_insertSpatiiZona.Text = "";
                textBox_insertSpatiiSupraf.Text = "";
                textBox_insertSpatiiIdTip.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost inserate!");
                dt = (DataTable)dataGridView2.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Spatiu", myCon);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                myCon.Close();
            }
            else MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            //Oferta
            myCon.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Oferta", myCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;
            myCon.Close();
        }

        private void button_insertOferta_Click(object sender, EventArgs e)
        {
            if (textBox_insertOfertaIdAgentie.Text != "" && textBox_insertOfertaIdSpatiu.Text != "" && comboBox_insertOferteVanzare.Text != "" && textBox_insertOfertaPret.Text != "" && comboBox_insertOferteMoneda.Text != "")
            {

                service.InsertOferta(Int16.Parse(textBox_insertOfertaIdAgentie.Text.ToString()), Int16.Parse(textBox_insertOfertaIdSpatiu.Text.ToString()), comboBox_insertOferteVanzare.Text.ToString(), Int32.Parse(textBox_insertOfertaPret.Text.ToString()), comboBox_insertOferteMoneda.Text.ToString());
                textBox_insertOfertaIdAgentie.Text = "";
                textBox_insertOfertaIdSpatiu.Text = "";
                comboBox_insertOferteVanzare.Text = "";
                textBox_insertOfertaPret.Text = "";
                comboBox_insertOferteMoneda.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost inserate!");
                dt = (DataTable)dataGridView3.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Oferta", myCon);
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
                myCon.Close();
            }
            else MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            //Detalii
            myCon.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Tip", myCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;
            myCon.Close();
        }

        private void button_spatiiSterge_Click(object sender, EventArgs e)
        {
            try
            {
                service.DeleteSpatiu(Int16.Parse(textBox_updateSpatiiIdSpatiu.Text.ToString()));
                textBox_updateSpatiiIdSpatiu.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost șterse!");
                dt = (DataTable)dataGridView2.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Spatiu", myCon);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                myCon.Close();
            }
            catch (Exception )
            {

            }
        }

        private void button_spatiiModifica_Click(object sender, EventArgs e)
        {
            try
            {
                service.UpdateSpatiu(Int16.Parse(textBox_updateSpatiiIdSpatiu.Text.ToString()), textBox_updateSpatiiAdresa.Text.ToString(), Int16.Parse(textBox_updateSpatiiZona.Text.ToString()), Int16.Parse(textBox_updateSpatiiSupraf.Text.ToString()), Int16.Parse(textBox_updateSpatiiIdTip.Text.ToString()));
                textBox_updateSpatiiIdSpatiu.Text = "";
                textBox_updateSpatiiAdresa.Text = "";
                textBox_updateSpatiiZona.Text = "";
                textBox_updateSpatiiSupraf.Text = "";
                textBox_updateSpatiiIdTip.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost modificate!");
                dt = (DataTable)dataGridView2.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Spatiu", myCon);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                myCon.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button_spatiiIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_iesireOferte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_stergereOferte_Click(object sender, EventArgs e)
        {
            try
            {
                service.DeleteOferta(Int16.Parse(textBox_insertOfertaIdSpatiu.Text.ToString()), Int16.Parse(textBox_insertOfertaIdAgentie.Text.ToString()));
                textBox_insertOfertaIdSpatiu.Text = "";
                textBox_insertOfertaIdAgentie.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost șterse!");
                dt = (DataTable)dataGridView3.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Oferta", myCon);
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
                myCon.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button_modificaOferte_Click(object sender, EventArgs e)
        {
            try
            {
                service.UpdateOferta(Int16.Parse(textBox_updateOferteIdAgentie.Text.ToString()), Int16.Parse(textBox_updateOferteIdSpatiu.Text.ToString()), comboBox_updateOferteVanzare.Text.ToString(), Int32.Parse(textBox_updateOfertePret.Text.ToString()), comboBox_updateOferteMoneda.Text.ToString());
                textBox_updateOferteIdAgentie.Text = "";
                textBox_updateOferteIdSpatiu.Text = "";
                comboBox_updateOferteVanzare.Text = "";
                textBox_updateOfertePret.Text = "";
                comboBox_updateOferteMoneda.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost modificate!");
                dt = (DataTable)dataGridView3.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Oferta", myCon);
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
                myCon.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button_DetaliiInsert_Click(object sender, EventArgs e)
        {
            if (comboBox_insertDetaliiDenumire.Text != "" && textBox_insertDetaliiCaract.Text != "")
            {

                service.InsertTip(comboBox_insertDetaliiDenumire.Text.ToString(), textBox_insertDetaliiCaract.Text.ToString());
                comboBox_insertDetaliiDenumire.Text = "";
                textBox_insertDetaliiCaract.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost inserate!");
                dt = (DataTable)dataGridView4.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Tip", myCon);
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
                myCon.Close();
            }
            else MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void button_detaliiSterge_Click(object sender, EventArgs e)
        {
            try
            {
                service.DeleteTip(Int16.Parse(textBox_insertDetaliiIdTip.Text.ToString()));
                textBox_insertDetaliiIdTip.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost șterse!");
                dt = (DataTable)dataGridView4.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Tip", myCon);
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
                myCon.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button_detaliiUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                service.UpdateTip(Int16.Parse(textBox_updateDetaliiIdTip.Text.ToString()), comboBox_updateDetaliiDenumire.Text.ToString(), textBox_updateDetaliiCaract.Text.ToString());
                textBox_updateDetaliiIdTip.Text = "";
                comboBox_updateDetaliiDenumire.Text = "";
                textBox_updateDetaliiCaract.Text = "";
                DataTable dt = new DataTable();
                MessageBox.Show("Datele au fost modificate!");
                dt = (DataTable)dataGridView4.DataSource;
                if (dt != null)
                    dt.Clear();
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Tip", myCon);
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
                myCon.Close();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_updateId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_updateNume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_updateEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_updateSpatiiAdresa.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_updateSpatiiZona.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_updateSpatiiSupraf.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_updateSpatiiIdTip.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_updateSpatiiIdSpatiu.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_updateOferteIdAgentie.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_updateOferteIdSpatiu.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox_updateOferteVanzare.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_updateOfertePret.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox_updateOferteMoneda.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_updateDetaliiIdTip.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox_updateDetaliiDenumire.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_updateDetaliiCaract.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
