namespace HotelApp_v1
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_finish_edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_emp_ssn = new System.Windows.Forms.TextBox();
            this.textBox_super_id = new System.Windows.Forms.TextBox();
            this.textBox_emp_fname = new System.Windows.Forms.TextBox();
            this.textBox_emp_lname = new System.Windows.Forms.TextBox();
            this.textBox_emp_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_emp_id = new System.Windows.Forms.ComboBox();
            this.button_submit_create = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.button_create);
            this.panel1.Controls.Add(this.button_submit_create);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_finish_edit);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 548);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(3, 470);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(214, 82);
            this.button_search.TabIndex = 15;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_create.FlatAppearance.BorderSize = 0;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(3, 224);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(214, 82);
            this.button_create.TabIndex = 19;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(3, 306);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(214, 82);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(3, 388);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(214, 82);
            this.button_edit.TabIndex = 17;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Visible = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_finish_edit
            // 
            this.button_finish_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_finish_edit.FlatAppearance.BorderSize = 0;
            this.button_finish_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_finish_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_finish_edit.ForeColor = System.Drawing.Color.White;
            this.button_finish_edit.Location = new System.Drawing.Point(3, 388);
            this.button_finish_edit.Name = "button_finish_edit";
            this.button_finish_edit.Size = new System.Drawing.Size(214, 82);
            this.button_finish_edit.TabIndex = 18;
            this.button_finish_edit.Text = "Save Edit";
            this.button_finish_edit.UseVisualStyleBackColor = false;
            this.button_finish_edit.Visible = false;
            this.button_finish_edit.Click += new System.EventHandler(this.button_finish_edit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox_emp_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_emp_ssn);
            this.panel2.Controls.Add(this.textBox_super_id);
            this.panel2.Controls.Add(this.textBox_emp_fname);
            this.panel2.Controls.Add(this.textBox_emp_lname);
            this.panel2.Controls.Add(this.textBox_emp_title);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(208, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 548);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // textBox_emp_ssn
            // 
            this.textBox_emp_ssn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emp_ssn.Location = new System.Drawing.Point(165, 195);
            this.textBox_emp_ssn.Name = "textBox_emp_ssn";
            this.textBox_emp_ssn.ReadOnly = true;
            this.textBox_emp_ssn.Size = new System.Drawing.Size(227, 27);
            this.textBox_emp_ssn.TabIndex = 8;
            // 
            // textBox_super_id
            // 
            this.textBox_super_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_super_id.Location = new System.Drawing.Point(165, 265);
            this.textBox_super_id.Name = "textBox_super_id";
            this.textBox_super_id.ReadOnly = true;
            this.textBox_super_id.Size = new System.Drawing.Size(227, 27);
            this.textBox_super_id.TabIndex = 9;
            // 
            // textBox_emp_fname
            // 
            this.textBox_emp_fname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emp_fname.Location = new System.Drawing.Point(165, 335);
            this.textBox_emp_fname.Name = "textBox_emp_fname";
            this.textBox_emp_fname.ReadOnly = true;
            this.textBox_emp_fname.Size = new System.Drawing.Size(227, 27);
            this.textBox_emp_fname.TabIndex = 10;
            // 
            // textBox_emp_lname
            // 
            this.textBox_emp_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emp_lname.Location = new System.Drawing.Point(165, 405);
            this.textBox_emp_lname.Name = "textBox_emp_lname";
            this.textBox_emp_lname.ReadOnly = true;
            this.textBox_emp_lname.Size = new System.Drawing.Size(227, 27);
            this.textBox_emp_lname.TabIndex = 11;
            // 
            // textBox_emp_title
            // 
            this.textBox_emp_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emp_title.Location = new System.Drawing.Point(165, 475);
            this.textBox_emp_title.Name = "textBox_emp_title";
            this.textBox_emp_title.ReadOnly = true;
            this.textBox_emp_title.Size = new System.Drawing.Size(227, 27);
            this.textBox_emp_title.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee SSN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Enter Employee ID and click Search below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supervisor ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee Title";
            // 
            // comboBox_emp_id
            // 
            this.comboBox_emp_id.BackColor = System.Drawing.Color.White;
            this.comboBox_emp_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_emp_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_emp_id.FormattingEnabled = true;
            this.comboBox_emp_id.Location = new System.Drawing.Point(165, 125);
            this.comboBox_emp_id.Name = "comboBox_emp_id";
            this.comboBox_emp_id.Size = new System.Drawing.Size(227, 28);
            this.comboBox_emp_id.TabIndex = 16;
            // 
            // button_submit_create
            // 
            this.button_submit_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit_create.FlatAppearance.BorderSize = 0;
            this.button_submit_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_create.ForeColor = System.Drawing.Color.White;
            this.button_submit_create.Location = new System.Drawing.Point(3, 224);
            this.button_submit_create.Name = "button_submit_create";
            this.button_submit_create.Size = new System.Drawing.Size(214, 82);
            this.button_submit_create.TabIndex = 23;
            this.button_submit_create.Text = "Submit Create";
            this.button_submit_create.UseVisualStyleBackColor = false;
            this.button_submit_create.Visible = false;
            this.button_submit_create.Click += new System.EventHandler(this.button_submit_create_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_finish_edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_emp_ssn;
        private System.Windows.Forms.TextBox textBox_super_id;
        private System.Windows.Forms.TextBox textBox_emp_fname;
        private System.Windows.Forms.TextBox textBox_emp_lname;
        private System.Windows.Forms.TextBox textBox_emp_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_emp_id;
        private System.Windows.Forms.Button button_submit_create;
    }
}