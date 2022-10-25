namespace HotelApp_v1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_customer = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click below to Search by Customer or Reservation";
            // 
            // button_customer
            // 
            this.button_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customer.Location = new System.Drawing.Point(183, 220);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(109, 43);
            this.button_customer.TabIndex = 1;
            this.button_customer.Text = "Customer";
            this.button_customer.UseVisualStyleBackColor = true;
            this.button_customer.Click += new System.EventHandler(this.button_CUSTOMER_Click);
            // 
            // button_reservation
            // 
            this.button_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reservation.Location = new System.Drawing.Point(509, 220);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(115, 43);
            this.button_reservation.TabIndex = 2;
            this.button_reservation.Text = "Reservation";
            this.button_reservation.UseVisualStyleBackColor = true;
            this.button_reservation.Click += new System.EventHandler(this.button_RESERVATION_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_reservation);
            this.Controls.Add(this.button_customer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.Button button_reservation;
    }
}

