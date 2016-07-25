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
    public partial class CustomerRent : Form
    {
        public CustomerRent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MYLENE,49170;Initial Catalog=MovieRentalSystem;Integrated Security=True");
        private void btnRent_Click(object sender, EventArgs e)
        {
            if (CusID.Text == String.Empty ||
               tbMovieID.Text == String.Empty ||
              tbMName.Text == String.Empty ||
              tbGenre.Text == String.Empty ||
               tbLang.Text == String.Empty ||
              tbCast.Text == String.Empty ||
               tbRY.Text == String.Empty ||
               dtpDate.Text == String.Empty)


            {
                MessageBox.Show("Fill up all the Given");
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                da.InsertCommand = new SqlCommand("INSERT INTO Rent VALUES(@RentID,@CustomerID,@MovieID)", con);
                da.InsertCommand.Parameters.Add("@RentID", SqlDbType.VarChar).Value = dtpDate.Text;
                da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = CusID.Text;
                da.InsertCommand.Parameters.Add("@MovieID", SqlDbType.VarChar).Value = tbMovieID.Text;

                da.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rent Successful");
            }
        }

        private void btnMovies_MouseClick(object sender, MouseEventArgs e)
        {

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

        private void dtgMovies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbMovieID.Text = dtgMovies.SelectedRows[0].Cells[0].Value.ToString();
            tbMName.Text = dtgMovies.SelectedRows[0].Cells[1].Value.ToString();
            tbGenre.Text = dtgMovies.SelectedRows[0].Cells[2].Value.ToString();
            tbLang.Text = dtgMovies.SelectedRows[0].Cells[3].Value.ToString();
            tbCast.Text = dtgMovies.SelectedRows[0].Cells[4].Value.ToString();
            tbRY.Text = dtgMovies.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Customer open = new Customer();
            open.Show();
            this.Hide();
        }

        private void CusID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
