namespace Izzet
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            OwnName = new TextBox();
            GridData = new DataGridView();
            OwnNumber = new TextBox();
            label3 = new Label();
            CustomerName = new TextBox();
            jsjd = new Label();
            CustomerNumber = new TextBox();
            hh = new Label();
            Code = new TextBox();
            c = new Label();
            Price = new TextBox();
            pr = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(609, 234);
            button1.Name = "button1";
            button1.Size = new Size(201, 37);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(143, 172);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Ev sahibi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 256);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // OwnName
            // 
            OwnName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OwnName.Location = new Point(100, 192);
            OwnName.Name = "OwnName";
            OwnName.Size = new Size(154, 25);
            OwnName.TabIndex = 4;
            // 
            // GridData
            // 
            GridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridData.Location = new Point(-4, 362);
            GridData.Name = "GridData";
            GridData.RowTemplate.Height = 25;
            GridData.Size = new Size(1362, 326);
            GridData.TabIndex = 5;
            GridData.CellContentClick += GridData_CellContentClick;
            // 
            // OwnNumber
            // 
            OwnNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OwnNumber.Location = new Point(274, 192);
            OwnNumber.Name = "OwnNumber";
            OwnNumber.Size = new Size(167, 25);
            OwnNumber.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(293, 174);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 6;
            label3.Text = "Ev sahibi nömrəsi:";
            // 
            // CustomerName
            // 
            CustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerName.Location = new Point(461, 192);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(174, 25);
            CustomerName.TabIndex = 9;
            // 
            // jsjd
            // 
            jsjd.AutoSize = true;
            jsjd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            jsjd.Location = new Point(494, 172);
            jsjd.Name = "jsjd";
            jsjd.Size = new Size(88, 15);
            jsjd.TabIndex = 8;
            jsjd.Text = "Müştərinin adı:";
            // 
            // CustomerNumber
            // 
            CustomerNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerNumber.Location = new Point(653, 192);
            CustomerNumber.Name = "CustomerNumber";
            CustomerNumber.Size = new Size(197, 25);
            CustomerNumber.TabIndex = 11;
            // 
            // hh
            // 
            hh.AutoSize = true;
            hh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hh.Location = new Point(694, 171);
            hh.Name = "hh";
            hh.Size = new Size(116, 15);
            hh.TabIndex = 10;
            hh.Text = "Müştərinin nömrəsi:";
            // 
            // Code
            // 
            Code.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Code.Location = new Point(871, 192);
            Code.Name = "Code";
            Code.Size = new Size(184, 25);
            Code.TabIndex = 13;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            c.Location = new Point(934, 171);
            c.Name = "c";
            c.Size = new Size(32, 15);
            c.TabIndex = 12;
            c.Text = "Kod:";
            // 
            // Price
            // 
            Price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(1072, 192);
            Price.Name = "Price";
            Price.Size = new Size(176, 25);
            Price.TabIndex = 15;
            // 
            // pr
            // 
            pr.AutoSize = true;
            pr.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pr.Location = new Point(1127, 171);
            pr.Name = "pr";
            pr.Size = new Size(48, 15);
            pr.TabIndex = 14;
            pr.Text = "Qiymət:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(553, 65);
            label4.Name = "label4";
            label4.Size = new Size(336, 65);
            label4.TabIndex = 16;
            label4.Text = "HomeLand.az";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(4, 2);
            button2.Name = "button2";
            button2.Size = new Size(113, 37);
            button2.TabIndex = 17;
            button2.Text = "Axtarmaq";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(545, 303);
            button3.Name = "button3";
            button3.Size = new Size(150, 37);
            button3.TabIndex = 18;
            button3.Text = "Today";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(717, 303);
            button4.Name = "button4";
            button4.Size = new Size(133, 37);
            button4.TabIndex = 19;
            button4.Text = "All";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(12, 303);
            button5.Name = "button5";
            button5.Size = new Size(80, 37);
            button5.TabIndex = 20;
            button5.Text = "Word";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 615);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(Price);
            Controls.Add(pr);
            Controls.Add(Code);
            Controls.Add(c);
            Controls.Add(CustomerNumber);
            Controls.Add(hh);
            Controls.Add(CustomerName);
            Controls.Add(jsjd);
            Controls.Add(OwnNumber);
            Controls.Add(label3);
            Controls.Add(GridData);
            Controls.Add(OwnName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox OwnName;
        private DataGridView GridData;
        private TextBox OwnNumber;
        private Label label3;
        private TextBox CustomerName;
        private Label jsjd;
        private TextBox CustomerNumber;
        private Label hh;
        private TextBox Code;
        private Label c;
        private TextBox Price;
        private Label pr;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}