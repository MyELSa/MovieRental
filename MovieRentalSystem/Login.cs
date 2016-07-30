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
//using System.

namespace MovieRentalSystem
{
    public partial class Login : Form
    {
        public Login()
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
                da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = dtpDate.Text +'_'+ tbLN.Text;

                con.Open();
                da.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer Registered");

                Customer open = new Customer();
                open.Show();
                this.Hide();
                /* con = new SqlConnection("Data Provider=MYLENE-PC;Initial Catalog=MovieRentalSystem;Integrated Security=True");
                con.Open();
                MessageBox.Show(con.State.ToString());
                con.Close();*/


                // SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer where CustomerID='"+ tbID.Text +"'",con);
                // DataTable dt = new DataTable();
                //  sda.Fill(dt);
            }
        }

        private void cbDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbID_Click(object sender, EventArgs e)
        {

        }
        //private int attemptsLeft = 3;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == String.Empty)

            {
                MessageBox.Show("Incorrect Email");
                /*  if (attemptsLeft == 0)
                  {
                      Form1 form = new Form1();
                      form.Show();
                      this.Hide();
                  }*/
            }
         //   else
           // {
//SetValueForFN = tbFN.Text;
            //}
            String a;
            // String b;
            a = tbPassword.Text;
            // b = tbEmail.Text;
            if (a != "admin")
            // if (b != "admin")
            {

                MessageBox.Show("Incorrect Password " /*+ --attemptsLeft */+ " attempts more.", "You're Not the Admin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //if (attemptsLeft == 0)
                //{
                //    Application.Exit();
                //}
            }
            else
            {
                Admin Form = new Admin();
                Form.Show();
                this.Hide();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!! Rent Again ");
            Application.Exit();
        }

        private void tbEmailR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStaffL_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == String.Empty)

            {
                MessageBox.Show("Incorrect Email");

            }

            String a;
            // String b;
            a = tbPassword.Text;
            // b = tbEmail.Text;
            if (a != "staff")
            // if (b != "admin")
            {

                MessageBox.Show("Incorrect Password " +/* --attemptsLeft+*/ " attempts more.", "You're Not the Admin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //if (attemptsLeft == 0)
                //{
                //    Application.Exit();
                //}
            }
            else
            {
                Staff Form = new Staff();
                Form.Show();
                this.Hide();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

