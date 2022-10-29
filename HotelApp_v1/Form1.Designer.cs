namespace HotelMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NavPanel = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.spacerPanel2 = new System.Windows.Forms.Panel();
            this.chckOut = new System.Windows.Forms.Button();
            this.chckIn = new System.Windows.Forms.Button();
            this.CustSearch = new System.Windows.Forms.Button();
            this.roomAvail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.spacerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.NavPanel.Controls.Add(this.logOut);
            this.NavPanel.Controls.Add(this.spacerPanel2);
            this.NavPanel.Controls.Add(this.chckOut);
            this.NavPanel.Controls.Add(this.chckIn);
            this.NavPanel.Controls.Add(this.CustSearch);
            this.NavPanel.Controls.Add(this.roomAvail);
            this.NavPanel.Controls.Add(this.button1);
            this.NavPanel.Controls.Add(this.spacerPanel);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(406, 1137);
            this.NavPanel.TabIndex = 0;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut.Location = new System.Drawing.Point(0, 970);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(406, 120);
            this.logOut.TabIndex = 7;
            this.logOut.Text = "Logout";
            this.logOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // spacerPanel2
            // 
            this.spacerPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.spacerPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerPanel2.Location = new System.Drawing.Point(0, 720);
            this.spacerPanel2.Name = "spacerPanel2";
            this.spacerPanel2.Size = new System.Drawing.Size(406, 250);
            this.spacerPanel2.TabIndex = 6;
            // 
            // chckOut
            // 
            this.chckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.chckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.chckOut.FlatAppearance.BorderSize = 0;
            this.chckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckOut.ForeColor = System.Drawing.Color.White;
            this.chckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chckOut.Location = new System.Drawing.Point(0, 600);
            this.chckOut.Name = "chckOut";
            this.chckOut.Size = new System.Drawing.Size(406, 120);
            this.chckOut.TabIndex = 5;
            this.chckOut.Text = "Check-Out";
            this.chckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chckOut.UseVisualStyleBackColor = false;
            this.chckOut.Click += new System.EventHandler(this.button5_Click);
            // 
            // chckIn
            // 
            this.chckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.chckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.chckIn.FlatAppearance.BorderSize = 0;
            this.chckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckIn.ForeColor = System.Drawing.Color.White;
            this.chckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chckIn.Location = new System.Drawing.Point(0, 480);
            this.chckIn.Name = "chckIn";
            this.chckIn.Size = new System.Drawing.Size(406, 120);
            this.chckIn.TabIndex = 4;
            this.chckIn.Text = "Check-In";
            this.chckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chckIn.UseVisualStyleBackColor = false;
            // 
            // CustSearch
            // 
            this.CustSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.CustSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustSearch.FlatAppearance.BorderSize = 0;
            this.CustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustSearch.ForeColor = System.Drawing.Color.White;
            this.CustSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustSearch.Location = new System.Drawing.Point(0, 360);
            this.CustSearch.Name = "CustSearch";
            this.CustSearch.Size = new System.Drawing.Size(406, 120);
            this.CustSearch.TabIndex = 3;
            this.CustSearch.Text = "Customer Search";
            this.CustSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CustSearch.UseVisualStyleBackColor = false;
            // 
            // roomAvail
            // 
            this.roomAvail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.roomAvail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomAvail.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomAvail.FlatAppearance.BorderSize = 0;
            this.roomAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomAvail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomAvail.ForeColor = System.Drawing.Color.White;
            this.roomAvail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomAvail.Location = new System.Drawing.Point(0, 240);
            this.roomAvail.Name = "roomAvail";
            this.roomAvail.Size = new System.Drawing.Size(406, 120);
            this.roomAvail.TabIndex = 2;
            this.roomAvail.Text = "Room Availability";
            this.roomAvail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.roomAvail.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 120);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Reservation";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // spacerPanel
            // 
            this.spacerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.spacerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerPanel.Location = new System.Drawing.Point(0, 0);
            this.spacerPanel.Name = "spacerPanel";
            this.spacerPanel.Size = new System.Drawing.Size(406, 120);
            this.spacerPanel.TabIndex = 0;
            this.spacerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spacerPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1118, 1017);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(406, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 120);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 1137);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NavPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel NavPanel;
        private Panel spacerPanel;
        private Button chckOut;
        private Button chckIn;
        private Button CustSearch;
        private Button roomAvail;
        private Button button1;
        private Button logOut;
        private Panel spacerPanel2;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}