using Izzet.DataAccess.Concrate;
using Izzet.Model;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Izzet
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            RefreshDataToday();

            if (!GridData.Columns.Contains("Delete"))
            {
                var deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                GridData.Columns.Add(deleteButtonColumn);
            }
            if (!GridData.Columns.Contains("Edit"))
            {
                var editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "Edit";
                editButtonColumn.HeaderText = "Edit";
                editButtonColumn.Text = "Edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                GridData.Columns.Add(editButtonColumn);
            }
            this.WindowState = FormWindowState.Maximized;
        }
        private readonly Todo Crud = new Todo();

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
                Crud.Add(model);
                RefreshDataToday();
                OwnName.Text = "";
                OwnNumber.Text = "";
                CustomerName.Text = "";
                CustomerNumber.Text = "";
                Price.Text = "";
                Code.Text = "";
            }
            else
            {
                MessageBox.Show("Xanaları doldurun!!!");
            }

        }

        public void RefreshData()
        {
            button4.BackColor = Color.Chartreuse;
            button3.BackColor = Color.LightGray;
            var allData = Crud.GetAll(x => x.DeletedId == 0);
            List<object> dataList = new List<object>();

            foreach (var item in allData)
            {
                var data = new
                {
                    Id = item.Id,
                    Sahib = item.OwnName,
                    EvNöm = item.OwnNumber,
                    Müştəri = item.CustomerName,
                    MüştəriNöm = item.CustomerNumber,
                    Qiy = item.HomePrice,
                    SahibPul = item.OwnPrice,
                    MüştəriPul = item.CustomerPrice,
                    Tarix = item.AddTime,
                    Kod = item.Kod,
                    HLId = item.HomeLandKod
                };
                dataList.Add(data);
            }

            dataList.Reverse();
            GridData.DataSource = dataList;
        }
        public void RefreshDataToday()
        {
            button3.BackColor = Color.Chartreuse;
            button4.BackColor = Color.LightGray;
            var allData = Crud.GetAll(x => x.DeletedId == 0 && x.AddTime.Date == DateTime.Today);
            List<object> dataList = new List<object>();

            foreach (var item in allData)
            {
                var data = new
                {
                    Id = item.Id,
                    Sahib = item.OwnName,
                    EvNöm = item.OwnNumber,
                    Müştəri = item.CustomerName,
                    MüştəriNöm = item.CustomerNumber,
                    Qiy = item.HomePrice,
                    SahibPul = item.OwnPrice,
                    MüştəriPul = item.CustomerPrice,
                    Tarix = item.AddTime,
                    Kod = item.Kod,
                    HLId = item.HomeLandKod
                };
                dataList.Add(data);
            }

            dataList.Reverse();
            GridData.DataSource = dataList;

        }
        private void GridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridData.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int selectedTodoId = (int)GridData.Rows[e.RowIndex].Cells["Id"].Value;
                var data = Crud.Get(x => x.Id == selectedTodoId);
                data.DeletedId = data.Id;
                Crud.Update(data);
                RefreshData();
            }
            if (e.ColumnIndex == GridData.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int selectedTodoId = (int)GridData.Rows[e.RowIndex].Cells["Id"].Value;
                Edit edit = new Edit(selectedTodoId);
                edit.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm search = new SearchForm();
            search.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshDataToday();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = "HomeLand.docx";

            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

                using (DocX document = DocX.Create(filePath))
                {
                    Table table = document.AddTable(GridData.Rows.Count + 1, GridData.Columns.Count - 2); 

                    for (int i = 0, docxCol = 0; i < GridData.Columns.Count; i++)
                    {
                        if (GridData.Columns[i].HeaderText != "Edit" && GridData.Columns[i].HeaderText != "Delete")
                        {
                            table.Rows[0].Cells[docxCol].Paragraphs.First().Append(GridData.Columns[i].HeaderText);
                            docxCol++;
                        }
                    }

                    for (int i = 0; i < GridData.Rows.Count; i++)
                    {
                        for (int j = 0, docxCol = 0; j < GridData.Columns.Count; j++)
                        {
                            if (GridData.Columns[j].HeaderText != "Edit" && GridData.Columns[j].HeaderText != "Delete" )
                            {
                                object cellValue = GridData.Rows[i].Cells[j].Value;
                                table.Rows[i + 1].Cells[docxCol].Paragraphs.First().Append(cellValue != null ? cellValue.ToString() : "");
                                docxCol++;
                            }
                        }
                    }

                    document.InsertTable(table);
                    document.Save();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void SendEmail(string Number)
        //{

        //    string fromEmail = "homeland.az.service@gmail.com";
        //    string toEmail = Number;
        //    string subject = "HomeLand.az";
        //    string body = $"Tarix: {DateTime.Now.ToString("M/d/yyyy h:mm")}";
        //    try
        //    {
        //        using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com"))
        //        {
        //            smtp.Port = 587;
        //            smtp.Credentials = new System.Net.NetworkCredential("homeland.az.service@gmail.com", "dvmq vowb frps tsye");
        //            smtp.EnableSsl = true;

        //            using (System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage(fromEmail, toEmail, subject, body))
        //            {
        //                smtp.Send(mailMessage);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Gmail is wrong");
        //    }

        //}

    }
}
