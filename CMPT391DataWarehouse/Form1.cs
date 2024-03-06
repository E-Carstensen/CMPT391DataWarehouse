using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPT391DataWarehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            string sqlQuery = "SELECT * FROM Course_Fact_Table as CFT";

            sqlQuery += checkSectionFilters();
            sqlQuery += checkStudentFilters();
            sqlQuery += checkInstructorFilters();
            sqlQuery += checkCourseFilters();

            sqlQuery += addJoinStatements(sqlQuery);

            label1.Text = sqlQuery;

            executeQuery(sqlQuery);

            System.Diagnostics.Debug.WriteLine(sqlQuery);

            updateLabels();

        }

        private void executeQuery(string sqlQuery)
        {
            DataTable dt = new DataTable();


            string connectionString = "server=(local);Database=CMPT391DataWarehouse;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("proc_exec_query", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@query", SqlDbType.NVarChar).Value = sqlQuery;

                    conn.Open();



                    dt.Load(cmd.ExecuteReader());
                    dataGridResults.DataSource = dt;

                    conn.Close();


                }
            }
            catch (SqlException ex) { label_numResults.Text += "\n" + ex.Message; }
        }

        private void updateLabels()
        {
            label_numResults.Text = (dataGridResults.Rows.Count - 1).ToString();
            label_uniqueIds.Text = countUniqueCourses().ToString();


        }

        private int countUniqueCourses()
        {
            int columnIndex = 0;
            HashSet<object> uniqueValues = new HashSet<object>();

            foreach (DataGridViewRow row in dataGridResults.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    uniqueValues.Add(row.Cells[columnIndex].Value);
                }
            }

            int count = uniqueValues.Count;
            return count;

        }


        private string checkCourseFilters()
        {
            string output = "";

            if (text_courseName.Text.Length > 0)
            {
                output = "Name = '" + text_courseName.Text + "'";
            }

            if (text_courseDepartment.Text.Length > 0)
            {
                if (output.Length > 0) { output += " AND "; }
                output += "Department = '" + text_courseDepartment.Text + "'";
            }

            if (text_courseUni.Text.Length > 0)
            {
                if (output.Length > 0) { output += " AND "; }
                output += "University = '" + text_courseUni.Text + "'";
            }


            if (output.Length > 0) { output = ", (SELECT *, Name FROM Course WHERE " + output + ") as C"; }
            return output;
        }


        private string checkInstructorFilters()
        {
            string output = "";

            if (text_instructorName.Text.Length > 0)
            {
                output = "Name = '" + text_instructorName.Text + "'";
            }

            if (text_faculty.Text.Length > 0)
            {
                if (output.Length > 0) { output += " AND "; }
                output += "Faculty = '" + text_faculty.Text + "'";
            }

            if (text_rank.Text.Length > 0)
            {
                if (output.Length > 0) { output += " AND "; }
                output += "Rank = '" + text_rank.Text + "'";
            }

            if (output.Length > 0) { output = ", (Select InstructorID, Name FROM Instructor WHERE " + output + ") AS I"; }


            return output;
        }


        private string checkStudentFilters()
        {
            string output = "";

            if (text_studentName.Text.Length > 0)
            {
                output = "Name = '" + text_studentName.Text + "'";
            }

            if (text_gender.Text.Length > 0)
            {
                if (output.Length > 0) { output += " AND "; }
                output += "Gender = '" + text_gender.Text + "'";
            }

            if (text_major.Text.Length > 0)
            {
                if (output.Length > 0) { output += " AND "; }
                output += "Major = '" + text_major.Text + "'";

            }

            if (output.Length > 0) { output = ", (SELECT StudentID, Major FROM Student WHERE " + output + ") AS S"; }

            return output;
        }


        private string checkSectionFilters()
        {
            string output = "";



            if (text_dateSem.Text.Length > 0)
            {
                output += "Semester = '" + text_dateSem.Text + "'";

            }

            if (text_dateYear.Text.Length > 0)
            {
                if (output.Length > 0) { output += "AND "; }
                output += "Year = " + text_dateYear.Text;
            }

            if (output.Length > 0) { output = ", (SELECT SectionID FROM Section WHERE " + output + ") AS D"; }

            return output;

        }



        private string addJoinStatements(string input)
        {

            string output = "";
            if (input.Contains("StudentID"))
            {
                output += "CFT.StudentID = S.StudentID";
            }

            if (input.Contains("SectionID"))
            {
                if (output.Length > 0) { output += " AND "; }
                output += "CFT.SectionID = D.SectionID";
            }

            if (input.Contains("InstructorID"))
            {
                if (output.Length > 0) { output += " AND "; }
                output += "CFT.InstructorID = I.InstructorID";
            }

            if (input.Contains("CourseID"))
            {
                if (output.Length > 0) { output += " AND "; }
                output += "CFT.CourseID = C.CourseID";
            }


            if (output.Length > 0) { output = " WHERE " + output; }
            return output;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fa(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
