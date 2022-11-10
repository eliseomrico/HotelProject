using System.Windows.Forms;

namespace HotelApp_v1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NavPanel = new System.Windows.Forms.Panel();
            this.button_home_page_login = new System.Windows.Forms.Button();
            this.button_home_page_log_out = new System.Windows.Forms.Button();
            this.spacerPanel2 = new System.Windows.Forms.Panel();
            this.button_home_page_employees = new System.Windows.Forms.Button();
            this.button_home_page_locations = new System.Windows.Forms.Button();
            this.button_home_page_check_out = new System.Windows.Forms.Button();
            this.button_home_page_checkin = new System.Windows.Forms.Button();
            this.button_home_page_cust_search = new System.Windows.Forms.Button();
            this.button_home_page_room_avail = new System.Windows.Forms.Button();
            this.button_home_page_search_res = new System.Windows.Forms.Button();
            this.spacerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewReservations1 = new HotelApp_v1.ViewReservations();
            this.roomAvailability1 = new HotelApp_v1.RoomAvailability();
            this.viewCustomers1 = new HotelApp_v1.ViewCustomers();
            this.checkInForm1 = new HotelApp_v1.CheckInForm();
            this.checkOutForm1 = new HotelApp_v1.CheckOutForm();
            this.viewLocations1 = new HotelApp_v1.ViewLocations();
            this.employees1 = new HotelApp_v1.Employees();
            this.employeeLoginForm1 = new HotelApp_v1.EmployeeLoginForm();
            this.NavPanel.SuspendLayout();
            this.spacerPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.NavPanel.Controls.Add(this.button_home_page_login);
            this.NavPanel.Controls.Add(this.button_home_page_log_out);
            this.NavPanel.Controls.Add(this.spacerPanel2);
            this.NavPanel.Controls.Add(this.button_home_page_check_out);
            this.NavPanel.Controls.Add(this.button_home_page_checkin);
            this.NavPanel.Controls.Add(this.button_home_page_cust_search);
            this.NavPanel.Controls.Add(this.button_home_page_room_avail);
            this.NavPanel.Controls.Add(this.button_home_page_search_res);
            this.NavPanel.Controls.Add(this.spacerPanel);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(2);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(250, 545);
            this.NavPanel.TabIndex = 0;
            // 
            // button_home_page_login
            // 
            this.button_home_page_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_login.FlatAppearance.BorderSize = 0;
            this.button_home_page_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home_page_login.ForeColor = System.Drawing.Color.White;
            this.button_home_page_login.Location = new System.Drawing.Point(0, 485);
            this.button_home_page_login.Name = "button_home_page_login";
            this.button_home_page_login.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_login.TabIndex = 20;
            this.button_home_page_login.Text = "Log in";
            this.button_home_page_login.UseVisualStyleBackColor = false;
            this.button_home_page_login.Click += new System.EventHandler(this.button_home_page_login_Click);
            // 
            // button_home_page_log_out
            // 
            this.button_home_page_log_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_log_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_log_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_log_out.FlatAppearance.BorderSize = 0;
            this.button_home_page_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_log_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_log_out.ForeColor = System.Drawing.Color.White;
            this.button_home_page_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_log_out.Location = new System.Drawing.Point(0, 485);
            this.button_home_page_log_out.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_log_out.Name = "button_home_page_log_out";
            this.button_home_page_log_out.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_log_out.TabIndex = 7;
            this.button_home_page_log_out.Text = "Logout";
            this.button_home_page_log_out.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_log_out.UseVisualStyleBackColor = false;
            this.button_home_page_log_out.Click += new System.EventHandler(this.button_home_page_log_out_Click);
            // 
            // spacerPanel2
            // 
            this.spacerPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.spacerPanel2.Controls.Add(this.button_home_page_employees);
            this.spacerPanel2.Controls.Add(this.button_home_page_locations);
            this.spacerPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerPanel2.Location = new System.Drawing.Point(0, 360);
            this.spacerPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.spacerPanel2.Name = "spacerPanel2";
            this.spacerPanel2.Size = new System.Drawing.Size(250, 125);
            this.spacerPanel2.TabIndex = 6;
            // 
            // button_home_page_employees
            // 
            this.button_home_page_employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_employees.FlatAppearance.BorderSize = 0;
            this.button_home_page_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_employees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home_page_employees.ForeColor = System.Drawing.Color.White;
            this.button_home_page_employees.Location = new System.Drawing.Point(0, 65);
            this.button_home_page_employees.Name = "button_home_page_employees";
            this.button_home_page_employees.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_employees.TabIndex = 22;
            this.button_home_page_employees.Text = "Employees";
            this.button_home_page_employees.UseVisualStyleBackColor = false;
            this.button_home_page_employees.Click += new System.EventHandler(this.button_home_page_employees_Click);
            // 
            // button_home_page_locations
            // 
            this.button_home_page_locations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_locations.FlatAppearance.BorderSize = 0;
            this.button_home_page_locations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_locations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home_page_locations.ForeColor = System.Drawing.Color.White;
            this.button_home_page_locations.Location = new System.Drawing.Point(0, 0);
            this.button_home_page_locations.Name = "button_home_page_locations";
            this.button_home_page_locations.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_locations.TabIndex = 21;
            this.button_home_page_locations.Text = "Locations";
            this.button_home_page_locations.UseVisualStyleBackColor = false;
            this.button_home_page_locations.Click += new System.EventHandler(this.button_home_page_locations_Click);
            // 
            // button_home_page_check_out
            // 
            this.button_home_page_check_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_check_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_check_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_check_out.FlatAppearance.BorderSize = 0;
            this.button_home_page_check_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_check_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_check_out.ForeColor = System.Drawing.Color.White;
            this.button_home_page_check_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_check_out.Location = new System.Drawing.Point(0, 300);
            this.button_home_page_check_out.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_check_out.Name = "button_home_page_check_out";
            this.button_home_page_check_out.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_check_out.TabIndex = 5;
            this.button_home_page_check_out.Text = "Check-Out";
            this.button_home_page_check_out.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_check_out.UseVisualStyleBackColor = false;
            this.button_home_page_check_out.Click += new System.EventHandler(this.button_home_page_check_out_Click);
            // 
            // button_home_page_checkin
            // 
            this.button_home_page_checkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_checkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_checkin.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_checkin.FlatAppearance.BorderSize = 0;
            this.button_home_page_checkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_checkin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_checkin.ForeColor = System.Drawing.Color.White;
            this.button_home_page_checkin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_checkin.Location = new System.Drawing.Point(0, 240);
            this.button_home_page_checkin.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_checkin.Name = "button_home_page_checkin";
            this.button_home_page_checkin.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_checkin.TabIndex = 4;
            this.button_home_page_checkin.Text = "Check-In";
            this.button_home_page_checkin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_checkin.UseVisualStyleBackColor = false;
            this.button_home_page_checkin.Click += new System.EventHandler(this.button_home_page_checkin_Click);
            // 
            // button_home_page_cust_search
            // 
            this.button_home_page_cust_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_cust_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_cust_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_cust_search.FlatAppearance.BorderSize = 0;
            this.button_home_page_cust_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_cust_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_cust_search.ForeColor = System.Drawing.Color.White;
            this.button_home_page_cust_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_cust_search.Location = new System.Drawing.Point(0, 180);
            this.button_home_page_cust_search.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_cust_search.Name = "button_home_page_cust_search";
            this.button_home_page_cust_search.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_cust_search.TabIndex = 3;
            this.button_home_page_cust_search.Text = "Customer Search";
            this.button_home_page_cust_search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_cust_search.UseVisualStyleBackColor = false;
            this.button_home_page_cust_search.Click += new System.EventHandler(this.button_home_page_cust_search_Click);
            // 
            // button_home_page_room_avail
            // 
            this.button_home_page_room_avail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_room_avail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_room_avail.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_room_avail.FlatAppearance.BorderSize = 0;
            this.button_home_page_room_avail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_room_avail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_room_avail.ForeColor = System.Drawing.Color.White;
            this.button_home_page_room_avail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_room_avail.Location = new System.Drawing.Point(0, 120);
            this.button_home_page_room_avail.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_room_avail.Name = "button_home_page_room_avail";
            this.button_home_page_room_avail.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_room_avail.TabIndex = 2;
            this.button_home_page_room_avail.Text = "Room Availability";
            this.button_home_page_room_avail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_room_avail.UseVisualStyleBackColor = false;
            this.button_home_page_room_avail.Click += new System.EventHandler(this.button_home_page_room_avail_Click);
            // 
            // button_home_page_search_res
            // 
            this.button_home_page_search_res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home_page_search_res.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_search_res.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_search_res.FlatAppearance.BorderSize = 0;
            this.button_home_page_search_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_search_res.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_search_res.ForeColor = System.Drawing.Color.White;
            this.button_home_page_search_res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_search_res.Location = new System.Drawing.Point(0, 60);
            this.button_home_page_search_res.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_search_res.Name = "button_home_page_search_res";
            this.button_home_page_search_res.Size = new System.Drawing.Size(250, 60);
            this.button_home_page_search_res.TabIndex = 1;
            this.button_home_page_search_res.Text = "Reservation Search";
            this.button_home_page_search_res.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_search_res.UseVisualStyleBackColor = false;
            this.button_home_page_search_res.Click += new System.EventHandler(this.button_home_page_search_res_Click);
            // 
            // spacerPanel
            // 
            this.spacerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.spacerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerPanel.Location = new System.Drawing.Point(0, 0);
            this.spacerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.spacerPanel.Name = "spacerPanel";
            this.spacerPanel.Size = new System.Drawing.Size(250, 60);
            this.spacerPanel.TabIndex = 0;
            this.spacerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spacerPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // viewReservations1
            // 
            this.viewReservations1.Location = new System.Drawing.Point(250, 0);
            this.viewReservations1.Name = "viewReservations1";
            this.viewReservations1.Size = new System.Drawing.Size(692, 545);
            this.viewReservations1.TabIndex = 2;
            this.viewReservations1.Visible = false;
            // 
            // roomAvailability1
            // 
            this.roomAvailability1.Location = new System.Drawing.Point(250, 0);
            this.roomAvailability1.Name = "roomAvailability1";
            this.roomAvailability1.Size = new System.Drawing.Size(692, 545);
            this.roomAvailability1.TabIndex = 3;
            this.roomAvailability1.Visible = false;
            // 
            // viewCustomers1
            // 
            this.viewCustomers1.Location = new System.Drawing.Point(250, 0);
            this.viewCustomers1.Name = "viewCustomers1";
            this.viewCustomers1.Size = new System.Drawing.Size(692, 545);
            this.viewCustomers1.TabIndex = 4;
            this.viewCustomers1.Visible = false;
            // 
            // checkInForm1
            // 
            this.checkInForm1.Location = new System.Drawing.Point(250, 0);
            this.checkInForm1.Name = "checkInForm1";
            this.checkInForm1.Size = new System.Drawing.Size(692, 545);
            this.checkInForm1.TabIndex = 5;
            this.checkInForm1.Visible = false;
            // 
            // checkOutForm1
            // 
            this.checkOutForm1.Location = new System.Drawing.Point(250, 0);
            this.checkOutForm1.Name = "checkOutForm1";
            this.checkOutForm1.Size = new System.Drawing.Size(692, 545);
            this.checkOutForm1.TabIndex = 6;
            this.checkOutForm1.Visible = false;
            // 
            // viewLocations1
            // 
            this.viewLocations1.Location = new System.Drawing.Point(250, 0);
            this.viewLocations1.Name = "viewLocations1";
            this.viewLocations1.Size = new System.Drawing.Size(692, 545);
            this.viewLocations1.TabIndex = 7;
            this.viewLocations1.Visible = false;
            // 
            // employees1
            // 
            this.employees1.Location = new System.Drawing.Point(250, 0);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(692, 545);
            this.employees1.TabIndex = 8;
            this.employees1.Visible = false;
            // 
            // employeeLoginForm1
            // 
            this.employeeLoginForm1.Location = new System.Drawing.Point(250, 0);
            this.employeeLoginForm1.Name = "employeeLoginForm1";
            this.employeeLoginForm1.Size = new System.Drawing.Size(692, 545);
            this.employeeLoginForm1.TabIndex = 9;
            this.employeeLoginForm1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 545);
            this.Controls.Add(this.employeeLoginForm1);
            this.Controls.Add(this.employees1);
            this.Controls.Add(this.viewLocations1);
            this.Controls.Add(this.checkOutForm1);
            this.Controls.Add(this.checkInForm1);
            this.Controls.Add(this.viewCustomers1);
            this.Controls.Add(this.roomAvailability1);
            this.Controls.Add(this.viewReservations1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NavPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavPanel.ResumeLayout(false);
            this.spacerPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel NavPanel;
        private Panel spacerPanel;
        private Button button_home_page_check_out;
        private Button button_home_page_checkin;
        private Button button_home_page_cust_search;
        private Button button_home_page_room_avail;
        private Button button_home_page_search_res;
        private Button button_home_page_log_out;
        private Panel spacerPanel2;
        private PictureBox pictureBox1;
        private Button button_home_page_login;
        private Button button_home_page_employees;
        private Button button_home_page_locations;
        private ViewReservations viewReservations1;
        private RoomAvailability roomAvailability1;
        private ViewCustomers viewCustomers1;
        private CheckInForm checkInForm1;
        private CheckOutForm checkOutForm1;
        private ViewLocations viewLocations1;
        private Employees employees1;
        private EmployeeLoginForm employeeLoginForm1;
    }
}