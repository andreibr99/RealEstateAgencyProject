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
    public partial class FormAgentLoginRegister : Form
    {
        public FormAgentLoginRegister()
        {
            InitializeComponent();
        }

        private void FormAgentLoginRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn a = new LogIn();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register a = new Register();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
