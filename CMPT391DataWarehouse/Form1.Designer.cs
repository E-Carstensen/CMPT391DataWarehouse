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
            combo_year = new ComboBox();
            combo_sem = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkbox_instructorFilters = new CheckBox();
            label5 = new Label();
            combo_uni = new ComboBox();
            text_instructorName = new TextBox();
            text_rank = new TextBox();
            text_faculty = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            checkbox_studentFilters = new CheckBox();
            text_studentName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            text_gender = new TextBox();
            label11 = new Label();
            groupBox1 = new GroupBox();
            label14 = new Label();
            comboBox5 = new ComboBox();
            combo_prov = new ComboBox();
            label13 = new Label();
            searchButton = new Button();
            text_major = new TextBox();
            dataGridView1 = new DataGridView();
            label12 = new Label();
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
            // combo_year
            // 
            combo_year.FormattingEnabled = true;
            combo_year.Location = new Point(6, 33);
            combo_year.Name = "combo_year";
            combo_year.Size = new Size(53, 23);
            combo_year.TabIndex = 1;
            // 
            // combo_sem
            // 
            combo_sem.FormattingEnabled = true;
            combo_sem.Location = new Point(6, 77);
            combo_sem.Name = "combo_sem";
            combo_sem.Size = new Size(121, 23);
            combo_sem.TabIndex = 2;
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
            // checkbox_instructorFilters
            // 
            checkbox_instructorFilters.AutoSize = true;
            checkbox_instructorFilters.Location = new Point(12, 222);
            checkbox_instructorFilters.Name = "checkbox_instructorFilters";
            checkbox_instructorFilters.Size = new Size(77, 19);
            checkbox_instructorFilters.TabIndex = 8;
            checkbox_instructorFilters.Text = "Instructor";
            checkbox_instructorFilters.UseVisualStyleBackColor = true;
            checkbox_instructorFilters.CheckedChanged += checkBox1_CheckedChanged;
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
            // combo_uni
            // 
            combo_uni.FormattingEnabled = true;
            combo_uni.Location = new Point(5, 121);
            combo_uni.Name = "combo_uni";
            combo_uni.Size = new Size(121, 23);
            combo_uni.TabIndex = 10;
            // 
            // text_instructorName
            // 
            text_instructorName.Location = new Point(14, 229);
            text_instructorName.Name = "text_instructorName";
            text_instructorName.Size = new Size(113, 23);
            text_instructorName.TabIndex = 11;
            // 
            // text_rank
            // 
            text_rank.Location = new Point(14, 317);
            text_rank.Name = "text_rank";
            text_rank.Size = new Size(112, 23);
            text_rank.TabIndex = 12;
            // 
            // text_faculty
            // 
            text_faculty.Location = new Point(14, 273);
            text_faculty.Name = "text_faculty";
            text_faculty.Size = new Size(113, 23);
            text_faculty.TabIndex = 13;
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
            // checkbox_studentFilters
            // 
            checkbox_studentFilters.AutoSize = true;
            checkbox_studentFilters.Location = new Point(6, 363);
            checkbox_studentFilters.Name = "checkbox_studentFilters";
            checkbox_studentFilters.Size = new Size(67, 19);
            checkbox_studentFilters.TabIndex = 17;
            checkbox_studentFilters.Text = "Student";
            checkbox_studentFilters.UseVisualStyleBackColor = true;
            checkbox_studentFilters.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // text_studentName
            // 
            text_studentName.Location = new Point(14, 403);
            text_studentName.Name = "text_studentName";
            text_studentName.Size = new Size(112, 23);
            text_studentName.TabIndex = 18;
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
            // text_gender
            // 
            text_gender.Location = new Point(14, 447);
            text_gender.Name = "text_gender";
            text_gender.Size = new Size(112, 23);
            text_gender.TabIndex = 21;
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
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(combo_prov);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(text_major);
            groupBox1.Controls.Add(combo_uni);
            groupBox1.Controls.Add(text_rank);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(text_faculty);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(combo_sem);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(checkbox_studentFilters);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(text_gender);
            groupBox1.Controls.Add(text_instructorName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(text_studentName);
            groupBox1.Controls.Add(combo_year);
            groupBox1.Location = new Point(7, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 573);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 7F);
            label14.Location = new Point(59, 36);
            label14.Name = "label14";
            label14.Size = new Size(9, 12);
            label14.TabIndex = 27;
            label14.Text = "-";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(72, 33);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(54, 23);
            comboBox5.TabIndex = 27;
            // 
            // combo_prov
            // 
            combo_prov.FormattingEnabled = true;
            combo_prov.Location = new Point(5, 165);
            combo_prov.Name = "combo_prov";
            combo_prov.Size = new Size(121, 23);
            combo_prov.TabIndex = 26;
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
            // text_major
            // 
            text_major.Location = new Point(14, 491);
            text_major.Name = "text_major";
            text_major.Size = new Size(112, 23);
            text_major.TabIndex = 23;
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
            Controls.Add(checkbox_instructorFilters);
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
        private ComboBox combo_year;
        private ComboBox combo_sem;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkbox_instructorFilters;
        private Label label5;
        private ComboBox combo_uni;
        private TextBox text_instructorName;
        private TextBox text_rank;
        private TextBox text_faculty;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox checkbox_studentFilters;
        private TextBox text_studentName;
        private Label label9;
        private Label label10;
        private TextBox text_gender;
        private Label label11;
        private GroupBox groupBox1;
        private Button searchButton;
        private TextBox text_major;
        private ComboBox combo_prov;
        private Label label13;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label_numResults;
        private Label label14;
        private ComboBox comboBox5;
    }
}
