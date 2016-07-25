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


namespace MovieRentalSystem
{
    public partial class RentMovies : Form
    {
        public RentMovies()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MYLENE,49170;Initial Catalog=MovieRentalSystem;Integrated Security=True");
        private void dtgMovies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbMovieId.Text = dtgMovies.SelectedRows[0].Cells[0].Value.ToString();
            //tbMName.Text = dtgMovies.SelectedRows[0].Cells[1].Value.ToString();
            //cbGenre.Text = dtgMovies.SelectedRows[0].Cells[2].Value.ToString();
            //cbLanguage.Text = dtgMovies.SelectedRows[0].Cells[3].Value.ToString();
            //tbCast.Text = dtgMovies.SelectedRows[0].Cells[4].Value.ToString();
            //cbYReleased.Text = dtgMovies.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", con);
            DataTable Data = new DataTable();
            dtgCustomers.DataSource = Data;
            da.Fill(Data);
            con.Close();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MovieInformation", con);
            DataTable Data = new DataTable();
            dtgMovies.DataSource = Data;
            da.Fill(Data);
            con.Close();
        }

        private void dtgCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbCustomerID.Text = dtgCustomers.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (RentID.Text == String.Empty ||
               tbMovieId.Text == String.Empty ||
                 tbCustomerID.Text == String.Empty)


            {
                MessageBox.Show("Fill up all the Given");
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                da.InsertCommand = new SqlCommand("INSERT INTO Rent VALUES(@RentID,@CustomerID,@MovieID)", con);
                da.InsertCommand.Parameters.Add("@RentID", SqlDbType.VarChar).Value = RentID.Text;
                da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = tbMovieId.Text;
                da.InsertCommand.Parameters.Add("@MovieID", SqlDbType.VarChar).Value = tbCustomerID.Text;

                da.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rent Successful");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Staff open = new Staff();
            open.Show();
            this.Hide();

        }
    }
}
