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
using System.Configuration;

namespace Video_Store
{
    public partial class Form1 : Form
    {
        public static string connString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(connString);
        int CustId = 0;
        int MovieID = 0;
        int RentedMovieID = 0;
        public DatabaseManager Databasemanager = new DatabaseManager(); //instantiate database manager class
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            dataGridViewDatabase.DataSource = GetCustomersList();
            dataGridViewMovies.DataSource = GetMoviesList();
            dataGridViewRentals.DataSource = GetRentalsList();
            FillDataGridviewCustomers();
            FillDataGridviewMovies();
            FillDataGridviewRentalMovies();
        }

        private DataTable GetCustomersList()    // 1. Customers Database
        {
            using (SqlCommand sqlcmd = new SqlCommand(" SELECT * from Customer ", sqlconn))
            {
                DataTable dtCustomers = new DataTable();          
                sqlconn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtCustomers.Load(reader);
                sqlconn.Close();
                return dtCustomers;
            }                    
        }
        private DataTable GetMoviesList()    //2. Movies Database
        {
            using (SqlCommand sqlcmd = new SqlCommand(" SELECT * from Movies ", sqlconn))
            {
                DataTable dtMovies = new DataTable();
                sqlconn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtMovies.Load(reader);
                sqlconn.Close();
                return dtMovies;
            }          
        }
        private DataTable GetRentalsList()    //3. Rental Movies Database
        {
            
            using (SqlCommand sqlcmd = new SqlCommand("SELECT FirstName, LastName, Address, Title, RentalCost, DateRented, DateRented FROM Customer t1 INNER JOIN RentedMovies t2 ON t1.CustId = t2.CustIdFK INNER JOIN Movies t3 ON t3.MovieID = t2.MovieIDFK", sqlconn))
            {
                DataTable dtRentalMovies = new DataTable();
                sqlconn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtRentalMovies.Load(reader);
                sqlconn.Close();
                return dtRentalMovies;
            }
        }
        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void IssueMovie()               // Issue Movie Function
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("IssueMovie", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure; // used to store  procedures
                    sqlcmd.Parameters.AddWithValue("@mode", "Issue");
                    sqlcmd.Parameters.AddWithValue("@RentedMovieID", 0);
                    sqlcmd.Parameters.AddWithValue("@first_name", dataGridViewDatabase.CurrentRow.Cells[1].Value);
                    sqlcmd.Parameters.AddWithValue("@last_name", dataGridViewDatabase.CurrentRow.Cells[2].Value);
                    sqlcmd.Parameters.AddWithValue("@cust_address", dataGridViewDatabase.CurrentRow.Cells[3].Value);
                    sqlcmd.Parameters.AddWithValue("@movie_title", dataGridViewMovies.CurrentRow.Cells[1].Value);
                    sqlcmd.Parameters.AddWithValue("@rental_cost", dataGridViewMovies.CurrentRow.Cells[5].Value);
                    sqlcmd.Parameters.AddWithValue("@dateRented", DateTime.Now);
                    sqlcmd.Parameters.AddWithValue("@dateReturned", DBNull.Value);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show(" Add Sucessful in Rental Database ! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " : Error ! ");

            }
            sqlconn.Close();
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)         //Issue Movie Button
        {
            IssueMovie();
        }

