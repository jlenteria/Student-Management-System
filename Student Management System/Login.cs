using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Model;

namespace Student_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void username_MouseEnter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = null;
                username.ForeColor = Color.Black;
            }
        }

        private void username_MouseLeave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Red;
            }
        }

        private void password_MouseEnter(object sender, EventArgs e)
        {

            if (password.Text == "Password")
            {
                password.Text = null;
                password.ForeColor = Color.Black;
            }
        }

        private void password_MouseLeave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.ForeColor = Color.Red;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim() == "" || password.Text.Trim() == "")
            {
                MessageBox.Show("Please completed fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int result = WebService.web_service().Login(username.Text.Trim().ToLower(), password.Text.Trim());

                if (result == 1)
                {
                    try
                    {
                        var dt = WebService.web_service().GetAuthByUsername(username.Text.Trim());
                        foreach(DataRow row in dt.Rows)
                        {
                            Auth.Type = row["type"].ToString();
                        }
                        MessageBox.Show(username.Text + " successfully login");
                        username.Text = "Password";
                        password.Text = "Password";
                        username.ForeColor = Color.Red;
                        password.ForeColor = Color.Red;

                        var student = new StudentManagement();
                        student.FormClosed += (o, d) => Close();
                        Hide();
                        student.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }else if (result == 2)
                {
                    MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else if (result == 3)
                {
                    MessageBox.Show("Username is not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            password.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.ForeColor = Color.Black;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            username.ForeColor = Color.Black;
        }
    }
}
