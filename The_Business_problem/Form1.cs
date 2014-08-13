using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace The_Business_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases"));

            string connectionString = null;
            SqlConnection cnn;
          //connectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename="+Application.StartupPath + "NORTHWND.MDF;Integrated Security=True";
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
     
           connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\krisw\\Desktop\\vs\\The_Business_problem\\The_Business_problem\\NORTHWND.MDF;Integrated Security=True";
           
            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
               // MessageBox.Show(lbSupervisor.ValueMember);
                 //cnn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Failed!"); }

            SqlCommand cmd = new SqlCommand("insert into Employees(LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo) values (@LastName,@FirstName,@Title,@TitleOfCourtesy,@BirthDate,@HireDate,@Address,@City,@Region,@PostalCode,@Country,@HomePhone,@Extension,@Notes,@ReportsTo)",cnn);
            cmd.Parameters.AddWithValue("@LastName", tbLastName.Text);
            cmd.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@Title", tbTitle.Text);
            cmd.Parameters.AddWithValue("@TitleOfCourtesy", tbCourtesy.Text);
            //cmd.Parameters.AddWithValue("@BirthDate",tbBirthDate.Text);
            cmd.Parameters.AddWithValue("@BirthDate",dtpDOB.Value );
            //cmd.Parameters.AddWithValue("@HireDate", tbHireDate.Text);
            cmd.Parameters.AddWithValue("@HireDate", dtpHire.Value);
            cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
            cmd.Parameters.AddWithValue("@City", tbCity.Text);
            cmd.Parameters.AddWithValue("@Region", tbRegion.Text);
            cmd.Parameters.AddWithValue("@PostalCode", tbPostal.Text);
            cmd.Parameters.AddWithValue("@Country", tbCountry.Text);
            cmd.Parameters.AddWithValue("@HomePhone", tbHomePhone.Text);
            cmd.Parameters.AddWithValue("@Extension", tbExtension.Text);
            cmd.Parameters.AddWithValue("@Notes", tbNotes.Text);
            cmd.Parameters.AddWithValue("@ReportsTo", Convert.ToInt64(lbSupervisor.SelectedValue));
           // cmd.ExecuteNonQuery();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
            }

            catch (Exception ex)
            { MessageBox.Show("Failed!"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet3.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.nORTHWNDDataSet3.Employees);
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
