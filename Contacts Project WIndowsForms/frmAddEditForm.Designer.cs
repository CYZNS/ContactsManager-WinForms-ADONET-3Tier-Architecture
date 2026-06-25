namespace Contacts_Project_WIndowsForms
{
    partial class frmAddEditForm
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
            this.lbContactId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtmDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lkSetImage = new System.Windows.Forms.LinkLabel();
            this.lkRemove = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContactId
            // 
            this.lbContactId.AutoSize = false;
            this.lbContactId.BackColor = System.Drawing.Color.Transparent;
            this.lbContactId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactId.Location = new System.Drawing.Point(25, 79);
            this.lbContactId.Name = "lbContactId";
            this.lbContactId.Size = new System.Drawing.Size(128, 33);
            this.lbContactId.TabIndex = 0;
            this.lbContactId.Text = "ID:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(25, 184);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(128, 33);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "FirstName";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(25, 354);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(164, 33);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "DateOfBirth";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(401, 269);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(88, 33);
            this.guna2HtmlLabel4.TabIndex = 3;
            this.guna2HtmlLabel4.Text = "Phone";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(25, 269);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(88, 33);
            this.guna2HtmlLabel5.TabIndex = 4;
            this.guna2HtmlLabel5.Text = "Email";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(401, 184);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(128, 33);
            this.guna2HtmlLabel6.TabIndex = 5;
            this.guna2HtmlLabel6.Text = "LastName";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(25, 443);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(109, 33);
            this.guna2HtmlLabel7.TabIndex = 6;
            this.guna2HtmlLabel7.Text = "Address";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(401, 354);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(110, 33);
            this.guna2HtmlLabel8.TabIndex = 7;
            this.guna2HtmlLabel8.Text = "Country";
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(61, 79);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(3, 2);
            this.lbID.TabIndex = 8;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = false;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(25, 29);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(416, 56);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Add New Contact";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Animated = true;
            this.tbFirstName.BorderColor = System.Drawing.Color.Black;
            this.tbFirstName.BorderRadius = 8;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Location = new System.Drawing.Point(25, 227);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "Enter Your FirstName";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(358, 32);
            this.tbFirstName.TabIndex = 10;
            // 
            // tbLastName
            // 
            this.tbLastName.Animated = true;
            this.tbLastName.BorderColor = System.Drawing.Color.Black;
            this.tbLastName.BorderRadius = 8;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Location = new System.Drawing.Point(401, 227);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderText = "Enter Your LastName";
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(358, 32);
            this.tbLastName.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Animated = true;
            this.tbEmail.BorderColor = System.Drawing.Color.Black;
            this.tbEmail.BorderRadius = 8;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Location = new System.Drawing.Point(25, 312);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "e.g Contact@gmail.com";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(358, 32);
            this.tbEmail.TabIndex = 12;
            // 
            // tbPhone
            // 
            this.tbPhone.Animated = true;
            this.tbPhone.BorderColor = System.Drawing.Color.Black;
            this.tbPhone.BorderRadius = 8;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Location = new System.Drawing.Point(401, 312);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PlaceholderText = "+966564864178";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(358, 32);
            this.tbPhone.TabIndex = 13;
            // 
            // tbAddress
            // 
            this.tbAddress.Animated = true;
            this.tbAddress.BorderColor = System.Drawing.Color.Black;
            this.tbAddress.BorderRadius = 8;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.DefaultText = "";
            this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Location = new System.Drawing.Point(25, 486);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PlaceholderText = "e.g Alwisham District , Abad Bin Sahl Street";
            this.tbAddress.SelectedText = "";
            this.tbAddress.Size = new System.Drawing.Size(742, 81);
            this.tbAddress.TabIndex = 15;
            // 
            // cbCountries
            // 
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.BorderColor = System.Drawing.Color.Black;
            this.cbCountries.BorderRadius = 8;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.Location = new System.Drawing.Point(401, 397);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(358, 36);
            this.cbCountries.TabIndex = 16;
            // 
            // dtmDateOfBirth
            // 
            this.dtmDateOfBirth.BorderRadius = 8;
            this.dtmDateOfBirth.Checked = true;
            this.dtmDateOfBirth.FillColor = System.Drawing.Color.White;
            this.dtmDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmDateOfBirth.Location = new System.Drawing.Point(25, 397);
            this.dtmDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmDateOfBirth.Name = "dtmDateOfBirth";
            this.dtmDateOfBirth.Size = new System.Drawing.Size(358, 36);
            this.dtmDateOfBirth.TabIndex = 17;
            this.dtmDateOfBirth.Value = new System.DateTime(2026, 6, 22, 17, 37, 42, 488);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Silver;
            this.btnClose.FillColor2 = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(239, 650);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 45);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Blue;
            this.btnSave.FillColor2 = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(429, 650);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 45);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.FillColor = System.Drawing.Color.Transparent;
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(680, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox.Size = new System.Drawing.Size(159, 146);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // lkSetImage
            // 
            this.lkSetImage.AutoSize = true;
            this.lkSetImage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkSetImage.Location = new System.Drawing.Point(614, 158);
            this.lkSetImage.Name = "lkSetImage";
            this.lkSetImage.Size = new System.Drawing.Size(120, 31);
            this.lkSetImage.TabIndex = 21;
            this.lkSetImage.TabStop = true;
            this.lkSetImage.Text = "Set Image";
            this.lkSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkSetImage_LinkClicked);
            // 
            // lkRemove
            // 
            this.lkRemove.AutoSize = true;
            this.lkRemove.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkRemove.Location = new System.Drawing.Point(740, 158);
            this.lkRemove.Name = "lkRemove";
            this.lkRemove.Size = new System.Drawing.Size(99, 31);
            this.lkRemove.TabIndex = 22;
            this.lkRemove.TabStop = true;
            this.lkRemove.Text = "Remove";
            this.lkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkRemove_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(889, 718);
            this.Controls.Add(this.lkRemove);
            this.Controls.Add(this.lkSetImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtmDateOfBirth);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbContactId);
            this.Name = "frmAddEditForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmAddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbContactId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private Guna.UI2.WinForms.Guna2TextBox tbAddress;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmDateOfBirth;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox;
        private System.Windows.Forms.LinkLabel lkSetImage;
        private System.Windows.Forms.LinkLabel lkRemove;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}