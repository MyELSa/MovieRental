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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MYLENE,49170;Initial Catalog=MovieRentalSystem;Integrated Security=True");
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (tbCustomerIDm.Text == String.Empty ||
               tbFName.Text == String.Empty ||
              tbMIm.Text == String.Empty ||
              tbLname.Text == String.Empty ||
               tbAddrs.Text == String.Empty ||
              tbEadd.Text == String.Empty ||
               tbCn.Text == String.Empty)


            {
                MessageBox.Show("Fill up all the Given");
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                da.InsertCommand = new SqlCommand("INSERT INTO Customer VALUES(@CustomerID,@FirstName,@LastName,@MiddleInitial,@Address,@EmailAddress,@ContactNo)", con);
                da.InsertCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = tbFName.Text;
                da.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = tbLname.Text;
                da.InsertCommand.Parameters.Add("@MiddleInitial", SqlDbType.VarChar).Value = tbMIm.Text;
                da.InsertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = tbAddrs.Text;
                da.InsertCommand.Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = tbEadd.Text;
                da.InsertCommand.Parameters.Add("@ContactNo", SqlDbType.Int).Value = tbCn.Text;
                da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = tbCustomerIDm.Text;


                da.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Success");

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
             con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", con);
            DataTable Data = new DataTable();
            dtgView.DataSource = Data;
            da.Fill(Data);
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Admin open = new Admin();
            open.Show();
            this.Hide();
            
        }

        private void dtgView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbCustomerIDm.Text = dtgView.SelectedRows[0].Cells[0].Value.ToString();
            tbFName.Text = dtgView.SelectedRows[0].Cells[1].Value.ToString();
            tbLname.Text = dtgView.SelectedRows[0].Cells[2].Value.ToString();
            tbMIm.Text = dtgView.SelectedRows[0].Cells[3].Value.ToString();
            tbAddrs.Text = dtgView.SelectedRows[0].Cells[4].Value.ToString();
            tbEadd.Text = dtgView.SelectedRows[0].Cells[5].Value.ToString();
            tbCn.Text = dtgView.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("DELETE FROM Customer WHERE CustomerID='" + tbCustomerIDm.Text + "'", con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Success");
        }
    }
}
