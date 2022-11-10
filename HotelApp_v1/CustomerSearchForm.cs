using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp_v1
{
    public partial class CustomerSearchForm : Form
    {
        public CustomerSearchForm()
        {
            InitializeComponent();
        }
        private void changeButtonsVisibility(bool enable) // after search is clicked, show edit and delete buttons
        {
            button_edit.Visible = enable;
            button_delete.Visible = enable;
        }
        private void changeTextBoxesReadOnlyStatus(bool enable) // makes text boxes read-only or not read-only
        {
            textBox_cust_fname.ReadOnly = enable;
            textBox_cust_lname.ReadOnly = enable;
            textBox_cust_phone_num.ReadOnly = enable;
            textBox_cust_cc_num.ReadOnly = enable;
            textBox_cust_balance.ReadOnly = enable;
        }
        private void emptyTextBoxes()
        {
            comboBox_cust_id.Text = "";
            textBox_cust_fname.Clear();
            textBox_cust_lname.Clear();
            textBox_cust_phone_num.Clear();
            textBox_cust_cc_num.Clear();
            textBox_cust_balance.Clear();
        }
        private void disableTextBoxes(Boolean visible_status)
        {
            textBox_cust_fname.ReadOnly = visible_status;
            textBox_cust_lname.ReadOnly = visible_status; ;
            textBox_cust_phone_num.ReadOnly = visible_status; ;
            textBox_cust_cc_num.ReadOnly = visible_status; ;
            textBox_cust_balance.ReadOnly = visible_status; ;
        }
        private void goBack()
        {
            emptyTextBoxes();
            disableTextBoxes(true);

            button_submit_create.Visible = false;
            button_cancel.Visible = false;
            button_create.Visible = true;
            textBox_cust_id.Visible = false;
            comboBox_cust_id.Visible = true;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            /*
            if (reader.Read())
            {
                // reader statements here
                changeButtonsVisibility(true);
            }
            else
            {
                MessageBox.Show("Customer NOT found!");
            }
            */
            changeButtonsVisibility(true); // delete this when above is filled out
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            button_create.Visible = false;
            button_edit.Visible = false; // hide edit button
            button_finish_edit.Visible = true; // show save edit button
            button_delete.Visible = false; // hide delete button
            button_search.Visible = false; // hide search button
            changeTextBoxesReadOnlyStatus(false); // make text boxes 'editable' or not read-only
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            emptyTextBoxes(); // clears texts from text boxes
            changeButtonsVisibility(false); // hide edit and delete buttons
            changeTextBoxesReadOnlyStatus(true); // make text boxes read-only
        }
        private void button_finish_edit_Click(object sender, EventArgs e)
        {
            button_create.Visible = true;
            button_edit.Visible = true; // show edit button
            button_finish_edit.Visible = false; // hide save edit button
            button_delete.Visible = true; // show delete button
            button_search.Visible = true; // show search button
            changeTextBoxesReadOnlyStatus(true); // make text boxes non-'editable' or read-only
        }
        public string getCustID()
        {
            // Authored By: Marcel Rico
            string custID = "";

            SqlConnection conn = new SqlConnection("Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=SSPI");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(cust_id) FROM CUSTOMER", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    if (DBNull.Value.Equals(dr[0]))
                    {
                        custID = "1";
                        Console.WriteLine(dr[0]);
                    }
                    else
                    {
                        custID = (int.Parse(dr[0].ToString()) + 1).ToString();
                    }
                  
                }

            }
            catch
            {

            }

            return custID;
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            // used additional form to create customer, now staying on same form
            // CreateCustomer createCustomerForm = new CreateCustomer(); 
            // createCustomerForm.ShowDialog();

            emptyTextBoxes(); // clears texts from text boxes
            changeButtonsVisibility(false);
            button_search.Visible = false;
            button_create.Visible = false;
            button_submit_create.Visible = true;


            // Code Written By Marcel

            comboBox_cust_id.Visible = false;
            textBox_cust_id.Visible = true;

            textBox_cust_balance.ReadOnly = false;
            textBox_cust_cc_num.ReadOnly = false;
            textBox_cust_fname.ReadOnly = false;
            textBox_cust_lname.ReadOnly = false;
            textBox_cust_phone_num.ReadOnly = false;

            // Code to get Current Customer ID in DB
            // Display Current Customer ID in Cust_ID
            string cust_id = getCustID();
            textBox_cust_id.Text = cust_id;
            button_cancel.Visible = true;
            button_edit.Visible = false;
        }
        private void button_submit_create_Click(object sender, EventArgs e)
        {

            // Code Written By Marcel

            string cust_first_name = textBox_cust_fname.Text;
            string cust_last_name = textBox_cust_lname.Text;
            string cust_phone_number = textBox_cust_phone_num.Text;
            string cust_cc_number = textBox_cust_cc_num.Text;
            string cust_balance = textBox_cust_balance.Text;


            
            //decimal cust_balance = Convert.ToDecimal("500.00", CultureInfo.InvariantCulture);
            

            SqlConnection conn = new SqlConnection("Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=SSPI");
            

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMER (CUST_FNAME, CUST_LNAME, CUST_PHONE,CUST_BALANCE) VALUES ('"+cust_first_name+"', '"+cust_last_name+"', '"+cust_phone_number+"', "+Decimal.Parse(cust_balance)+")", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            goBack();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            goBack();
        }
    }
}