        public void ReturnMovie()               // Return Movie Function
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("ReturnMovie", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure; // used to store  procedures
                    sqlcmd.Parameters.AddWithValue("@mode", "Return");

                    sqlcmd.Parameters.AddWithValue("@RentedMovieID", RentedMovieID);
                    sqlcmd.Parameters.AddWithValue("@dateReturned", DateTime.Now);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show(" Return Sucessful ! ");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " : Error ! ");
            }
            sqlconn.Close();
        }

    
        public void btnReturnMovie_Click(object sender, EventArgs e)        //Return Movie Button
        {
            ReturnMovie();       
        }

        
            private void tabPageCustomers_Click(object sender, EventArgs e)
        {

        }

        private void tabPageMovies_Click(object sender, EventArgs e)
        {

        }

        private void AddCustbtn_Click(object sender, EventArgs e) // ADD Customer btn, changes to EDIT when editing query
        {
            try
            {
                if (sqlconn.State  == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    if (AddCustbtn.Text == "Add Customer")
                    {
                        SqlCommand sqlcmd = new SqlCommand("CustAddorEdit", sqlconn);  // Sql coommand is used to enter data
                        sqlcmd.CommandType = CommandType.StoredProcedure; // used to store  procedures
                        sqlcmd.Parameters.AddWithValue("@mode", "Add");
                        sqlcmd.Parameters.AddWithValue("@CustId", 0);
                        sqlcmd.Parameters.AddWithValue("@firstname", textBoxFname.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@lastname", textBoxLname.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@phone", textBoxPhone.Text.Trim());
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Add Sucessful in Database ! ");
                    }
                    else
                    {
                        SqlCommand sqlcmd = new SqlCommand("CustAddorEdit", sqlconn);  
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlcmd.Parameters.AddWithValue("@CustId", CustId);
                        sqlcmd.Parameters.AddWithValue("@firstname", textBoxFname.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@lastname", textBoxLname.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@phone", textBoxPhone.Text.Trim());
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Edit! Sucessful in Database ");
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error Message " , ex.Message);
            }
            sqlconn.Close();
        }
        private void AddMoviebtn_Click(object sender, EventArgs e)  // ADD Movies btn, changes to EDIT when editing query
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    if (AddMoviebtn.Text == "Add Movie")
                    {
                        SqlCommand sqlcmd = new SqlCommand("MoviesAddorEdit", sqlconn);  // Sql coommand is used to enter data
                        sqlcmd.CommandType = CommandType.StoredProcedure; // used to store  procedures
                        sqlcmd.Parameters.AddWithValue("@mode", "Add");
                        sqlcmd.Parameters.AddWithValue("@MovieId", 0);
                        sqlcmd.Parameters.AddWithValue("@title", textBoxTitle.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@year", textBoxYear .Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@genre", textBoxGenre.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@rating", textBoxRating.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@rentalcost", textBoxRentalCost.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@releasedate", textBoxReleaseDate.Text.Trim());
                        

                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Add Sucessful in Customer Database ! ");
                    }
                    else
                    {
                        SqlCommand sqlcmd = new SqlCommand("MoviesAddorEdit", sqlconn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlcmd.Parameters.AddWithValue("@MovieId", MovieID);
                        sqlcmd.Parameters.AddWithValue("@title", textBoxTitle.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@year", textBoxYear.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@genre", textBoxGenre.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@rating", textBoxRating.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@rentalcost", textBoxRentalCost.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@releasedate", textBoxReleaseDate.Text.Trim());
            
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Edit! Sucessful in Movies Database ");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error Message ", ex.Message);
            }
            sqlconn.Close();                                                 // *****SEARCH FUNCTIONS ALL Start *****
        }
        public void FillDataGridviewCustomers()  //Search function for Customer Database
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("CustViewOrSearch", sqlconn);// Data Adapter is used to retrieve data 
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@CustName", textSearch.Text.Trim());
                DataTable dtSearch = new DataTable();
                sqlDa.Fill(dtSearch);                                      // search data is stored in dataTable search
                dataGridViewDatabase.DataSource = dtSearch;
                sqlconn.Close();
            }                                                     
        }

        public void FillDataGridviewMovies()  //Search function for Movies Database
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("MoviesViewOrSearch", sqlconn);// Data Adapter is used to retrieve data 
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@RentalMovieName", textSearch.Text.Trim());
                DataTable dtSearch = new DataTable();
                sqlDa.Fill(dtSearch);  // search data is stored in dataTable search
                dataGridViewMovies.DataSource = dtSearch;
                sqlconn.Close();
            }
        }
        public void FillDataGridviewRentalMovies()  //Search function for Movies Database
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("RentalMoviesViewOrSearch", sqlconn);// Data Adapter is used to retrieve data 
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@RentalMovieName", textSearch.Text.Trim());
                DataTable dtSearch = new DataTable();
                sqlDa.Fill(dtSearch);// search data is stored in dataTable search
                dataGridViewRentals.DataSource = dtSearch;
                dataGridViewRentals.Columns[1].Visible = false;
                dataGridViewRentals.Columns[2].Visible = false;
                sqlconn.Close();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e) //Search Button with functions
        {
            try
            {
                FillDataGridviewCustomers();
                FillDataGridviewMovies();
                FillDataGridviewRentalMovies();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(" Error Message ", ex.Message);
            }                                                                   // *****SEARCH FUNCTIONS ALL End******
        }

        private void dataGridViewDatabase_DoubleClick(object sender, EventArgs e)// Customer Database edit Query
        {
            if (dataGridViewDatabase.CurrentRow.Index != -1)
            {
                CustId = Convert.ToInt32(dataGridViewDatabase.CurrentRow.Cells[0].Value.ToString());
                textBoxFname.Text = dataGridViewDatabase.CurrentRow.Cells[1].Value.ToString();
                textBoxLname.Text = dataGridViewDatabase.CurrentRow.Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridViewDatabase.CurrentRow.Cells[3].Value.ToString();
                textBoxPhone.Text = dataGridViewDatabase.CurrentRow.Cells[4].Value.ToString();
                AddCustbtn.Text = " Update Customer";
                DeleteCustbtn.Enabled = true;
            }
        }

        private void dataGridViewMovies_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Movies Database Edit
        {
            if (dataGridViewMovies.CurrentRow.Index != -1)
            {
                MovieID = Convert.ToInt32(dataGridViewMovies.CurrentRow.Cells[0].Value.ToString());
                textBoxTitle.Text = dataGridViewMovies.CurrentRow.Cells[1].Value.ToString();
                textBoxYear.Text = dataGridViewMovies.CurrentRow.Cells[2].Value.ToString();
                textBoxGenre.Text = dataGridViewMovies.CurrentRow.Cells[3].Value.ToString();
                textBoxRating.Text = dataGridViewMovies.CurrentRow.Cells[4].Value.ToString();
                textBoxRentalCost.Text = dataGridViewMovies.CurrentRow.Cells[5].Value.ToString();
                textBoxReleaseDate.Text = dataGridViewMovies.CurrentRow.Cells[6].Value.ToString();
                AddMoviebtn.Text = " Update Movie";
                DeleteMoviebtn.Enabled = true;
            }
        }

        private void dataGridViewRentals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //RentedMovieID = Convert.ToInt32(dataGridViewRentals.CurrentRow.Cells[0].Value.ToString());
            //textBoxReturnDate.Text = dataGridViewRentals.CurrentRow.Cells[9].Value.ToString();

        }

        private void DeleteCustbtn_Click(object sender, EventArgs e)// DELETE CUSTOMER BUTTON
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    
                        SqlCommand sqlcmd = new SqlCommand("CustDelete", sqlconn);// Sql coommand is used to enter data
                        sqlcmd.CommandType = CommandType.StoredProcedure;// used to store  procedures                  
                        sqlcmd.Parameters.AddWithValue("@CustId", CustId);                        
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Delete! Sucessful in Database ! ");
                        FillDataGridviewCustomers();
                    }
                }
            catch (Exception ex)
            {

                MessageBox.Show(" Error Message ", ex.Message);
            }
        }

        private void DeleteMoviebtn_Click(object sender, EventArgs e)// DELETE MOVIE BUTTON
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();

                SqlCommand sqlcmd = new SqlCommand("MoviesDelete", sqlconn);// Sql coommand is used to enter data
                sqlcmd.CommandType = CommandType.StoredProcedure;// StoredProcedure is used to store  procedures

                sqlcmd.Parameters.AddWithValue("@MovieId", MovieID);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show(" Delete! Sucessful in Database ! ");
                FillDataGridviewMovies();
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (sqlconn.State == ConnectionState.Closed)
        //    {
        //        sqlconn.Open();

        //        SqlCommand sqlcmd = new SqlCommand("RentalsDelete", sqlconn);// Sql coommand is used to enter data
        //        sqlcmd.CommandType = CommandType.StoredProcedure;// StoredProcedure is used to store  procedures
        //        sqlcmd.Parameters.AddWithValue("@RentedMovieID", RentedMovieID);
        //        sqlcmd.ExecuteNonQuery();
        //        MessageBox.Show(" Delete! Sucessful in Rentals Database ! ");
        //        FillDataGridviewRentalMovies();
        //    }
        //}

        private void dataGridViewRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
    }
}

