namespace HotelApp_v1
{
    partial class CheckOutForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_checkout_lname = new System.Windows.Forms.TextBox();
            this.textBox_checkout_res_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button_submit);
            this.panel3.Controls.Add(this.button_home);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox_checkout_lname);
            this.panel3.Controls.Add(this.textBox_checkout_res_id);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 545);
            this.panel3.TabIndex = 23;
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit.FlatAppearance.BorderSize = 0;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.ForeColor = System.Drawing.Color.White;
            this.button_submit.Location = new System.Drawing.Point(346, 501);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(346, 44);
            this.button_submit.TabIndex = 30;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
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
            this.button_home.TabIndex = 29;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Check Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Last Name";
            // 
            // textBox_checkout_lname
            // 
            this.textBox_checkout_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_checkout_lname.Location = new System.Drawing.Point(80, 187);
            this.textBox_checkout_lname.Name = "textBox_checkout_lname";
            this.textBox_checkout_lname.Size = new System.Drawing.Size(227, 27);
            this.textBox_checkout_lname.TabIndex = 10;
            // 
            // textBox_checkout_res_id
            // 
            this.textBox_checkout_res_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_checkout_res_id.Location = new System.Drawing.Point(360, 187);
            this.textBox_checkout_res_id.Name = "textBox_checkout_res_id";
            this.textBox_checkout_res_id.Size = new System.Drawing.Size(227, 27);
            this.textBox_checkout_res_id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reservation ID";
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "CheckOutForm";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_checkout_lname;
        private System.Windows.Forms.TextBox textBox_checkout_res_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_home;
    }
}
