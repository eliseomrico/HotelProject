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
    public partial class ReservationSearchForm : Form
    {
        public ReservationSearchForm()
        {
            InitializeComponent();
        }

/*        private void changeButtonsVisibility(bool enable) // after search is clicked, show edit and delete buttons
        {
            button_edit.Visible = enable;
            button_delete.Visible = enable;
        }*/
        private void changeTextBoxesReadOnlyStatus(bool enable) // makes text boxes read-only or not read-only
        {
            textBox_res_emp_id.ReadOnly = enable;
            textBox_res_cust_id.ReadOnly = enable;
            textBox_res_loc_id.ReadOnly = enable;
            textBox_res_room_num.ReadOnly = enable;
            textBox_res_start_date.ReadOnly = enable;
            textBox_res_end_date.ReadOnly = enable;
        }
        private void emptyTextBoxes() // clears text from text boxes
        {
            textBox_res_id.Clear();
            textBox_res_emp_id.Clear();
            textBox_res_cust_id.Clear();
            textBox_res_loc_id.Clear();
            textBox_res_room_num.Clear();
            textBox_res_start_date.Clear();
            textBox_res_end_date.Clear();
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
                MessageBox.Show("Reservation NOT found!");
            }
            
            changeButtonsVisibility(true); // delete this when above is filled out*/
        }

/*        private void button_edit_Click(object sender, EventArgs e)
        {
            button_edit.Visible = false; // hide edit button
            button_finish_edit.Visible = true; // show save edit button
            button_delete.Visible = false; // hide delete button
            button_search.Visible = false; // hide search button
            changeTextBoxesReadOnlyStatus(false); // make text boxes 'editable' or not read-only
        }*/

        private void button_delete_Click(object sender, EventArgs e)
        {
            // add delete logic here

            emptyTextBoxes(); // clears texts from text boxes
            //changeButtonsVisibility(false); // hide edit and delete buttons
            changeTextBoxesReadOnlyStatus(true); // make text boxes read-only
        }

 /*       private void button_finish_edit_Click(object sender, EventArgs e)
        {
            button_edit.Visible = true; // show edit button
            button_finish_edit.Visible = false; // hide save edit button
            button_delete.Visible = true; // show delete button
            button_search.Visible = true; // show search button
            changeTextBoxesReadOnlyStatus(true); // make text boxes non-'editable' or read-only
        }*/

        private void button_create_Click(object sender, EventArgs e)
        {
            CreateReservation createReservationForm = new CreateReservation();
            createReservationForm.ShowDialog();
        }
    }
}
