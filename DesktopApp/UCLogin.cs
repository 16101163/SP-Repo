using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;


namespace DesktopApp
{
    public partial class UCLogin : UserControl
    {


        public UCLogin()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string Hashb;
            try
            {
                SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                string hash = BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(txtPasswordLogin.Text)));
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SmartPac_Database;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select Password from Users where User_Name=@User_Name", con);
                cmd.Parameters.AddWithValue("@User_Name", txtUsername.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                Hashb = dr[0].ToString();
                con.Close();

                if (hash == Hashb)
                {
                    MessageBox.Show("Login was successful");
                }
                else
                {
                    MessageBox.Show("Login failed, please try again");

                }

            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("Error has occured:"+ex.Message);

            }
        }




        //    MessageBox.Show("Incorrect username or password");
        //    MessageBox.Show("Username or password not entered");

        //    if (txtUsername.Text.ToLower() == "" && txtPassword.Text == "")
        //    {

        //        frmMain activeForm = new frmMain(true);
        //        activeForm.Text = "active";
        //        activeForm.WindowState = FormWindowState.Maximized;
        //        activeForm.ShowDialog();



        //    }
        //    else
        //    {
        //        MessageBox.Show("Incorrect details");
        //    }
        //}

        private void lnlblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAutherization f = new frmAutherization();
            f.ShowDialog();
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
