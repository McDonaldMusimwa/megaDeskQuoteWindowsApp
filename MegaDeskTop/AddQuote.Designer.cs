namespace MegaDeskTop
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.receivedsurfacmaterial = new System.Windows.Forms.ComboBox();
            this.receivedwidth = new System.Windows.Forms.TextBox();
            this.receivedepth = new System.Windows.Forms.TextBox();
            this.receiveddrawers = new System.Windows.Forms.TextBox();
            this.receivedrushdays = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CalculateQuote = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.surfaceCost = new System.Windows.Forms.Label();
            this.drawerCost = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.Label();
            this.rushDaysCost = new System.Windows.Forms.Label();
            this.baseprice = new System.Windows.Forms.TextBox();
            this.surface = new System.Windows.Forms.TextBox();
            this.drawer = new System.Windows.Forms.TextBox();
            this.surfaceareacost = new System.Windows.Forms.TextBox();
            this.rushdays = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.quotecost = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.receivedcustomername = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Quote";
            // 
            // receivedsurfacmaterial
            // 
            this.receivedsurfacmaterial.FormattingEnabled = true;
            this.receivedsurfacmaterial.Location = new System.Drawing.Point(146, 261);
            this.receivedsurfacmaterial.Name = "receivedsurfacmaterial";
            this.receivedsurfacmaterial.Size = new System.Drawing.Size(121, 22);
            this.receivedsurfacmaterial.TabIndex = 1;
            this.receivedsurfacmaterial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // receivedwidth
            // 
            this.receivedwidth.Location = new System.Drawing.Point(146, 94);
            this.receivedwidth.Name = "receivedwidth";
            this.receivedwidth.Size = new System.Drawing.Size(121, 22);
            this.receivedwidth.TabIndex = 2;
            this.receivedwidth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // receivedepth
            // 
            this.receivedepth.Location = new System.Drawing.Point(146, 152);
            this.receivedepth.Name = "receivedepth";
            this.receivedepth.Size = new System.Drawing.Size(121, 22);
            this.receivedepth.TabIndex = 3;
            this.receivedepth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // receiveddrawers
            // 
            this.receiveddrawers.Location = new System.Drawing.Point(146, 197);
            this.receiveddrawers.Name = "receiveddrawers";
            this.receiveddrawers.Size = new System.Drawing.Size(121, 22);
            this.receiveddrawers.TabIndex = 4;
            // 
            // receivedrushdays
            // 
            this.receivedrushdays.FormattingEnabled = true;
            this.receivedrushdays.Location = new System.Drawing.Point(146, 321);
            this.receivedrushdays.Name = "receivedrushdays";
            this.receivedrushdays.Size = new System.Drawing.Size(121, 22);
            this.receivedrushdays.TabIndex = 5;
            this.receivedrushdays.SelectedIndexChanged += new System.EventHandler(this.receivedrushdays_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add width";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add num drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add surface material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Add rushdays";
            // 
            // CalculateQuote
            // 
            this.CalculateQuote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CalculateQuote.Location = new System.Drawing.Point(146, 429);
            this.CalculateQuote.Name = "CalculateQuote";
            this.CalculateQuote.Size = new System.Drawing.Size(113, 33);
            this.CalculateQuote.TabIndex = 11;
            this.CalculateQuote.Text = "Calculate";
            this.CalculateQuote.UseVisualStyleBackColor = false;
            this.CalculateQuote.Click += new System.EventHandler(this.CalculateQuote_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.add.Location = new System.Drawing.Point(539, 429);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(138, 33);
            this.add.TabIndex = 12;
            this.add.Text = "Add Quote";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "BasePrice";
            // 
            // surfaceCost
            // 
            this.surfaceCost.AutoSize = true;
            this.surfaceCost.Location = new System.Drawing.Point(461, 234);
            this.surfaceCost.Name = "surfaceCost";
            this.surfaceCost.Size = new System.Drawing.Size(114, 14);
            this.surfaceCost.TabIndex = 14;
            this.surfaceCost.Text = "surfaceArea Cost";
            this.surfaceCost.Click += new System.EventHandler(this.label8_Click);
            // 
            // drawerCost
            // 
            this.drawerCost.AutoSize = true;
            this.drawerCost.Location = new System.Drawing.Point(464, 261);
            this.drawerCost.Name = "drawerCost";
            this.drawerCost.Size = new System.Drawing.Size(78, 14);
            this.drawerCost.TabIndex = 15;
            this.drawerCost.Text = "drawerCost";
            this.drawerCost.Click += new System.EventHandler(this.drawerCost_Click);
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.AutoSize = true;
            this.surfaceMaterial.Location = new System.Drawing.Point(461, 286);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(106, 14);
            this.surfaceMaterial.TabIndex = 16;
            this.surfaceMaterial.Text = "surfaceMaterial";
            // 
            // rushDaysCost
            // 
            this.rushDaysCost.AutoSize = true;
            this.rushDaysCost.Location = new System.Drawing.Point(461, 321);
            this.rushDaysCost.Name = "rushDaysCost";
            this.rushDaysCost.Size = new System.Drawing.Size(63, 14);
            this.rushDaysCost.TabIndex = 17;
            this.rushDaysCost.Text = "rushdays";
            // 
            // baseprice
            // 
            this.baseprice.Location = new System.Drawing.Point(685, 192);
            this.baseprice.Name = "baseprice";
            this.baseprice.Size = new System.Drawing.Size(100, 22);
            this.baseprice.TabIndex = 18;
            // 
            // surface
            // 
            this.surface.Location = new System.Drawing.Point(685, 283);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(100, 22);
            this.surface.TabIndex = 19;
            // 
            // drawer
            // 
            this.drawer.Location = new System.Drawing.Point(685, 253);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(100, 22);
            this.drawer.TabIndex = 20;
            // 
            // surfaceareacost
            // 
            this.surfaceareacost.Location = new System.Drawing.Point(685, 226);
            this.surfaceareacost.Name = "surfaceareacost";
            this.surfaceareacost.Size = new System.Drawing.Size(100, 22);
            this.surfaceareacost.TabIndex = 21;
            // 
            // rushdays
            // 
            this.rushdays.Location = new System.Drawing.Point(685, 313);
            this.rushdays.Name = "rushdays";
            this.rushdays.Size = new System.Drawing.Size(100, 22);
            this.rushdays.TabIndex = 22;
            this.rushdays.TextChanged += new System.EventHandler(this.rushdays_TextChanged);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(685, 355);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 22);
            this.total.TabIndex = 23;
            // 
            // quotecost
            // 
            this.quotecost.AutoSize = true;
            this.quotecost.Location = new System.Drawing.Point(461, 363);
            this.quotecost.Name = "quotecost";
            this.quotecost.Size = new System.Drawing.Size(73, 14);
            this.quotecost.TabIndex = 24;
            this.quotecost.Text = "quote cost";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(146, 380);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(121, 22);
            this.customerName.TabIndex = 25;
            this.customerName.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // receivedcustomername
            // 
            this.receivedcustomername.AutoSize = true;
            this.receivedcustomername.Location = new System.Drawing.Point(143, 363);
            this.receivedcustomername.Name = "receivedcustomername";
            this.receivedcustomername.Size = new System.Drawing.Size(106, 14);
            this.receivedcustomername.TabIndex = 26;
            this.receivedcustomername.Text = "Customer Name";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(641, 95);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(144, 22);
            this.date.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 14);
            this.label8.TabIndex = 28;
            this.label8.Text = "Date";
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(467, 95);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(168, 22);
            this.customer.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 14);
            this.label9.TabIndex = 30;
            this.label9.Text = "Customer Name";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 485);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.date);
            this.Controls.Add(this.receivedcustomername);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.quotecost);
            this.Controls.Add(this.total);
            this.Controls.Add(this.rushdays);
            this.Controls.Add(this.surfaceareacost);
            this.Controls.Add(this.drawer);
            this.Controls.Add(this.surface);
            this.Controls.Add(this.baseprice);
            this.Controls.Add(this.rushDaysCost);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.drawerCost);
            this.Controls.Add(this.surfaceCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add);
            this.Controls.Add(this.CalculateQuote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receivedrushdays);
            this.Controls.Add(this.receiveddrawers);
            this.Controls.Add(this.receivedepth);
            this.Controls.Add(this.receivedwidth);
            this.Controls.Add(this.receivedsurfacmaterial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox receivedsurfacmaterial;
        private System.Windows.Forms.TextBox receivedwidth;
        private System.Windows.Forms.TextBox receivedepth;
        private System.Windows.Forms.TextBox receiveddrawers;
        private System.Windows.Forms.ComboBox receivedrushdays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CalculateQuote;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label surfaceCost;
        private System.Windows.Forms.Label drawerCost;
        private System.Windows.Forms.Label surfaceMaterial;
        private System.Windows.Forms.Label rushDaysCost;
        private System.Windows.Forms.TextBox baseprice;
        private System.Windows.Forms.TextBox surface;
        private System.Windows.Forms.TextBox drawer;
        private System.Windows.Forms.TextBox surfaceareacost;
        private System.Windows.Forms.TextBox rushdays;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label quotecost;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label receivedcustomername;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.Label label9;
    }
}