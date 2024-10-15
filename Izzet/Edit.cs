using Izzet.DataAccess.Concrate;
using Izzet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izzet
{
    public partial class Edit : Form
    {
        private readonly Todo Process = new Todo();
        private int Id;
        private Form2 form2= new Form2();
        public Edit(int id)
        {
            InitializeComponent();
            this.Id = id;
            var data = Process.Get(x => x.Id == Id);
            OwnName.Text = data.OwnName;
            OwnNumber.Text = data.OwnNumber;
            CustomerName.Text = data.CustomerName;
            CustomerNumber.Text = data.CustomerNumber;
            Price.Text = data.HomePrice.ToString();
            Code.Text = data.Kod.ToString();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int homePrice;
            if (int.TryParse(Price.Text, out int parsedPrice))
            {
                homePrice = parsedPrice;
            }
            else
            {

                homePrice = 0;
            }
            int CodeParsed;
            if (int.TryParse(Code.Text, out int ParsedCode))
            {
                CodeParsed = ParsedCode;
            }
            else
            {
                CodeParsed = 0;
            }
            var model = new TodoModel
            {   
                Id=Id,
                OwnName = OwnName.Text,
                OwnNumber = OwnNumber.Text,
                CustomerName = CustomerName.Text,
                CustomerNumber = CustomerNumber.Text,
                HomePrice = homePrice,
                Kod = CodeParsed,
                OwnPrice = homePrice * 0.2,
                CustomerPrice = homePrice * 0.2
            };
            if (model.OwnName != string.Empty &&
                model.OwnNumber != string.Empty &&
                model.CustomerName != string.Empty &&
                model.CustomerNumber != string.Empty)
            {
                Process.Update(model);
                this.Hide();
                form2.Show();
                form2.RefreshData();
            }
            else
            {
                MessageBox.Show("Xanaları doldurun!!!");
            }
           
        }
    }
}
