
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System.Data;

namespace PayParkingAdminCsharp
{
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
        {
            InitializeComponent();
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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadUserMarcela();
            loadUserAltaCitta();
        }
        public void loadUserMarcela()
        {
            var database = new Database();
            if (database.marcelaDb())
            {
                string query = "SELECT user_id, username, usertype FROM tbl_user";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.marcelaMySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                marcelaUser.DataSource = bindingSource;
                database.closeMarcelaDb();
            }
            else
            {
                MessageBox.Show("Database Error!");
            }
        }
        private void marcelaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (marcelaUser.Columns[e.ColumnIndex].Name == "EDIT")
                {
                    int id;
                    string? userName, userType, store;
                    store = "PLAZA MARCELA";
                    id = Convert.ToInt32(marcelaUser.Rows[e.RowIndex].Cells["id"].Value);
                    userName = Convert.ToString(marcelaUser.Rows[e.RowIndex].Cells["userName"].Value);
                    userType = Convert.ToString(marcelaUser.Rows[e.RowIndex].Cells["userType"].Value);

                    UpdateForm updateForm = new UpdateForm(this, id, userName, userType, store);
                    updateForm.ShowDialog();
                }
                else if (marcelaUser.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        int id;
                        id = Convert.ToInt32(marcelaUser.Rows[e.RowIndex].Cells["id"].Value);

                        var database = new Database();
                        try
                        {
                            if (database.marcelaDb()) // Open the database connection
                            {
                                string query = "DELETE FROM tbl_user WHERE user_id=@id";
                                MySqlCommand mySqlCommand = new MySqlCommand(query, database.marcelaMySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@id", id);
                                int result = mySqlCommand.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("DELETED!");
                                    loadUserMarcela();
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
                            database.closeMarcelaDb(); // Close the database connection in the finally block
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadUserAltaCitta()
        {
            var database = new Database();
            if (database.altaCittaDb())
            {
                string query = "SELECT user_id, username, usertype FROM tbl_user";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.altaCittaMySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                altaCittaUser.DataSource = bindingSource;
                database.closeAltaCittaDb();
            }
            else
            {
                MessageBox.Show("Database Error!");
            }
        }
        private void altaCittaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (altaCittaUser.Columns[e.ColumnIndex].Name == "altaEditBtn")
                {
                    int id;
                    string? userName, userType, store;
                    store = "ALTA CITTA"; 
                    id = Convert.ToInt32(altaCittaUser.Rows[e.RowIndex].Cells["altaID"].Value);
                    userName = Convert.ToString(altaCittaUser.Rows[e.RowIndex].Cells["altaUserName"].Value);
                    userType = Convert.ToString(altaCittaUser.Rows[e.RowIndex].Cells["altaUserType"].Value);

                    UpdateForm updateForm = new UpdateForm(this, id, userName, userType, store);
                    updateForm.ShowDialog();
                }
                else if (altaCittaUser.Columns[e.ColumnIndex].Name == "altaDeleteBtn")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        int id;
                        id = Convert.ToInt32(altaCittaUser.Rows[e.RowIndex].Cells["altaID"].Value);

                        var database = new Database();
                        try
                        {
                            if (database.altaCittaDb()) // Open the database connection
                            {
                                string query = "DELETE FROM tbl_user WHERE user_id=@id";
                                MySqlCommand mySqlCommand = new MySqlCommand(query, database.altaCittaMySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@id", id);
                                int result = mySqlCommand.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("DELETED!");
                                    loadUserAltaCitta();
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
                            database.closeAltaCittaDb(); // Close the database connection in the finally block
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}