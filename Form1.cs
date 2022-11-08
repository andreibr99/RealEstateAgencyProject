using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
        }

        private void button_Agent_Click(object sender, EventArgs e)
        {
            FormAgentLoginRegister agentLoginRegister = new FormAgentLoginRegister();
            agentLoginRegister.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
