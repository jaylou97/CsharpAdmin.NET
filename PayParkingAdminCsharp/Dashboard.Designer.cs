namespace PayParkingAdminCsharp
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            storeTabControl = new MaterialSkin.Controls.MaterialTabControl();
            Marcela = new TabPage();
            marcelaUser = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            userType = new DataGridViewTextBoxColumn();
            EDIT = new DataGridViewButtonColumn();
            DELETE = new DataGridViewButtonColumn();
            AltaCitta = new TabPage();
            altaCittaUser = new DataGridView();
            icon = new ImageList(components);
            altaID = new DataGridViewTextBoxColumn();
            altaUserName = new DataGridViewTextBoxColumn();
            altaUserType = new DataGridViewTextBoxColumn();
            altaEditBtn = new DataGridViewButtonColumn();
            altaDeleteBtn = new DataGridViewButtonColumn();
            storeTabControl.SuspendLayout();
            Marcela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)marcelaUser).BeginInit();
            AltaCitta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)altaCittaUser).BeginInit();
            SuspendLayout();
            // 
            // storeTabControl
            // 
            storeTabControl.Controls.Add(Marcela);
            storeTabControl.Controls.Add(AltaCitta);
            storeTabControl.Depth = 0;
            storeTabControl.Dock = DockStyle.Fill;
            storeTabControl.ImageList = icon;
            storeTabControl.Location = new Point(3, 64);
            storeTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            storeTabControl.Multiline = true;
            storeTabControl.Name = "storeTabControl";
            storeTabControl.SelectedIndex = 0;
            storeTabControl.Size = new Size(726, 383);
            storeTabControl.TabIndex = 0;
            // 
            // Marcela
            // 
            Marcela.BackColor = Color.White;
            Marcela.Controls.Add(marcelaUser);
            Marcela.ImageKey = "home.png";
            Marcela.Location = new Point(4, 24);
            Marcela.Name = "Marcela";
            Marcela.Padding = new Padding(3);
            Marcela.Size = new Size(718, 355);
            Marcela.TabIndex = 0;
            Marcela.Text = "Marcela";
            // 
            // marcelaUser
            // 
            marcelaUser.AllowUserToAddRows = false;
            marcelaUser.AllowUserToDeleteRows = false;
            marcelaUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            marcelaUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            marcelaUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            marcelaUser.Columns.AddRange(new DataGridViewColumn[] { id, userName, userType, EDIT, DELETE });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            marcelaUser.DefaultCellStyle = dataGridViewCellStyle4;
            marcelaUser.Location = new Point(6, 27);
            marcelaUser.Name = "marcelaUser";
            marcelaUser.ReadOnly = true;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            marcelaUser.RowsDefaultCellStyle = dataGridViewCellStyle5;
            marcelaUser.RowTemplate.Height = 25;
            marcelaUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            marcelaUser.Size = new Size(706, 322);
            marcelaUser.TabIndex = 0;
            marcelaUser.CellContentClick += marcelaUser_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "user_id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // userName
            // 
            userName.DataPropertyName = "username";
            userName.HeaderText = "USER NAME";
            userName.Name = "userName";
            userName.ReadOnly = true;
            userName.Resizable = DataGridViewTriState.False;
            userName.Width = 200;
            // 
            // userType
            // 
            userType.DataPropertyName = "usertype";
            userType.HeaderText = "USER TYPE";
            userType.Name = "userType";
            userType.ReadOnly = true;
            userType.Resizable = DataGridViewTriState.False;
            userType.Width = 200;
            // 
            // EDIT
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Lime;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            EDIT.DefaultCellStyle = dataGridViewCellStyle2;
            EDIT.HeaderText = "EDIT";
            EDIT.Name = "EDIT";
            EDIT.ReadOnly = true;
            EDIT.Resizable = DataGridViewTriState.False;
            EDIT.SortMode = DataGridViewColumnSortMode.Automatic;
            EDIT.Text = "EDIT";
            EDIT.UseColumnTextForButtonValue = true;
            // 
            // DELETE
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Red;
            dataGridViewCellStyle3.ForeColor = Color.Lime;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = Color.Lime;
            DELETE.DefaultCellStyle = dataGridViewCellStyle3;
            DELETE.HeaderText = "DELETE";
            DELETE.Name = "DELETE";
            DELETE.ReadOnly = true;
            DELETE.Resizable = DataGridViewTriState.False;
            DELETE.Text = "DELETE";
            DELETE.UseColumnTextForButtonValue = true;
            // 
            // AltaCitta
            // 
            AltaCitta.BackColor = Color.White;
            AltaCitta.Controls.Add(altaCittaUser);
            AltaCitta.ImageKey = "home3.png";
            AltaCitta.Location = new Point(4, 24);
            AltaCitta.Name = "AltaCitta";
            AltaCitta.Padding = new Padding(3);
            AltaCitta.Size = new Size(718, 355);
            AltaCitta.TabIndex = 1;
            AltaCitta.Text = "Alta Citta";
            // 
            // altaCittaUser
            // 
            altaCittaUser.AllowUserToAddRows = false;
            altaCittaUser.AllowUserToDeleteRows = false;
            altaCittaUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            altaCittaUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            altaCittaUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            altaCittaUser.Columns.AddRange(new DataGridViewColumn[] { altaID, altaUserName, altaUserType, altaEditBtn, altaDeleteBtn });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            altaCittaUser.DefaultCellStyle = dataGridViewCellStyle9;
            altaCittaUser.Location = new Point(6, 27);
            altaCittaUser.Name = "altaCittaUser";
            altaCittaUser.ReadOnly = true;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            altaCittaUser.RowsDefaultCellStyle = dataGridViewCellStyle10;
            altaCittaUser.RowTemplate.Height = 25;
            altaCittaUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            altaCittaUser.Size = new Size(706, 322);
            altaCittaUser.TabIndex = 1;
            altaCittaUser.CellContentClick += altaCittaUser_CellContentClick;
            // 
            // icon
            // 
            icon.ColorDepth = ColorDepth.Depth8Bit;
            icon.ImageStream = (ImageListStreamer)resources.GetObject("icon.ImageStream");
            icon.TransparentColor = Color.Black;
            icon.Images.SetKeyName(0, "home.png");
            icon.Images.SetKeyName(1, "settings.png");
            icon.Images.SetKeyName(2, "home2.png");
            icon.Images.SetKeyName(3, "home3.png");
            // 
            // altaID
            // 
            altaID.DataPropertyName = "user_id";
            altaID.HeaderText = "id";
            altaID.Name = "altaID";
            altaID.ReadOnly = true;
            altaID.Visible = false;
            // 
            // altaUserName
            // 
            altaUserName.DataPropertyName = "username";
            altaUserName.HeaderText = "USER NAME";
            altaUserName.Name = "altaUserName";
            altaUserName.ReadOnly = true;
            altaUserName.Resizable = DataGridViewTriState.False;
            altaUserName.Width = 200;
            // 
            // altaUserType
            // 
            altaUserType.DataPropertyName = "usertype";
            altaUserType.HeaderText = "USER TYPE";
            altaUserType.Name = "altaUserType";
            altaUserType.ReadOnly = true;
            altaUserType.Resizable = DataGridViewTriState.False;
            altaUserType.Width = 200;
            // 
            // altaEditBtn
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Lime;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = Color.Lime;
            dataGridViewCellStyle7.SelectionForeColor = Color.Red;
            altaEditBtn.DefaultCellStyle = dataGridViewCellStyle7;
            altaEditBtn.HeaderText = "EDIT";
            altaEditBtn.Name = "altaEditBtn";
            altaEditBtn.ReadOnly = true;
            altaEditBtn.Resizable = DataGridViewTriState.False;
            altaEditBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            altaEditBtn.Text = "EDIT";
            altaEditBtn.UseColumnTextForButtonValue = true;
            // 
            // altaDeleteBtn
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.Red;
            dataGridViewCellStyle8.ForeColor = Color.Lime;
            dataGridViewCellStyle8.SelectionBackColor = Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = Color.Lime;
            altaDeleteBtn.DefaultCellStyle = dataGridViewCellStyle8;
            altaDeleteBtn.HeaderText = "DELETE";
            altaDeleteBtn.Name = "altaDeleteBtn";
            altaDeleteBtn.ReadOnly = true;
            altaDeleteBtn.Resizable = DataGridViewTriState.False;
            altaDeleteBtn.Text = "DELETE";
            altaDeleteBtn.UseColumnTextForButtonValue = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 450);
            Controls.Add(storeTabControl);
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = storeTabControl;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            storeTabControl.ResumeLayout(false);
            Marcela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)marcelaUser).EndInit();
            AltaCitta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)altaCittaUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl storeTabControl;
        private TabPage Marcela;
        private TabPage AltaCitta;
        private ImageList icon;
        private DataGridView marcelaUser;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn userType;
        private DataGridViewButtonColumn EDIT;
        private DataGridViewButtonColumn DELETE;
        private DataGridView altaCittaUser;
        private DataGridViewTextBoxColumn altaID;
        private DataGridViewTextBoxColumn altaUserName;
        private DataGridViewTextBoxColumn altaUserType;
        private DataGridViewButtonColumn altaEditBtn;
        private DataGridViewButtonColumn altaDeleteBtn;
    }
}