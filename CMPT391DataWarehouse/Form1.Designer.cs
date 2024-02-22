namespace CMPT391DataWarehouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            checkBox2 = new CheckBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            groupBox1 = new GroupBox();
            textBox6 = new TextBox();
            searchButton = new Button();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            label13 = new Label();
            comboBox4 = new ComboBox();
            label_numResults = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Filters";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "Year";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 59);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 324);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Instructor";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 103);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "University";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(5, 121);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 23);
            textBox3.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 211);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 14;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 255);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 15;
            label7.Text = "Faculty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 299);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 16;
            label8.Text = "Rank";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 363);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(67, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Student";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 403);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(112, 23);
            textBox4.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 385);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 19;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 429);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 20;
            label10.Text = "Gender";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 447);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 23);
            textBox5.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 473);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 22;
            label11.Text = "major";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(7, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 573);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 491);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(112, 23);
            textBox6.TabIndex = 23;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(6, 532);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(163, 33);
            searchButton.TabIndex = 24;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(216, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(793, 499);
            dataGridView1.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(216, 578);
            label12.Name = "label12";
            label12.Size = new Size(143, 20);
            label12.TabIndex = 25;
            label12.Text = "Number of Courses: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 147);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 25;
            label13.Text = "Province";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(5, 165);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 26;
            // 
            // label_numResults
            // 
            label_numResults.AutoSize = true;
            label_numResults.Font = new Font("Segoe UI", 11F);
            label_numResults.Location = new Point(365, 578);
            label_numResults.Name = "label_numResults";
            label_numResults.Size = new Size(17, 20);
            label_numResults.TabIndex = 26;
            label_numResults.Text = "0";
            label_numResults.Click += label14_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 618);
            Controls.Add(label_numResults);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private Label label5;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox checkBox2;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private GroupBox groupBox1;
        private Button searchButton;
        private TextBox textBox6;
        private ComboBox comboBox4;
        private Label label13;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label_numResults;
    }
}
