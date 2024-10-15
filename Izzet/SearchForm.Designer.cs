namespace Izzet
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            IdSearch = new TextBox();
            hh = new Label();
            button1 = new Button();
            CustomerNumber = new TextBox();
            label1 = new Label();
            button2 = new Button();
            OwnNumber = new TextBox();
            label2 = new Label();
            button3 = new Button();
            Back = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(567, 72);
            label4.Name = "label4";
            label4.Size = new Size(336, 65);
            label4.TabIndex = 23;
            label4.Text = "HomeLand.az";
            // 
            // IdSearch
            // 
            IdSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            IdSearch.Location = new Point(644, 205);
            IdSearch.Name = "IdSearch";
            IdSearch.Size = new Size(197, 32);
            IdSearch.TabIndex = 22;
            // 
            // hh
            // 
            hh.AutoSize = true;
            hh.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            hh.Location = new Point(590, 207);
            hh.Name = "hh";
            hh.Size = new Size(36, 26);
            hh.TabIndex = 21;
            hh.Text = "Id:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(864, 205);
            button1.Name = "button1";
            button1.Size = new Size(105, 32);
            button1.TabIndex = 17;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CustomerNumber
            // 
            CustomerNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerNumber.Location = new Point(644, 310);
            CustomerNumber.Name = "CustomerNumber";
            CustomerNumber.Size = new Size(197, 32);
            CustomerNumber.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(453, 311);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 25;
            label1.Text = "Müştəri nömrəsi:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(864, 311);
            button2.Name = "button2";
            button2.Size = new Size(105, 32);
            button2.TabIndex = 24;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OwnNumber
            // 
            OwnNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            OwnNumber.Location = new Point(644, 258);
            OwnNumber.Name = "OwnNumber";
            OwnNumber.Size = new Size(197, 32);
            OwnNumber.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(406, 261);
            label2.Name = "label2";
            label2.Size = new Size(220, 26);
            label2.TabIndex = 28;
            label2.Text = "Ev sahibinin nömrəsi:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(864, 258);
            button3.Name = "button3";
            button3.Size = new Size(105, 32);
            button3.TabIndex = 27;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Back
            // 
            Back.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(105, 32);
            Back.TabIndex = 30;
            Back.Text = "Geri dön";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 402);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1330, 152);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 566);
            Controls.Add(dataGridView1);
            Controls.Add(Back);
            Controls.Add(OwnNumber);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(CustomerNumber);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(IdSearch);
            Controls.Add(hh);
            Controls.Add(button1);
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox IdSearch;
        private Label hh;
        private Button button1;
        private TextBox CustomerNumber;
        private Label label1;
        private Button button2;
        private TextBox OwnNumber;
        private Label label2;
        private Button button3;
        private Button Back;
        private DataGridView dataGridView1;
    }
}