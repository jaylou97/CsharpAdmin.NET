using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PayParkingAdminCsharp
{
    public partial class UpdateForm : MaterialForm
    {
        private Dashboard dashboard;

        int formId;
        string? formUserName, formUserType, formStore, formPass;
        public UpdateForm(Dashboard dashboard, int id, string? userName, string? userType, string? store)
        {
            InitializeComponent();
            // pass the reference to the original Dashboard form
            this.dashboard = dashboard;

            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Red800,
                Primary.Red900,
                Primary.Red500,
                Accent.Red200,
                TextShade.WHITE
            );

            // pass the value to the update form
            formId = id;
            formUserName = userName;
            formUserType = userType;
            formStore = store;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            labelUserId.Text = formId.ToString();
            userNameTbox.Text = formUserName;
            userTypeCbox.SelectedItem = formUserType;

            if (formStore == "PLAZA MARCELA")
            {
                // Replace with the items you want to remove in combobox
                string[] itemsToRemove = new string[] { "System User" };
                foreach (string item in itemsToRemove)
                {
                    if (userTypeCbox.Items.Contains(item))
                    {
                        userTypeCbox.Items.Remove(item);
                    }
                }
            }
            else if (formStore == "ALTA CITTA")
            {
                // Replace with the items you want to remove in combobox
                string[] itemsToRemove = new string[] { "Parking Attendant" };
                foreach (string item in itemsToRemove)
                {
                    if (userTypeCbox.Items.Contains(item))
                    {
                        userTypeCbox.Items.Remove(item);
                    }
                }
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (formStore == "PLAZA MARCELA")
                {
                    formId = Convert.ToInt32(labelUserId.Text);
                    formUserName = userNameTbox.Text;
                    formUserType = userTypeCbox.SelectedItem.ToString();
                    formPass = passwordTbox.Text;

                    if (!string.IsNullOrEmpty(formUserName) && !string.IsNullOrEmpty(formPass))
                    {
                        var database = new Database();
                        try
                        {
                            if (database.marcelaDb())
                            {
                                string query = "UPDATE tbl_user SET username=@username, password=MD5(@password), usertype=@usertype WHERE user_id=@id";
                                MySqlCommand cmd = new MySqlCommand(query, database.marcelaMySqlConnection);
                                cmd.Parameters.AddWithValue("@id", formId);
                                cmd.Parameters.AddWithValue("@username", formUserName);
                                cmd.Parameters.AddWithValue("@password", formPass);
                                cmd.Parameters.AddWithValue("@usertype", formUserType);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("UPDATED");
                                    dashboard.loadUserMarcela();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Failed to establish a database connection.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            database.closeMarcelaDb();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username and Password must not be empty.");
                    }
                }
                else if (formStore == "ALTA CITTA")
                {
                    if (confirm == DialogResult.Yes)
                    {
                        formId = Convert.ToInt32(labelUserId.Text);
                        formUserName = userNameTbox.Text;
                        formUserType = userTypeCbox.SelectedItem.ToString();
                        formPass = passwordTbox.Text;

                        if (!string.IsNullOrEmpty(formUserName) && !string.IsNullOrEmpty(formPass))
                        {
                            var database = new Database();
                            try
                            {
                                if (database.altaCittaDb())
                                {
                                    string query = "UPDATE tbl_user SET username=@username, password=MD5(@password), usertype=@usertype WHERE user_id=@id";
                                    MySqlCommand cmd = new MySqlCommand(query, database.altaCittaMySqlConnection);
                                    cmd.Parameters.AddWithValue("@id", formId);
                                    cmd.Parameters.AddWithValue("@username", formUserName);
                                    cmd.Parameters.AddWithValue("@password", formPass);
                                    cmd.Parameters.AddWithValue("@usertype", formUserType);
                                    int result = cmd.ExecuteNonQuery();
                                    if (result > 0)
                                    {
                                        MessageBox.Show("UPDATED");
                                        dashboard.loadUserAltaCitta();
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Failed to establish a database connection.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                database.closeAltaCittaDb();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username and Password must not be empty.");
                        }
                    }
                }
            }
        }
    }
}
