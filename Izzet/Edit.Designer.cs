namespace Izzet
{
    partial class Edit
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
            Price = new TextBox();
            pr = new Label();
            Code = new TextBox();
            c = new Label();
            CustomerNumber = new TextBox();
            hh = new Label();
            CustomerName = new TextBox();
            jsjd = new Label();
            OwnNumber = new TextBox();
            label3 = new Label();
            OwnName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // Price
            // 
            Price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(567, 442);
            Price.Name = "Price";
            Price.Size = new Size(284, 25);
            Price.TabIndex = 28;
            // 
            // pr
            // 
            pr.AutoSize = true;
            pr.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pr.Location = new Point(653, 421);
            pr.Name = "pr";
            pr.Size = new Size(48, 15);
            pr.TabIndex = 27;
            pr.Text = "Qiymət:";
            // 
            // Code
            // 
            Code.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Code.Location = new Point(567, 392);
            Code.Name = "Code";
            Code.Size = new Size(284, 25);
            Code.TabIndex = 26;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            c.Location = new Point(653, 371);
            c.Name = "c";
            c.Size = new Size(32, 15);
            c.TabIndex = 25;
            c.Text = "Kod:";
            // 
            // CustomerNumber
            // 
            CustomerNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerNumber.Location = new Point(567, 338);
            CustomerNumber.Name = "CustomerNumber";
            CustomerNumber.Size = new Size(284, 25);
            CustomerNumber.TabIndex = 24;
            // 
            // hh
            // 
            hh.AutoSize = true;
            hh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hh.Location = new Point(653, 317);
            hh.Name = "hh";
            hh.Size = new Size(116, 15);
            hh.TabIndex = 23;
            hh.Text = "Müştərinin nömrəsi:";
            // 
            // CustomerName
            // 
            CustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerName.Location = new Point(567, 284);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(284, 25);
            CustomerName.TabIndex = 22;
            // 
            // jsjd
            // 
            jsjd.AutoSize = true;
            jsjd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            jsjd.Location = new Point(653, 264);
            jsjd.Name = "jsjd";
            jsjd.Size = new Size(91, 15);
            jsjd.TabIndex = 21;
            jsjd.Text = "Müştərinin adıi:";
            // 
            // OwnNumber
            // 
            OwnNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OwnNumber.Location = new Point(567, 236);
            OwnNumber.Name = "OwnNumber";
            OwnNumber.Size = new Size(284, 25);
            OwnNumber.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(653, 218);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 19;
            label3.Text = "Ev sahibi nömrəsi:";
            // 
            // OwnName
            // 
            OwnName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OwnName.Location = new Point(567, 182);
            OwnName.Name = "OwnName";
            OwnName.Size = new Size(284, 25);
            OwnName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(653, 164);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 17;
            label1.Text = "Ev sahibi:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(669, 496);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 16;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(543, 65);
            label4.Name = "label4";
            label4.Size = new Size(336, 65);
            label4.TabIndex = 29;
            label4.Text = "HomeLand.az";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 563);
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
            Controls.Add(OwnName);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Price;
        private Label pr;
        private TextBox Code;
        private Label c;
        private TextBox CustomerNumber;
        private Label hh;
        private TextBox CustomerName;
        private Label jsjd;
        private TextBox OwnNumber;
        private Label label3;
        private TextBox OwnName;
        private Label label1;
        private Button button1;
        private Label label4;
    }
}