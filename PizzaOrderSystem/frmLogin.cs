using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;
using System.IO;

namespace PizzaOrderSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new Form1());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=DESKTOP-FAMTB43\SQLEXPRESS;Initial Catalog=PizzaDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);

            string query = "SELECT Count(*) FROM tblLogin WHERE username ='"+ txtUsername.Text +"' AND password ='"+ txtPassword.Text +"'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter a username", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            /*else if (!((txtUsername.Text).All(char.IsLetter))) //checks if every character is a letter
            {
                MessageBox.Show("U", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }*/
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                frmOrder orderForm = new frmOrder();
                orderForm.Show();
            }
            else
            {
                MessageBox.Show("Username/Password incorrect", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

    }
}
