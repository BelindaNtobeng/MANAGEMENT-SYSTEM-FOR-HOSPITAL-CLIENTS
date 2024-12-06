using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem_Q1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=Siiink0mode;Initial Catalog=eHealth Care Hospital Management System;Integrated Security=True;Encrypt=False";
        public Form1()
        {
            InitializeComponent();
            ShowPatientsRecords();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eHealth_Care_Hospital_Management_SystemDataSet.HospitalManagementSystem' table. You can move, or remove it, as needed.
            this.hospitalManagementSystemTableAdapter.Fill(this.eHealth_Care_Hospital_Management_SystemDataSet.HospitalManagementSystem);

        }
        private bool NoEmptyField()
        {
            if (string.IsNullOrWhiteSpace(fullName.Text) ||
                string.IsNullOrWhiteSpace(patientNo.Text) ||
                string.IsNullOrWhiteSpace(phoneNo.Text) ||
                string.IsNullOrWhiteSpace(illness.Text) ||
                string.IsNullOrWhiteSpace(birthDate.Text) ||
                comboPatientType.SelectedItem == null ||
                comboGender.SelectedItem == null ||
                comboProvince.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields before saving.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void SaveRecordToDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare SQL query to insert data into the database table
                    string query = "INSERT INTO HospitalManagementSystem (PatientNo, FullName, PhoneNumber, Illness, DOB, PatientType, Gender, Province) " +
                                   "VALUES (@PatientNo, @FullName, @PhoneNumber, @Illness, @DOB, @PatientType, @Gender, @Province)";

                    // Create SQL command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PatientNo", patientNo.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNo.Text);
                    command.Parameters.AddWithValue("@Illness", illness.Text);
                    command.Parameters.AddWithValue("@fullName", fullName.Text);
                    DateTime dob;
                    if (DateTime.TryParse(birthDate.Text, out dob))
                    {
                        command.Parameters.AddWithValue("@DOB", dob);
                    }
                    else
                    {
                        MessageBox.Show("Date of Birth must be a valid date.", "Invalid Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Stop execution if Date of Birth is invalid
                    }
                    command.Parameters.AddWithValue("@PatientType", comboPatientType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Gender", comboGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Province", comboProvince.SelectedItem.ToString());


                    // Execute the command
                    command.ExecuteNonQuery();

                    // Display success message
                    MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowPatientsRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
      
        private void ShowPatientsRecords() 
        {
            try 
            {
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM  HospitalManagementSystem";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RetrievePatientRecord(string patientNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM  HospitalManagementSystem WHERE PatientNo = @PatientNo";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PatientNo", patientNo);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Patient record not found.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletePatientRecord(string patientNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM HospitalManagementSystem WHERE PatientNo = @PatientNo";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PatientNo", patientNo);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowPatientsRecords();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the provided patient number.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (NoEmptyField())
            {
                return; // Stop execution if fields are empty
            }
            else
            {
                SaveRecordToDatabase();
                phoneNo.Text = "";
                fullName.Text = "";
                patientNo.Text = "";
                illness.Text = "";
                birthDate.Text = "";
                comboPatientType.SelectedIndex = -1;
                comboGender.SelectedIndex = -1; 
                comboProvince.SelectedIndex = -1;
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string patientNo = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(patientNo))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeletePatientRecord(patientNo);
                }
            }
            else
            {
                MessageBox.Show("Please enter the patient number.", "Missing Patient Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string patientNo = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(patientNo))
            {
                RetrievePatientRecord(patientNo);
            }
            else
            {
                MessageBox.Show("Please enter the patient number.", "Missing Patient Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
         
             ShowPatientsRecords();
        

        }
    }
}
    

