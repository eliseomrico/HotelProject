namespace HotelApp_v1
{
    partial class ViewReservations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.reservationQueryForm1 = new HotelApp_v1.ReservationQueryForm();
            this.button_manage_reservations = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.comboBox_location_name = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.reservationQueryForm1);
            this.panel2.Controls.Add(this.button_manage_reservations);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.comboBox_location_name);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 545);
            this.panel2.TabIndex = 24;
            // 
            // reservationQueryForm1
            // 
            this.reservationQueryForm1.Location = new System.Drawing.Point(0, 0);
            this.reservationQueryForm1.Name = "reservationQueryForm1";
            this.reservationQueryForm1.Size = new System.Drawing.Size(692, 545);
            this.reservationQueryForm1.TabIndex = 27;
            this.reservationQueryForm1.Visible = false;
            // 
            // button_manage_reservations
            // 
            this.button_manage_reservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_manage_reservations.FlatAppearance.BorderSize = 0;
            this.button_manage_reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_reservations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manage_reservations.ForeColor = System.Drawing.Color.White;
            this.button_manage_reservations.Location = new System.Drawing.Point(346, 501);
            this.button_manage_reservations.Name = "button_manage_reservations";
            this.button_manage_reservations.Size = new System.Drawing.Size(346, 44);
            this.button_manage_reservations.TabIndex = 26;
            this.button_manage_reservations.Text = "Manage Reservations";
            this.button_manage_reservations.UseVisualStyleBackColor = false;
            this.button_manage_reservations.Click += new System.EventHandler(this.button_manage_reservations_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(0, 501);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(346, 44);
            this.button_home.TabIndex = 24;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // comboBox_location_name
            // 
            this.comboBox_location_name.BackColor = System.Drawing.Color.White;
            this.comboBox_location_name.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_location_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_location_name.FormattingEnabled = true;
            this.comboBox_location_name.Location = new System.Drawing.Point(332, 124);
            this.comboBox_location_name.Name = "comboBox_location_name";
            this.comboBox_location_name.Size = new System.Drawing.Size(208, 28);
            this.comboBox_location_name.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 325);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(494, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Choose desired location to view rooms and room types";
            // 
            // ViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ViewReservations";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_manage_reservations;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.ComboBox comboBox_location_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private ReservationQueryForm reservationQueryForm1;
    }
}
