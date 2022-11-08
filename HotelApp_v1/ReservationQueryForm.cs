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
    public partial class ReservationQueryForm : UserControl
    {
        public ReservationQueryForm()
        {
            InitializeComponent();
        }
        private void changeEditButtonsVisibility(bool enable) // after search is clicked, show edit and delete buttons
        {
            button_edit.Visible = enable;
            button_submit_edit.Visible = !enable;
        }
        private void changeCreateButtonsVisibility(bool enable)
        {
            button_create.Visible = enable;
            button_submit_create.Visible = !enable;
        }
        private void changeTextBoxesReadOnlyStatus(bool enable) // makes text boxes read-only or not read-only
        {
            textBox_res_emp_id.ReadOnly = enable;
            textBox_res_cust_id.ReadOnly = enable;
            textBox_res_loc_id.ReadOnly = enable;
            textBox_res_room_num.ReadOnly = enable;
            dateTimePicker_start.Enabled = enable;
            dateTimePicker_end.Enabled = enable;
        }
        private void emptyTextBoxes() // clears text from text boxes
        {
            comboBox_res_id.Text = "";
            textBox_res_emp_id.Clear();
            textBox_res_cust_id.Clear();
            textBox_res_loc_id.Clear();
            textBox_res_room_num.Clear();
            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_end.Value = DateTime.Now;
        }
        private void changeButtonsEnabled(bool enable)
        {
            button_create.Enabled = enable;
            button_edit.Enabled = enable;
            button_delete.Enabled = enable;
        }
        private void button_home_Click(object sender, EventArgs e)
        {
            emptyTextBoxes();
            changeButtonsEnabled(false);
            this.Visible = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(true); // delete this when above is filled out
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            // used additional form to create customer, now staying on same form
            // CreateReservation createReservationForm = new CreateReservation();
            // createReservationForm.ShowDialog();

            emptyTextBoxes(); // clears texts from text boxes
            changeCreateButtonsVisibility(false);
            changeButtonsEnabled(false);
            button_search.Enabled = false;
            button_submit_create.Enabled = true;
        }

        private void button_submit_create_Click(object sender, EventArgs e)
        {
            emptyTextBoxes(); // clears texts from text boxes
            changeCreateButtonsVisibility(true);
            changeButtonsEnabled(true);
            button_search.Enabled = true;
            button_submit_create.Enabled = false;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            changeEditButtonsVisibility(false);
            changeTextBoxesReadOnlyStatus(false); // make text boxes non-'editable' or read-only
            changeButtonsEnabled(false);
            button_submit_edit.Enabled = true;
            button_search.Enabled = false; // disable search button
        }

        private void button_submit_edit_Click(object sender, EventArgs e)
        {
            changeEditButtonsVisibility(true);
            changeTextBoxesReadOnlyStatus(true); // make text boxes non-'editable' or read-only
            changeButtonsEnabled(true);
            button_submit_edit.Enabled = false;
            button_search.Enabled = true; // enable search button
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // add delete logic here

            emptyTextBoxes(); // clears texts from text boxes
            changeButtonsEnabled(false); // hide edit and delete buttons
            changeTextBoxesReadOnlyStatus(true); // make text boxes read-only
        }
    }
}
