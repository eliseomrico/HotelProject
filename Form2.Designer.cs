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
            this.button_home_page_log_out = new System.Windows.Forms.Button();
            this.spacerPanel2 = new System.Windows.Forms.Panel();
            this.Admin = new System.Windows.Forms.Button();
            this.button_home_page_check_out = new System.Windows.Forms.Button();
            this.button_home_page_checkin = new System.Windows.Forms.Button();
            this.button_home_page_cust_search = new System.Windows.Forms.Button();
            this.button_home_page_room_avail = new System.Windows.Forms.Button();
            this.button_home_page_search_res = new System.Windows.Forms.Button();
            this.spacerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.NavPanel.SuspendLayout();
            this.spacerPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
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
            this.NavPanel.Size = new System.Drawing.Size(188, 664);
            this.NavPanel.TabIndex = 0;
            // 
            // button_home_page_log_out
            // 
            this.button_home_page_log_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button_home_page_log_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_log_out.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_home_page_log_out.FlatAppearance.BorderSize = 0;
            this.button_home_page_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_log_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_log_out.ForeColor = System.Drawing.Color.White;
            this.button_home_page_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_log_out.Location = new System.Drawing.Point(0, 615);
            this.button_home_page_log_out.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_log_out.Name = "button_home_page_log_out";
            this.button_home_page_log_out.Size = new System.Drawing.Size(188, 49);
            this.button_home_page_log_out.TabIndex = 7;
            this.button_home_page_log_out.Text = "Logout";
            this.button_home_page_log_out.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_log_out.UseVisualStyleBackColor = false;
            this.button_home_page_log_out.Click += new System.EventHandler(this.button_home_page_log_out_Click);
            // 
            // spacerPanel2
            // 
            this.spacerPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.spacerPanel2.Controls.Add(this.Admin);
            this.spacerPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerPanel2.Location = new System.Drawing.Point(0, 295);
            this.spacerPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.spacerPanel2.Name = "spacerPanel2";
            this.spacerPanel2.Size = new System.Drawing.Size(188, 102);
            this.spacerPanel2.TabIndex = 6;
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Admin.FlatAppearance.BorderSize = 0;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin.Location = new System.Drawing.Point(0, 0);
            this.Admin.Margin = new System.Windows.Forms.Padding(2);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(188, 49);
            this.Admin.TabIndex = 6;
            this.Admin.Text = "Administrator";
            this.Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Admin.UseVisualStyleBackColor = false;
            // 
            // button_home_page_check_out
            // 
            this.button_home_page_check_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button_home_page_check_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_check_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_check_out.FlatAppearance.BorderSize = 0;
            this.button_home_page_check_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_check_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_check_out.ForeColor = System.Drawing.Color.White;
            this.button_home_page_check_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_check_out.Location = new System.Drawing.Point(0, 246);
            this.button_home_page_check_out.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_check_out.Name = "button_home_page_check_out";
            this.button_home_page_check_out.Size = new System.Drawing.Size(188, 49);
            this.button_home_page_check_out.TabIndex = 5;
            this.button_home_page_check_out.Text = "Check-Out";
            this.button_home_page_check_out.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_check_out.UseVisualStyleBackColor = false;
            this.button_home_page_check_out.Click += new System.EventHandler(this.button_home_page_check_out_Click);
            // 
            // button_home_page_checkin
            // 
            this.button_home_page_checkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button_home_page_checkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_checkin.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_checkin.FlatAppearance.BorderSize = 0;
            this.button_home_page_checkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_checkin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_checkin.ForeColor = System.Drawing.Color.White;
            this.button_home_page_checkin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_checkin.Location = new System.Drawing.Point(0, 197);
            this.button_home_page_checkin.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_checkin.Name = "button_home_page_checkin";
            this.button_home_page_checkin.Size = new System.Drawing.Size(188, 49);
            this.button_home_page_checkin.TabIndex = 4;
            this.button_home_page_checkin.Text = "Check-In";
            this.button_home_page_checkin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_checkin.UseVisualStyleBackColor = false;
            this.button_home_page_checkin.Click += new System.EventHandler(this.button_home_page_checkin_Click);
            // 
            // button_home_page_cust_search
            // 
            this.button_home_page_cust_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button_home_page_cust_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_cust_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_cust_search.FlatAppearance.BorderSize = 0;
            this.button_home_page_cust_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_cust_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_cust_search.ForeColor = System.Drawing.Color.White;
            this.button_home_page_cust_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_cust_search.Location = new System.Drawing.Point(0, 148);
            this.button_home_page_cust_search.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_cust_search.Name = "button_home_page_cust_search";
            this.button_home_page_cust_search.Size = new System.Drawing.Size(188, 49);
            this.button_home_page_cust_search.TabIndex = 3;
            this.button_home_page_cust_search.Text = "Guests";
            this.button_home_page_cust_search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_cust_search.UseVisualStyleBackColor = false;
            this.button_home_page_cust_search.Click += new System.EventHandler(this.button_home_page_cust_search_Click);
            // 
            // button_home_page_room_avail
            // 
            this.button_home_page_room_avail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button_home_page_room_avail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_room_avail.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_room_avail.FlatAppearance.BorderSize = 0;
            this.button_home_page_room_avail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_room_avail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_room_avail.ForeColor = System.Drawing.Color.White;
            this.button_home_page_room_avail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_room_avail.Location = new System.Drawing.Point(0, 99);
            this.button_home_page_room_avail.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_room_avail.Name = "button_home_page_room_avail";
            this.button_home_page_room_avail.Size = new System.Drawing.Size(188, 49);
            this.button_home_page_room_avail.TabIndex = 2;
            this.button_home_page_room_avail.Text = "Room Availability";
            this.button_home_page_room_avail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_room_avail.UseVisualStyleBackColor = false;
            this.button_home_page_room_avail.Click += new System.EventHandler(this.button_home_page_room_avail_Click);
            // 
            // button_home_page_search_res
            // 
            this.button_home_page_search_res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button_home_page_search_res.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_page_search_res.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_home_page_search_res.FlatAppearance.BorderSize = 0;
            this.button_home_page_search_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page_search_res.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home_page_search_res.ForeColor = System.Drawing.Color.White;
            this.button_home_page_search_res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home_page_search_res.Location = new System.Drawing.Point(0, 50);
            this.button_home_page_search_res.Margin = new System.Windows.Forms.Padding(2);
            this.button_home_page_search_res.Name = "button_home_page_search_res";
            this.button_home_page_search_res.Size = new System.Drawing.Size(188, 49);
            this.button_home_page_search_res.TabIndex = 1;
            this.button_home_page_search_res.Text = "Reservations";
            this.button_home_page_search_res.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_home_page_search_res.UseVisualStyleBackColor = false;
            this.button_home_page_search_res.Click += new System.EventHandler(this.button_home_page_search_res_Click);
            // 
            // spacerPanel
            // 
            this.spacerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.spacerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spacerPanel.BackgroundImage")));
            this.spacerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spacerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerPanel.Location = new System.Drawing.Point(0, 0);
            this.spacerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.spacerPanel.Name = "spacerPanel";
            this.spacerPanel.Size = new System.Drawing.Size(188, 50);
            this.spacerPanel.TabIndex = 0;
            this.spacerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spacerPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(823, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(188, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(931, 614);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 664);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavPanel.ResumeLayout(false);
            this.spacerPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button Admin;
        private Panel panelChildForm;
    }
}