namespace Video_Store
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.tabPageRentals = new System.Windows.Forms.TabPage();
            this.dataGridViewRentals = new System.Windows.Forms.DataGridView();
            this.DeleteCustbtn = new System.Windows.Forms.Button();
            this.AddCustbtn = new System.Windows.Forms.Button();
            this.AddMoviebtn = new System.Windows.Forms.Button();
            this.DeleteMoviebtn = new System.Windows.Forms.Button();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxRentalCost = new System.Windows.Forms.TextBox();
            this.textBoxReleaseDate = new System.Windows.Forms.TextBox();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.tabPageMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.tabPageRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCustomers);
            this.tabControl1.Controls.Add(this.tabPageMovies);
            this.tabControl1.Controls.Add(this.tabPageRentals);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 337);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.dataGridViewDatabase);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(1019, 308);
            this.tabPageCustomers.TabIndex = 0;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            this.tabPageCustomers.Click += new System.EventHandler(this.tabPageCustomers_Click);
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.AllowUserToOrderColumns = true;
            this.dataGridViewDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatabase.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewDatabase.Location = new System.Drawing.Point(-6, 0);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.ReadOnly = true;
            this.dataGridViewDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDatabase.Size = new System.Drawing.Size(1025, 308);
            this.dataGridViewDatabase.TabIndex = 0;
            this.dataGridViewDatabase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            this.dataGridViewDatabase.DoubleClick += new System.EventHandler(this.dataGridViewDatabase_DoubleClick);
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.Controls.Add(this.dataGridViewMovies);
            this.tabPageMovies.Location = new System.Drawing.Point(4, 25);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(1019, 308);
            this.tabPageMovies.TabIndex = 1;
            this.tabPageMovies.Text = "Movies";
            this.tabPageMovies.UseVisualStyleBackColor = true;
            this.tabPageMovies.Click += new System.EventHandler(this.tabPageMovies_Click);
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowUserToOrderColumns = true;
            this.dataGridViewMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMovies.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovies.Size = new System.Drawing.Size(1023, 315);
            this.dataGridViewMovies.TabIndex = 1;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellContentClick);
            this.dataGridViewMovies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellDoubleClick);
            // 
            // tabPageRentals
            // 
            this.tabPageRentals.Controls.Add(this.dataGridViewRentals);
            this.tabPageRentals.Location = new System.Drawing.Point(4, 25);
            this.tabPageRentals.Name = "tabPageRentals";
            this.tabPageRentals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRentals.Size = new System.Drawing.Size(1019, 308);
            this.tabPageRentals.TabIndex = 2;
            this.tabPageRentals.Text = "Rentals";
            this.tabPageRentals.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRentals
            // 
            this.dataGridViewRentals.AllowUserToOrderColumns = true;
            this.dataGridViewRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRentals.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentals.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRentals.Name = "dataGridViewRentals";
            this.dataGridViewRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRentals.Size = new System.Drawing.Size(1023, 312);
            this.dataGridViewRentals.TabIndex = 1;
            this.dataGridViewRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRentals_CellContentClick);
            this.dataGridViewRentals.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRentals_CellDoubleClick);
            // 
            // DeleteCustbtn
            // 
            this.DeleteCustbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteCustbtn.ForeColor = System.Drawing.Color.White;
            this.DeleteCustbtn.Location = new System.Drawing.Point(226, 464);
            this.DeleteCustbtn.Name = "DeleteCustbtn";
            this.DeleteCustbtn.Size = new System.Drawing.Size(103, 23);
            this.DeleteCustbtn.TabIndex = 2;
            this.DeleteCustbtn.Text = "Delete Customer !";
            this.DeleteCustbtn.UseVisualStyleBackColor = false;
            this.DeleteCustbtn.Click += new System.EventHandler(this.DeleteCustbtn_Click);
            // 
            // AddCustbtn
            // 
            this.AddCustbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddCustbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustbtn.ForeColor = System.Drawing.Color.White;
            this.AddCustbtn.Location = new System.Drawing.Point(580, 366);
            this.AddCustbtn.Name = "AddCustbtn";
            this.AddCustbtn.Size = new System.Drawing.Size(100, 41);
            this.AddCustbtn.TabIndex = 3;
            this.AddCustbtn.Text = "Add Customer";
            this.AddCustbtn.UseVisualStyleBackColor = false;
            this.AddCustbtn.Click += new System.EventHandler(this.AddCustbtn_Click);
            // 
            // AddMoviebtn
            // 
            this.AddMoviebtn.BackColor = System.Drawing.Color.Black;
            this.AddMoviebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMoviebtn.ForeColor = System.Drawing.Color.White;
            this.AddMoviebtn.Location = new System.Drawing.Point(686, 409);
            this.AddMoviebtn.Name = "AddMoviebtn";
            this.AddMoviebtn.Size = new System.Drawing.Size(89, 49);
            this.AddMoviebtn.TabIndex = 4;
            this.AddMoviebtn.Text = "Add Movie";
            this.AddMoviebtn.UseVisualStyleBackColor = false;
            this.AddMoviebtn.Click += new System.EventHandler(this.AddMoviebtn_Click);
            // 
            // DeleteMoviebtn
            // 
            this.DeleteMoviebtn.BackColor = System.Drawing.Color.Black;
            this.DeleteMoviebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteMoviebtn.Location = new System.Drawing.Point(345, 464);
            this.DeleteMoviebtn.Name = "DeleteMoviebtn";
            this.DeleteMoviebtn.Size = new System.Drawing.Size(93, 23);
            this.DeleteMoviebtn.TabIndex = 5;
            this.DeleteMoviebtn.Text = "Delete Movie !";
            this.DeleteMoviebtn.UseVisualStyleBackColor = false;
            this.DeleteMoviebtn.Click += new System.EventHandler(this.DeleteMoviebtn_Click);
            // 
            // textBoxFname
            // 
            this.textBoxFname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxFname.Location = new System.Drawing.Point(53, 386);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(96, 20);
            this.textBoxFname.TabIndex = 6;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(155, 386);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(100, 20);
            this.textBoxLname.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(261, 386);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(203, 20);
            this.textBoxAddress.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(470, 386);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(84, 20);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(53, 434);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(209, 20);
            this.textBoxTitle.TabIndex = 10;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(268, 434);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(68, 20);
            this.textBoxYear.TabIndex = 11;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(342, 434);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(75, 20);
            this.textBoxGenre.TabIndex = 12;
            // 
            // textBoxRentalCost
            // 
            this.textBoxRentalCost.Location = new System.Drawing.Point(485, 434);
            this.textBoxRentalCost.Name = "textBoxRentalCost";
            this.textBoxRentalCost.Size = new System.Drawing.Size(89, 20);
            this.textBoxRentalCost.TabIndex = 14;
            // 
            // textBoxReleaseDate
            // 
            this.textBoxReleaseDate.Location = new System.Drawing.Point(580, 434);
            this.textBoxReleaseDate.Name = "textBoxReleaseDate";
            this.textBoxReleaseDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxReleaseDate.TabIndex = 15;
            this.textBoxReleaseDate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Maroon;
            this.btnIssueMovie.Location = new System.Drawing.Point(793, 370);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(173, 32);
            this.btnIssueMovie.TabIndex = 16;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnReturnMovie.Location = new System.Drawing.Point(793, 426);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(173, 35);
            this.btnReturnMovie.TabIndex = 17;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(50, 418);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Title";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(265, 418);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 22;
            this.lblYear.Text = "Year";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGenre.Location = new System.Drawing.Point(342, 418);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 23;
            this.lblGenre.Text = "Genre";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRating.Location = new System.Drawing.Point(420, 418);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 24;
            this.lblRating.Text = "Rating";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(423, 434);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(56, 20);
            this.textBoxRating.TabIndex = 25;
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.AutoSize = true;
            this.lblRentalCost.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRentalCost.Location = new System.Drawing.Point(483, 418);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(62, 13);
            this.lblRentalCost.TabIndex = 26;
            this.lblRentalCost.Text = "Rental Cost";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReleaseDate.Location = new System.Drawing.Point(581, 418);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(70, 13);
            this.lblReleaseDate.TabIndex = 27;
            this.lblReleaseDate.Text = "Release date";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFname.Location = new System.Drawing.Point(50, 370);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 28;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLname.Location = new System.Drawing.Point(152, 370);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 29;
            this.lblLname.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Location = new System.Drawing.Point(258, 369);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhoneNumber.Location = new System.Drawing.Point(467, 369);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 31;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxCustID.Location = new System.Drawing.Point(16, 386);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(31, 20);
            this.textBoxCustID.TabIndex = 33;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustID.Location = new System.Drawing.Point(13, 366);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(18, 13);
            this.lblCustID.TabIndex = 34;
            this.lblCustID.Text = "ID";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMovieID.Location = new System.Drawing.Point(13, 418);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(18, 13);
            this.lblMovieID.TabIndex = 35;
            this.lblMovieID.Text = "ID";
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxMovieID.Location = new System.Drawing.Point(16, 434);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(31, 20);
            this.textBoxMovieID.TabIndex = 36;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(638, 3);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(237, 29);
            this.textSearch.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(881, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 29);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1051, 496);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.textBoxMovieID);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.textBoxCustID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblRentalCost);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.textBoxReleaseDate);
            this.Controls.Add(this.textBoxRentalCost);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.DeleteMoviebtn);
            this.Controls.Add(this.AddMoviebtn);
            this.Controls.Add(this.DeleteCustbtn);
            this.Controls.Add(this.AddCustbtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " NZ Video Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.tabPageMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.tabPageRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.TabPage tabPageRentals;
        private System.Windows.Forms.DataGridView dataGridViewDatabase;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.DataGridView dataGridViewRentals;
        private System.Windows.Forms.Button DeleteCustbtn;
        private System.Windows.Forms.Button AddCustbtn;
        private System.Windows.Forms.Button AddMoviebtn;
        private System.Windows.Forms.Button DeleteMoviebtn;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxRentalCost;
        private System.Windows.Forms.TextBox textBoxReleaseDate;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

