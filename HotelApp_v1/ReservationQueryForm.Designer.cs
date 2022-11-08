namespace HotelApp_v1
{
    partial class ReservationQueryForm
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
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.comboBox_res_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_res_emp_id = new System.Windows.Forms.TextBox();
            this.textBox_res_cust_id = new System.Windows.Forms.TextBox();
            this.textBox_res_loc_id = new System.Windows.Forms.TextBox();
            this.textBox_res_room_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_submit_edit = new System.Windows.Forms.Button();
            this.button_submit_create = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button_submit_create);
            this.panel2.Controls.Add(this.button_submit_edit);
            this.panel2.Controls.Add(this.dateTimePicker_end);
            this.panel2.Controls.Add(this.dateTimePicker_start);
            this.panel2.Controls.Add(this.button_search);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_create);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.comboBox_res_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_res_emp_id);
            this.panel2.Controls.Add(this.textBox_res_cust_id);
            this.panel2.Controls.Add(this.textBox_res_loc_id);
            this.panel2.Controls.Add(this.textBox_res_room_num);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 545);
            this.panel2.TabIndex = 23;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end.Location = new System.Drawing.Point(426, 430);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(227, 27);
            this.dateTimePicker_end.TabIndex = 29;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start.Location = new System.Drawing.Point(426, 346);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(227, 27);
            this.dateTimePicker_start.TabIndex = 28;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(138, 501);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(138, 44);
            this.button_search.TabIndex = 27;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_delete.Enabled = false;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(553, 501);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(139, 44);
            this.button_delete.TabIndex = 26;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_edit.Enabled = false;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(415, 501);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(139, 44);
            this.button_edit.TabIndex = 25;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_create.Enabled = false;
            this.button_create.FlatAppearance.BorderSize = 0;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(276, 501);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(139, 44);
            this.button_create.TabIndex = 24;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
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
            this.button_home.Size = new System.Drawing.Size(138, 44);
            this.button_home.TabIndex = 23;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // comboBox_res_id
            // 
            this.comboBox_res_id.BackColor = System.Drawing.Color.White;
            this.comboBox_res_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_res_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_res_id.FormattingEnabled = true;
            this.comboBox_res_id.Location = new System.Drawing.Point(62, 124);
            this.comboBox_res_id.Name = "comboBox_res_id";
            this.comboBox_res_id.Size = new System.Drawing.Size(227, 28);
            this.comboBox_res_id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation ID";
            // 
            // textBox_res_emp_id
            // 
            this.textBox_res_emp_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_res_emp_id.Location = new System.Drawing.Point(426, 125);
            this.textBox_res_emp_id.Name = "textBox_res_emp_id";
            this.textBox_res_emp_id.ReadOnly = true;
            this.textBox_res_emp_id.Size = new System.Drawing.Size(227, 27);
            this.textBox_res_emp_id.TabIndex = 8;
            // 
            // textBox_res_cust_id
            // 
            this.textBox_res_cust_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_res_cust_id.Location = new System.Drawing.Point(62, 237);
            this.textBox_res_cust_id.Name = "textBox_res_cust_id";
            this.textBox_res_cust_id.ReadOnly = true;
            this.textBox_res_cust_id.Size = new System.Drawing.Size(227, 27);
            this.textBox_res_cust_id.TabIndex = 9;
            // 
            // textBox_res_loc_id
            // 
            this.textBox_res_loc_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_res_loc_id.Location = new System.Drawing.Point(426, 237);
            this.textBox_res_loc_id.Name = "textBox_res_loc_id";
            this.textBox_res_loc_id.ReadOnly = true;
            this.textBox_res_loc_id.Size = new System.Drawing.Size(227, 27);
            this.textBox_res_loc_id.TabIndex = 10;
            // 
            // textBox_res_room_num
            // 
            this.textBox_res_room_num.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_res_room_num.Location = new System.Drawing.Point(62, 348);
            this.textBox_res_room_num.Name = "textBox_res_room_num";
            this.textBox_res_room_num.ReadOnly = true;
            this.textBox_res_room_num.Size = new System.Drawing.Size(227, 27);
            this.textBox_res_room_num.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Enter Reservation ID and click Search below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reservation Location ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reservation Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reservation Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reservation End Date";
            // 
            // button_submit_edit
            // 
            this.button_submit_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit_edit.Enabled = false;
            this.button_submit_edit.FlatAppearance.BorderSize = 0;
            this.button_submit_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_edit.ForeColor = System.Drawing.Color.White;
            this.button_submit_edit.Location = new System.Drawing.Point(415, 501);
            this.button_submit_edit.Name = "button_submit_edit";
            this.button_submit_edit.Size = new System.Drawing.Size(139, 44);
            this.button_submit_edit.TabIndex = 30;
            this.button_submit_edit.Text = "Submit Edit";
            this.button_submit_edit.UseVisualStyleBackColor = false;
            this.button_submit_edit.Visible = false;
            this.button_submit_edit.Click += new System.EventHandler(this.button_submit_edit_Click);
            // 
            // button_submit_create
            // 
            this.button_submit_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit_create.Enabled = false;
            this.button_submit_create.FlatAppearance.BorderSize = 0;
            this.button_submit_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_create.ForeColor = System.Drawing.Color.White;
            this.button_submit_create.Location = new System.Drawing.Point(276, 501);
            this.button_submit_create.Name = "button_submit_create";
            this.button_submit_create.Size = new System.Drawing.Size(139, 44);
            this.button_submit_create.TabIndex = 31;
            this.button_submit_create.Text = "Submit Create";
            this.button_submit_create.UseVisualStyleBackColor = false;
            this.button_submit_create.Visible = false;
            this.button_submit_create.Click += new System.EventHandler(this.button_submit_create_Click);
            // 
            // ReservationQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ReservationQueryForm";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.ComboBox comboBox_res_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_res_emp_id;
        private System.Windows.Forms.TextBox textBox_res_cust_id;
        private System.Windows.Forms.TextBox textBox_res_loc_id;
        private System.Windows.Forms.TextBox textBox_res_room_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Button button_submit_edit;
        private System.Windows.Forms.Button button_submit_create;
    }
}
