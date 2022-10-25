using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            textBox_cust_id.Clear();
            textBox_cust_fname.Clear();
            textBox_cust_lname.Clear();
            textBox_cust_phone_num.Clear();
            textBox_cust_cc_num.Clear();
            textBox_cust_balance.Clear();
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
            button_edit.Visible = true; // show edit button
            button_finish_edit.Visible = false; // hide save edit button
            button_delete.Visible = true; // show delete button
            button_search.Visible = true; // show search button
            changeTextBoxesReadOnlyStatus(true); // make text boxes non-'editable' or read-only
        }
    }
}
