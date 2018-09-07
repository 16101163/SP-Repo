using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace DesktopApp
{
    public partial class UCRegisterUser : UserControl
    {
        //SqlCommand cmd = new SqlCommand();
        //SqlConnection con = new SqlConnection();



        public UCRegisterUser()
        {
            InitializeComponent();
        }
        SmartPac_DatabaseEntities db = new SmartPac_DatabaseEntities();
        bool correct = true;
        private void button3_Click(object sender, EventArgs e)
        {
            correct = true;
            //if (txtUsername.Text == "" || txtPassword.Text == "")
            //{
            //    //MessageBox.Show("Please enter all fields");
            //}
            //else 
            //if (txtPassword.Text == txtConfirmPassword.Text)
            //{
            if (correct == true)
            {
                try
                {

                    //SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
                    //UTF8Encoding utf8 = new UTF8Encoding();
                    //string hash = BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(txtConfirmPassword.Text)));
                    //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SmartPac_Database;Integrated Security=True");
                    //SqlCommand cmd = new SqlCommand("insert into Users(User_Name,Password)values(@User_Name,@Password)", con);
                    //cmd.Parameters.AddWithValue("@User_Name", txtUsername.Text);
                    //cmd.Parameters.AddWithValue("@Password", hash);
                    User u = new User();

                    u.Users_Name = txtUsername.Text;
                    u.User_Password = txtPassword.Text;

                    db.Users.Add(u);
                    db.SaveChangesAsync();
                    MessageBox.Show("all good");
                    //int userid = u.Users_Id;
                    //string Template_Value = Convert.ToString(u);
                    //con.Open();

                    //string check = @"(Select count(*) from Users where User_Name='" + txtUsername.Text + "')";
                    //SqlCommand cmda = new SqlCommand(check,con);
                    //int count = (int)cmda.ExecuteScalar();
                    //if (count > 0)
                    //{
                    //    MessageBox.Show("A user with that username already exists");

                    //}
                    //else
                    //{
                    //    cmd.ExecuteNonQuery();
                    //    MessageBox.Show("User successfully registered!");

                    //}

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        //MessageBox.Show("A user with that username already exists");
                    }
                    else
                    {
                        MessageBox.Show("An Error:" + ex.Message);
                    }
                }
            }
               
            }

            //else if (txtPassword.Text != txtConfirmPassword.Text)
            //{

            //    MessageBox.Show("Password and confirm Password fields do not match");

            //}
        



        //    if (txtConfirmPassword.Text == txtPassword.Text)
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("insert into Users" + "(User_Name, Password, Email)values(@User_Name, Password, Email)", con);
        //            cmd.Parameters.AddWithValue("@User_Name", txtUsername.Text);
        //            cmd.Parameters.AddWithValue("@UPassword", txtPassword.Text);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("User has been registered on the system");
        //        }
        //        catch (SqlException ex)
        //        {
        //            if (ex.Number == 2627)
        //            {
        //                MessageBox.Show("A user with that username already exists");
        //            }
        //            else
        //            {
        //                MessageBox.Show("An Error:" + ex.Message);
        //            }


        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Password and Confirm password fields do not match");
        //    }



        //MessageBox.Show("Are you sure you want to Register this User?", "confirmation", MessageBoxButtons.YesNo);
        //MessageBox.Show("User has been registered successfully");
        //MessageBox.Show("Please fill in all required fields");
        //MessageBox.Show("Password and Confirm password fields do not match");



        private void UCRegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
