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


namespace Burger_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-K8A7CNJ\\MSSQLSERVER01;Initial Catalog=db_users;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM registration_table", con); 
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    if (txtUsername.Text == row["username"].ToString())
                    {
                        if (txtPassword.Text == row["password"].ToString())
                        {
                            MessageBox.Show("You're logged in");
                        }
                    }
                }
               

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegistration fr = new frmRegistration();
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
