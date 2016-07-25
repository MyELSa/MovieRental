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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MYLENE,49170;Initial Catalog=MovieRentalSystem;Integrated Security=True");
        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSO_Click(object sender, EventArgs e)
        {
            Login show = new Login();
            show.Show();
            this.Hide();
        }

        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnMovies_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MovieInformation", con);
            DataTable Data = new DataTable();
            dgvTransaction.DataSource = Data;
            da.Fill(Data);
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            CustomerRent open = new CustomerRent();
            open.Show();
            this.Hide();
        }
    }
}
