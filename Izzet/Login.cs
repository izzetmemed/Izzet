using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izzet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        Form2 form2 = new Form2();
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (User.Text == "IzzetHome" && Password.Text == "0805")
            {
                this.Hide();
                form2.Show();
            }
            else if (count == 2)
            {
                this.Close();
            }
            else
            {
                count = count + 1;
                MessageBox.Show("Uğursuz əməliyyat");
            }
        }
    }
}
