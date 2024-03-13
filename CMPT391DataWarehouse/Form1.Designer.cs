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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            text_instructorName = new TextBox();
            text_rank = new TextBox();
            text_faculty = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            text_studentName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            text_gender = new TextBox();
            label11 = new Label();
            groupBox1 = new GroupBox();
            text_dateSem = new TextBox();
            label18 = new Label();
            label17 = new Label();
            text_dateYear = new TextBox();
            label14 = new Label();
            text_courseDepartment = new TextBox();
            text_courseUni = new TextBox();
            text_courseName = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label13 = new Label();
            searchButton = new Button();
            text_major = new TextBox();
            dataGridResults = new DataGridView();
            label12 = new Label();
            label_numResults = new Label();
            label19 = new Label();
            label_uniqueIds = new Label();
            label_query = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResults).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Filters";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(2, 15);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Course";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 30);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "Course Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 324);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 70);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "University";
            // 
            // text_instructorName
            // 
            text_instructorName.Location = new Point(14, 276);
            text_instructorName.Name = "text_instructorName";
            text_instructorName.Size = new Size(113, 23);
            text_instructorName.TabIndex = 11;
            // 
            // text_rank
            // 
            text_rank.Location = new Point(15, 355);
            text_rank.Name = "text_rank";
            text_rank.Size = new Size(112, 23);
            text_rank.TabIndex = 12;
            // 
            // text_faculty
            // 
            text_faculty.Location = new Point(14, 316);
            text_faculty.Name = "text_faculty";
            text_faculty.Size = new Size(113, 23);
            text_faculty.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 258);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 14;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 298);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 15;
            label7.Text = "Faculty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 337);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 16;
            label8.Text = "Rank";
            // 
            // text_studentName
            // 
            text_studentName.Location = new Point(15, 416);
            text_studentName.Name = "text_studentName";
            text_studentName.Size = new Size(112, 23);
            text_studentName.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 398);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 19;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 438);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 20;
            label10.Text = "Gender";
            // 
            // text_gender
            // 
            text_gender.Location = new Point(14, 456);
            text_gender.Name = "text_gender";
            text_gender.Size = new Size(112, 23);
            text_gender.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 478);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 22;
            label11.Text = "Major";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(text_dateSem);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(text_dateYear);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(text_courseDepartment);
            groupBox1.Controls.Add(text_courseUni);
            groupBox1.Controls.Add(text_courseName);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(text_major);
            groupBox1.Controls.Add(text_rank);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(text_faculty);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(text_gender);
            groupBox1.Controls.Add(text_instructorName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(text_studentName);
            groupBox1.Location = new Point(7, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 573);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // text_dateSem
            // 
            text_dateSem.Location = new Point(14, 221);
            text_dateSem.Name = "text_dateSem";
            text_dateSem.Size = new Size(113, 23);
            text_dateSem.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 203);
            label18.Name = "label18";
            label18.Size = new Size(55, 15);
            label18.TabIndex = 35;
            label18.Text = "Semester";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(14, 164);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 34;
            label17.Text = "Year";
            // 
            // text_dateYear
            // 
            text_dateYear.Location = new Point(14, 182);
            text_dateYear.Name = "text_dateYear";
            text_dateYear.Size = new Size(113, 23);
            text_dateYear.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(6, 149);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 32;
            label14.Text = "Date";
            // 
            // text_courseDepartment
            // 
            text_courseDepartment.Location = new Point(14, 127);
            text_courseDepartment.Name = "text_courseDepartment";
            text_courseDepartment.Size = new Size(113, 23);
            text_courseDepartment.TabIndex = 31;
            // 
            // text_courseUni
            // 
            text_courseUni.Location = new Point(14, 88);
            text_courseUni.Name = "text_courseUni";
            text_courseUni.Size = new Size(113, 23);
            text_courseUni.TabIndex = 30;
            // 
            // text_courseName
            // 
            text_courseName.Location = new Point(14, 48);
            text_courseName.Name = "text_courseName";
            text_courseName.Size = new Size(113, 23);
            text_courseName.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(2, 383);
            label16.Name = "label16";
            label16.Size = new Size(52, 15);
            label16.TabIndex = 28;
            label16.Text = "Student";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(5, 243);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 27;
            label15.Text = "Instructor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 109);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 25;
            label13.Text = "Department";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            text_major.Location = new Point(15, 496);
            text_major.Name = "text_major";
            text_major.Size = new Size(112, 23);
            text_major.TabIndex = 23;
            // 
            // dataGridResults
            // 
            dataGridResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResults.Location = new Point(216, 48);
            dataGridResults.Name = "dataGridResults";
            dataGridResults.ReadOnly = true;
            dataGridResults.RowHeadersWidth = 62;
            dataGridResults.Size = new Size(793, 499);
            dataGridResults.TabIndex = 24;
            dataGridResults.AllowUserToAddRowsChanged += fa;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(216, 578);
            label12.Name = "label12";
            label12.Size = new Size(136, 20);
            label12.TabIndex = 25;
            label12.Text = "Number of Entries: ";
            label12.Click += label12_Click;
            // 
            // label_numResults
            // 
            label_numResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_numResults.AutoSize = true;
            label_numResults.Font = new Font("Segoe UI", 11F);
            label_numResults.Location = new Point(365, 578);
            label_numResults.Name = "label_numResults";
            label_numResults.Size = new Size(17, 20);
            label_numResults.TabIndex = 26;
            label_numResults.Text = "0";
            label_numResults.Click += label14_Click;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F);
            label19.Location = new Point(490, 578);
            label19.Name = "label19";
            label19.Size = new Size(133, 20);
            label19.TabIndex = 27;
            label19.Text = "Unique Course IDs:";
            // 
            // label_uniqueIds
            // 
            label_uniqueIds.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_uniqueIds.AutoSize = true;
            label_uniqueIds.Font = new Font("Segoe UI", 11F);
            label_uniqueIds.Location = new Point(647, 578);
            label_uniqueIds.Name = "label_uniqueIds";
            label_uniqueIds.Size = new Size(17, 20);
            label_uniqueIds.TabIndex = 28;
            label_uniqueIds.Text = "0";
            // 
            // label_query
            // 
            label_query.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_query.AutoSize = true;
            label_query.Cursor = Cursors.SizeNS;
            label_query.Font = new Font("Segoe UI", 9F);
            label_query.ForeColor = SystemColors.ControlDarkDark;
            label_query.Location = new Point(188, 598);
            label_query.Name = "label_query";
            label_query.Size = new Size(10, 15);
            label_query.TabIndex = 29;
            label_query.Text = " ";
            // 
            // button1
            // 
            button1.Location = new Point(877, 572);
            button1.Name = "button1";
            button1.Size = new Size(122, 34);
            button1.TabIndex = 30;
            button1.Text = "Import XML";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 1030);
            Controls.Add(button1);
            Controls.Add(label_query);
            Controls.Add(label_uniqueIds);
            Controls.Add(label19);
            Controls.Add(label_numResults);
            Controls.Add(label12);
            Controls.Add(dataGridResults);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Data WareHouse";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox text_instructorName;
        private TextBox text_rank;
        private TextBox text_faculty;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox text_studentName;
        private Label label9;
        private Label label10;
        private TextBox text_gender;
        private Label label11;
        private GroupBox groupBox1;
        private Button searchButton;
        private TextBox text_major;
        private Label label13;
        private DataGridView dataGridResults;
        private Label label12;
        private Label label_numResults;
        private Label label16;
        private Label label15;
        private TextBox text_courseName;
        private TextBox text_courseDepartment;
        private TextBox text_courseUni;
        private TextBox text_dateSem;
        private Label label18;
        private Label label17;
        private TextBox text_dateYear;
        private Label label14;
        private Label label19;
        private Label label_uniqueIds;
        private Label label_query;

        private Button button1;
    }
}
