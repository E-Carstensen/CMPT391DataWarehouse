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

            string sqlQuery = "SELECT * FROM Course_Fact_Table as CFT ";

            sqlQuery += checkDateFilters();
            sqlQuery += checkStudentFilters();


            label_numResults.Text = sqlQuery;

            Console.WriteLine(sqlQuery);



        }


        private string checkInstructorFilters()
        {
            string output = "";

            if(text_instructorName.Text.Length > 0)
            {
                output = "Name = '" + text_instructorName.Text +"'";
            }

            if(text_faculty.Text.Length > 0)
            {
                if(output.Length > 0) { output += " AND "; }
                output += "Faculty = '" + text_faculty.Text + "'";
            }

            if(text_rank.Text.Length > 0)
            {
                if (output.Length > 0) { output += " AND "; }
                output += "Rank = '" + text_rank.Text + "'";
            }

            if (output.Length > 0) { output = ", (Select InstructorID FROM Instructor WHERE " +  output + ") AS I"; }


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
                output += "Gender = '" + text_gender + "'";
            }

            if (text_major.Text.Length > 0)
            {
                if (output.Length > 0) { output += " AND "; }
                output += "Major = '" + text_major.Text + "'";

            }

            if (output.Length > 0) { output = ", (SELECT StudentID FROM Student WHERE " + output + ") AS S"; }

            return output;
        }


        private string checkDateFilters()
        {
            string output = "";

            if (combo_year.SelectedIndex > 0 || combo_sem.SelectedIndex > 0) {
                output += ", (SELECT SectionID FROM Section WHERE ";
            }

            if (combo_sem.SelectedIndex > 0)
            {
                output += "Semester = '" + combo_sem.SelectedText + "'";
                if (combo_year.SelectedIndex > 0)
                {
                    output += " AND ";
                }
            }

            if (combo_year.SelectedIndex > 0)
            {
                output += "Year = " + combo_year.SelectedText;
            }

            if (output.Length > 0) { output += ") AS D"; }

            return output;

        }



        private string addJoinStatements(string input)
        {

            string output = "";
            if (input.Contains("StudentID"))
            {
                output += "WHERE CFT.StudentID = S.StudentID";
            }

            if (input.Contains("SectionID"))
            {
                if (output.Length > 0) { output += " AND "; }
                output += "WHERE CFT.SectionID = D.SectionID";
            }

            if (input.Contains("InstructorID"))
            {
                if (output.Length > 0) { output += " AND "; }
                output += "WHERE CFT.InstructorID = I.InstructorID";
            }




            return output;
        }
    }
}
