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
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            if (username.Text == ""  || password1.Text.Trim() == "" || userType.SelectedIndex == -1)
            {

                MessageBox.Show("Please completed all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (password2.Text.Trim() != password1.Text.Trim())
                {
                    MessageBox.Show("Password don't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                Auth.Input[0] = username.Text.Trim().ToLower();
                Auth.Input[1] = password1.Text.Trim();
                Auth.Input[2] = userType.Text;

                int result = WebService.web_service().AddUser(Auth.Input);
                if (result == 100)
                {
                    MessageBox.Show("User is already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 400)
                {
                    MessageBox.Show("Ooops, there is something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 200)
                {
                    MessageBox.Show("User successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    username.Clear();
                    password1.Clear();
                    password2.Clear();
                    userType.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchAuthButton_Click(object sender, EventArgs e)
        {
            if (searchAuth.Text.Trim() == "")
            {
                MessageBox.Show("Please specify username");
            }
            else
            {
                try
                {
                    var dt = WebService.web_service().GetAuthByUsername(searchAuth.Text.Trim().ToLower());
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Data found");
                        editUserPanel.Visible = true;

                        foreach (DataRow row in dt.Rows)
                        {
                            Auth.Id = (int)Convert.ToInt64(row["Id"].ToString());
                            newUsername.Text = row["Username"].ToString();
                            newPass.Text = row["Password"].ToString();
                            newType.Text = row["Type"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Data found");
                        editUserPanel.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            newPass.PasswordChar = checkPassword.Checked ? '\0' : '*';
        }

        private void closeEditUser_Click(object sender, EventArgs e)
        {
            editUserPanel.Visible = false;
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this user ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                WebService.web_service().DeleteAuth(Auth.Id);
                MessageBox.Show("User successfully deleted");
                editUserPanel.Visible = false;
            }
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            if (newUsername.Text == "" || newPass.Text.Trim() == "" || newType.SelectedIndex == -1)
            {
                MessageBox.Show("Please completed all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                Auth.Input[0] = newUsername.Text.Trim().ToLower();
                Auth.Input[1] = newPass.Text.Trim();
                Auth.Input[2] = newType.Text;
                
                int result = WebService.web_service().EditAuth(Auth.Input, Auth.Id);
                if (result == 100)
                {
                    MessageBox.Show("User is already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 400)
                {
                    MessageBox.Show("Ooops, there is something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 200)
                {
                    MessageBox.Show("User successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    editUserPanel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
