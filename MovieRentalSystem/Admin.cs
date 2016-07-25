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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MYLENE,49170;Initial Catalog=MovieRentalSystem;Integrated Security=True");
        private void btnSO_Click(object sender, EventArgs e)
        {
            Login show = new Login();
            show.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRented_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReserve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageCustomer open = new ManageCustomer();
            open.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageMovies open = new ManageMovies();
            open.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movies open = new Movies();
            open.Show();
            this.Hide();
        }

        private void btnRented_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rent", con);
            DataTable Data = new DataTable();
            dgvMovies.DataSource = Data;
            da.Fill(Data);
            con.Close();
        }

        //private void btnCustomers_Click(object sender, EventArgs e)
        //{
        //    con.Open();
        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", con);
        //    DataTable Data = new DataTable();
        //    dgvCustomers.DataSource = Data;
        //    da.Fill(Data);
        //    con.Close();
        //}

        private void dgvRented_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", con);
            DataTable Data = new DataTable();
            dgvCust.DataSource = Data;
            da.Fill(Data);
            con.Close();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MovieInformation", con);
            DataTable Data = new DataTable();
            dtvMov.DataSource = Data;
            da.Fill(Data);
            con.Close();
        }
    }
}
