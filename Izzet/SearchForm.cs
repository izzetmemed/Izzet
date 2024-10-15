using Izzet.DataAccess.Concrate;
using Izzet.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izzet
{
    public partial class SearchForm : Form
    {
        private readonly Todo Process = new Todo();
        public SearchForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TodoModel> list = new List<TodoModel>() {
                Process.Get(x => x.Id == int.Parse(IdSearch.Text) && x.DeletedId==0)
                };
            SendData(list);
            AddColumn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<TodoModel> list = new List<TodoModel>() {
                Process.Get(x => x.OwnNumber == OwnNumber.Text && x.DeletedId==0)
        };
            SendData(list);
            AddColumn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<TodoModel> list = new List<TodoModel>() {
                Process.Get(x => x.CustomerNumber == CustomerNumber.Text && x.DeletedId == 0)
        };
            SendData(list);
            AddColumn();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int selectedTodoId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                var data = Process.Get(x => x.Id == selectedTodoId);
                data.DeletedId = data.Id;
                Process.Update(data);
            }
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int selectedTodoId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                Edit edit = new Edit(selectedTodoId);
                edit.Show();
                this.Hide();
            }
        }
        private void SendData(List<TodoModel> list)
        {
            List<object> dataList = new List<object>();

            foreach (var item in list)
            {
                var data = new
                {
                    Id = item.Id,
                    EvSahibi = item.OwnName,
                    EvNömrə = item.OwnNumber,
                    Müştəri = item.CustomerName,
                    MüştəriNömrəsi = item.CustomerNumber,
                    Qiymət = item.HomePrice,
                    EvVerəcəyiPul = item.OwnPrice,
                    MüştərininVerəcəyiPul = item.CustomerPrice,
                    Tarix = item.AddTime,
                    Kod = item.Kod,
                    HomeLandId = item.HomeLandKod
                };
                dataList.Add(data);
            }
            dataGridView1.DataSource = dataList;
        }
        private void AddColumn()
        {
            if (!dataGridView1.Columns.Contains("Delete"))
            {
                var deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            if (!dataGridView1.Columns.Contains("Edit"))
            {
                var editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "Edit";
                editButtonColumn.HeaderText = "Edit";
                editButtonColumn.Text = "Edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(editButtonColumn);
            }
        }
    }
}
