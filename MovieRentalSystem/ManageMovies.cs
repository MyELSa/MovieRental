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
    public partial class ManageMovies : Form
    {
        public ManageMovies()
        {
            InitializeComponent();
        }

        private void CustomerID_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=MYLENE,49170;Initial Catalog=MovieRentalSystem;Integrated Security=True");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da.InsertCommand = new SqlCommand("INSERT INTO MovieInformation VALUES(@MovieID,@MovieName,@Genre,@Language,@Cast,@YearReleased)", con);
            da.InsertCommand.Parameters.Add("@MovieID", SqlDbType.VarChar).Value = tbMovieID.Text;
            da.InsertCommand.Parameters.Add("@MovieName", SqlDbType.VarChar).Value = tbMName.Text;
            da.InsertCommand.Parameters.Add("@Genre", SqlDbType.VarChar).Value =  cbGenre.Text;
            da.InsertCommand.Parameters.Add("@Language", SqlDbType.VarChar).Value = cbLanguage.Text;
            da.InsertCommand.Parameters.Add("@Cast", SqlDbType.VarChar).Value = tbCast.Text;
            da.InsertCommand.Parameters.Add("@YearReleased", SqlDbType.VarChar).Value = cbYReleased.Text;
            //da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = tbMovieID.Text;


            da.InsertCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save Success");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbYReleased_TextChanged(object sender, EventArgs e)
        {

        }

        ////private void btnUpdate_Click(object sender, EventArgs e)
        ////{
        ////    con.Open();
        ////    SqlDataAdapter da = new SqlDataAdapter();
        ////    da.SelectCommand = new SqlCommand("UPDATE Customer SET @MovieName,@Genre,@Language,@Cast,@YearReleased WHERE @MovieID='" + tbMovieID.Text + "'", con);
        ////    //da.InsertCommand.Parameters.Add("@MovieID", SqlDbType.VarChar).Value = tbMovieID.Text;
        ////    da.InsertCommand.Parameters.Add("@MovieName", SqlDbType.NVarChar).Value = tbMName.Text;
        ////    da.InsertCommand.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = cbGenre.Text;
        ////    da.InsertCommand.Parameters.Add("@Language", SqlDbType.NVarChar).Value = cbLanguage.Text;
        ////    da.InsertCommand.Parameters.Add("@Cast", SqlDbType.NVarChar).Value = tbCast.Text;
        ////    da.InsertCommand.Parameters.Add("@YearReleased", SqlDbType.Date).Value = cbYReleased.Text;
        ////    ////SqlDataAdapter da = new SqlDataAdapter("UPDATE Customer SET FirstName='" + tbFName.Text + "', LastName='" + tbLname.Text + "', MiddleInitial='" + tbMIm.Text + "', Address='" + tbAddrs.Text + "', EmailAddress='" + tbEadd.Text + "', ContactNo='" + tbCn.Text + "', WHERE CustomerID='" + tbCustomerIDm.Text + "'", con);
        ////    ////da.SelectCommand.ExecuteNonQuery();
        ////    con.Close();
        ////    MessageBox.Show("Update Success");
        ////}

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MovieInformation", con);
            DataTable Data = new DataTable();
            dtgView1.DataSource = Data;
            da.Fill(Data);
            con.Close();
           
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("DELETE FROM MovieInformation WHERE MovieID='" + tbMovieID.Text + "'", con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Success");
        }

        private void dtgView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbMovieID.Text = dtgView1.SelectedRows[0].Cells[0].Value.ToString();
            tbMName.Text = dtgView1.SelectedRows[0].Cells[1].Value.ToString();
            cbGenre.Text = dtgView1.SelectedRows[0].Cells[2].Value.ToString();
            cbLanguage.Text = dtgView1.SelectedRows[0].Cells[3].Value.ToString();
            tbCast.Text = dtgView1.SelectedRows[0].Cells[4].Value.ToString();
            cbYReleased.Text = dtgView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnView_Click(object sender, MouseEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Admin open = new Admin();
            open.Show();
            this.Hide();
        }

        private void dtgView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
