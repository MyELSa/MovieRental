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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (///tbID.Text == String.Empty || 
                tbFN.Text == String.Empty ||
               tbMI.Text == String.Empty ||
               tbLN.Text == String.Empty ||
               tbAddress.Text == String.Empty ||
               tbContact.Text == String.Empty ||
               tbEmailR.Text == String.Empty ||
               // cbMM.Text == String.Empty ||
               //cbDD.Text == String.Empty ||
               dtpDate.Text == String.Empty)


            {
                MessageBox.Show("Fill up all the Given");
            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source=MYLENE,49170;Initial Catalog=MovieRentalSystem;Integrated Security=True");//("Data Source=192.168.1.3,49170;Initial Catalog=MovieRentalSystem;Integrated Security=True");                                                                                                                      // con.Close();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                da.InsertCommand = new SqlCommand("INSERT INTO Customer VALUES(@CustomerID,@FirstName,@LastName,@MiddleInitial,@Address,@EmailAddress,@ContactNo)", con);
                da.InsertCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = tbFN.Text;
                da.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = tbLN.Text;
                da.InsertCommand.Parameters.Add("@MiddleInitial", SqlDbType.VarChar).Value = tbMI.Text;
                da.InsertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = tbAddress.Text;
                da.InsertCommand.Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = tbEmailR.Text;
                da.InsertCommand.Parameters.Add("@ContactNo", SqlDbType.Int).Value = tbContact.Text;
                da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = dtpDate.Text + '_' + tbLN.Text;

                con.Open();
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer Registered");

                              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff open = new Staff();
            open.Show();
            this.Hide();
        }
    }
}
