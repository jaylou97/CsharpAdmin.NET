namespace PayParkingAdminCsharp
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            updateBtn = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            userTypeCbox = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            userNameTbox = new MaterialSkin.Controls.MaterialTextBox();
            labelUserId = new MaterialSkin.Controls.MaterialLabel();
            passwordTbox = new TextBox();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateBtn.Depth = 0;
            updateBtn.HighEmphasis = true;
            updateBtn.Icon = null;
            updateBtn.Location = new Point(85, 335);
            updateBtn.Margin = new Padding(4, 6, 4, 6);
            updateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateBtn.Name = "updateBtn";
            updateBtn.NoAccentTextColor = Color.Empty;
            updateBtn.Size = new Size(77, 36);
            updateBtn.TabIndex = 0;
            updateBtn.Text = "UPDATE";
            updateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateBtn.UseAccentColor = false;
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(83, 77);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(88, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "USER NAME";
            // 
            // userTypeCbox
            // 
            userTypeCbox.AutoResize = false;
            userTypeCbox.BackColor = Color.FromArgb(255, 255, 255);
            userTypeCbox.Depth = 0;
            userTypeCbox.DrawMode = DrawMode.OwnerDrawVariable;
            userTypeCbox.DropDownHeight = 174;
            userTypeCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            userTypeCbox.DropDownWidth = 121;
            userTypeCbox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            userTypeCbox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            userTypeCbox.FormattingEnabled = true;
            userTypeCbox.IntegralHeight = false;
            userTypeCbox.ItemHeight = 43;
            userTypeCbox.Items.AddRange(new object[] { "Accounting-IAD", "Admin", "Parking Attendant", "System User", "Supervisor" });
            userTypeCbox.Location = new Point(6, 187);
            userTypeCbox.MaxDropDownItems = 4;
            userTypeCbox.MouseState = MaterialSkin.MouseState.OUT;
            userTypeCbox.Name = "userTypeCbox";
            userTypeCbox.Size = new Size(254, 49);
            userTypeCbox.StartIndex = 0;
            userTypeCbox.TabIndex = 2;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(83, 165);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(83, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "USER TYPE";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(65, 256);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(125, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "NEW PASSWORD";
            // 
            // userNameTbox
            // 
            userNameTbox.AnimateReadOnly = false;
            userNameTbox.BorderStyle = BorderStyle.None;
            userNameTbox.Depth = 0;
            userNameTbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            userNameTbox.LeadingIcon = null;
            userNameTbox.Location = new Point(6, 99);
            userNameTbox.MaxLength = 50;
            userNameTbox.MouseState = MaterialSkin.MouseState.OUT;
            userNameTbox.Multiline = false;
            userNameTbox.Name = "userNameTbox";
            userNameTbox.Size = new Size(254, 50);
            userNameTbox.TabIndex = 6;
            userNameTbox.Text = "";
            userNameTbox.TrailingIcon = null;
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Depth = 0;
            labelUserId.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelUserId.Location = new Point(6, 77);
            labelUserId.MouseState = MaterialSkin.MouseState.HOVER;
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(59, 19);
            labelUserId.TabIndex = 7;
            labelUserId.Text = "USER ID";
            labelUserId.Visible = false;
            // 
            // passwordTbox
            // 
            passwordTbox.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTbox.Location = new Point(55, 278);
            passwordTbox.MaxLength = 20;
            passwordTbox.Multiline = true;
            passwordTbox.Name = "passwordTbox";
            passwordTbox.PasswordChar = '*';
            passwordTbox.Size = new Size(144, 23);
            passwordTbox.TabIndex = 8;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 383);
            Controls.Add(passwordTbox);
            Controls.Add(labelUserId);
            Controls.Add(userNameTbox);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(userTypeCbox);
            Controls.Add(materialLabel1);
            Controls.Add(updateBtn);
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            Name = "UpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UPDATE FORM";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton updateBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox userTypeCbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox userNameTbox;
        private MaterialSkin.Controls.MaterialLabel labelUserId;
        private TextBox passwordTbox;
    }
}