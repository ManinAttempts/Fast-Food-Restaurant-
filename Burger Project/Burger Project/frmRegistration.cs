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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K8A7CNJ\\MSSQLSERVER01;Initial Catalog=db_users;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into registration_table(username,password,address,phone)values('" + txtUsername.Text.ToString() +
                 "','" + txtPassword.Text.ToString() + "','" + txtAddress.Text.ToString() + "','" + txtPhone.Text.ToString()+ "')",connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
