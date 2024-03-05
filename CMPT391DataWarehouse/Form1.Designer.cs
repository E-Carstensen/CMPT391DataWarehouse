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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResults).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 0;
            label1.Text = "Filters";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 5;
            label2.Text = "Course";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 6;
            label3.Text = "Course Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 540);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 116);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 9;
            label5.Text = "University";
            // 
            // text_instructorName
            // 
            text_instructorName.Location = new Point(20, 460);
            text_instructorName.Margin = new Padding(4, 5, 4, 5);
            text_instructorName.Name = "text_instructorName";
            text_instructorName.Size = new Size(160, 31);
            text_instructorName.TabIndex = 11;
            // 
            // text_rank
            // 
            text_rank.Location = new Point(21, 592);
            text_rank.Margin = new Padding(4, 5, 4, 5);
            text_rank.Name = "text_rank";
            text_rank.Size = new Size(158, 31);
            text_rank.TabIndex = 12;
            // 
            // text_faculty
            // 
            text_faculty.Location = new Point(20, 526);
            text_faculty.Margin = new Padding(4, 5, 4, 5);
            text_faculty.Name = "text_faculty";
            text_faculty.Size = new Size(160, 31);
            text_faculty.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 430);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 14;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 496);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 15;
            label7.Text = "Faculty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 562);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 16;
            label8.Text = "Rank";
            // 
            // text_studentName
            // 
            text_studentName.Location = new Point(22, 694);
            text_studentName.Margin = new Padding(4, 5, 4, 5);
            text_studentName.Name = "text_studentName";
            text_studentName.Size = new Size(158, 31);
            text_studentName.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 664);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 19;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 730);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 20;
            label10.Text = "Gender";
            // 
            // text_gender
            // 
            text_gender.Location = new Point(20, 760);
            text_gender.Margin = new Padding(4, 5, 4, 5);
            text_gender.Name = "text_gender";
            text_gender.Size = new Size(158, 31);
            text_gender.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 796);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(58, 25);
            label11.TabIndex = 22;
            label11.Text = "Major";
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(10, 55);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(250, 955);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // text_dateSem
            // 
            text_dateSem.Location = new Point(20, 369);
            text_dateSem.Margin = new Padding(4, 5, 4, 5);
            text_dateSem.Name = "text_dateSem";
            text_dateSem.Size = new Size(160, 31);
            text_dateSem.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(21, 339);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(85, 25);
            label18.TabIndex = 35;
            label18.Text = "Semester";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 273);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(44, 25);
            label17.TabIndex = 34;
            label17.Text = "Year";
            // 
            // text_dateYear
            // 
            text_dateYear.Location = new Point(20, 303);
            text_dateYear.Margin = new Padding(4, 5, 4, 5);
            text_dateYear.Name = "text_dateYear";
            text_dateYear.Size = new Size(160, 31);
            text_dateYear.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(8, 248);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(52, 25);
            label14.TabIndex = 32;
            label14.Text = "Date";
            // 
            // text_courseDepartment
            // 
            text_courseDepartment.Location = new Point(20, 212);
            text_courseDepartment.Margin = new Padding(4, 5, 4, 5);
            text_courseDepartment.Name = "text_courseDepartment";
            text_courseDepartment.Size = new Size(160, 31);
            text_courseDepartment.TabIndex = 31;
            // 
            // text_courseUni
            // 
            text_courseUni.Location = new Point(20, 146);
            text_courseUni.Margin = new Padding(4, 5, 4, 5);
            text_courseUni.Name = "text_courseUni";
            text_courseUni.Size = new Size(160, 31);
            text_courseUni.TabIndex = 30;
            // 
            // text_courseName
            // 
            text_courseName.Location = new Point(20, 80);
            text_courseName.Margin = new Padding(4, 5, 4, 5);
            text_courseName.Name = "text_courseName";
            text_courseName.Size = new Size(160, 31);
            text_courseName.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(3, 639);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(79, 25);
            label16.TabIndex = 28;
            label16.Text = "Student";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(7, 405);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(96, 25);
            label15.TabIndex = 27;
            label15.Text = "Instructor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 182);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(107, 25);
            label13.TabIndex = 25;
            label13.Text = "Department";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(9, 887);
            searchButton.Margin = new Padding(4, 5, 4, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(233, 55);
            searchButton.TabIndex = 24;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // text_major
            // 
            text_major.Location = new Point(22, 826);
            text_major.Margin = new Padding(4, 5, 4, 5);
            text_major.Name = "text_major";
            text_major.Size = new Size(158, 31);
            text_major.TabIndex = 23;
            // 
            // dataGridResults
            // 
            dataGridResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResults.Location = new Point(309, 80);
            dataGridResults.Margin = new Padding(4, 5, 4, 5);
            dataGridResults.Name = "dataGridResults";
            dataGridResults.ReadOnly = true;
            dataGridResults.RowHeadersWidth = 62;
            dataGridResults.Size = new Size(1133, 832);
            dataGridResults.TabIndex = 24;
            dataGridResults.AllowUserToAddRowsChanged += fa;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(309, 963);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(200, 30);
            label12.TabIndex = 25;
            label12.Text = "Number of Entries: ";
            label12.Click += label12_Click;
            // 
            // label_numResults
            // 
            label_numResults.AutoSize = true;
            label_numResults.Font = new Font("Segoe UI", 11F);
            label_numResults.Location = new Point(521, 963);
            label_numResults.Margin = new Padding(4, 0, 4, 0);
            label_numResults.Name = "label_numResults";
            label_numResults.Size = new Size(25, 30);
            label_numResults.TabIndex = 26;
            label_numResults.Text = "0";
            label_numResults.Click += label14_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F);
            label19.Location = new Point(700, 963);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(197, 30);
            label19.TabIndex = 27;
            label19.Text = "Unique Course IDs:";
            // 
            // label_uniqueIds
            // 
            label_uniqueIds.AutoSize = true;
            label_uniqueIds.Font = new Font("Segoe UI", 11F);
            label_uniqueIds.Location = new Point(924, 963);
            label_uniqueIds.Margin = new Padding(4, 0, 4, 0);
            label_uniqueIds.Name = "label_uniqueIds";
            label_uniqueIds.Size = new Size(25, 30);
            label_uniqueIds.TabIndex = 28;
            label_uniqueIds.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 1030);
            Controls.Add(label_uniqueIds);
            Controls.Add(label19);
            Controls.Add(label_numResults);
            Controls.Add(label12);
            Controls.Add(dataGridResults);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
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
    }
}
