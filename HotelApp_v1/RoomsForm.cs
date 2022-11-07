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
    public partial class RoomsForm : Form
    {
        public RoomsForm()
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
            textBox_room_type.ReadOnly = enable;
            textBox_room_type_description.ReadOnly = enable;
            textBox_room_price.ReadOnly = enable;
            textBox_room_available.ReadOnly = enable;
        }
        private void emptyTextBoxes()
        {
            comboBox_room_num.Text = "";
            comboBox_loc_id.Text = "";
            textBox_room_type.Clear();
            textBox_room_type_description.Clear();
            textBox_room_price.Clear();
            textBox_room_available.Clear();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            changeButtonsVisibility(true);
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

        private void button_finish_edit_Click(object sender, EventArgs e)
        {
            button_create.Visible = true;
            button_edit.Visible = true; // show edit button
            button_finish_edit.Visible = false; // hide save edit button
            button_delete.Visible = true; // show delete button
            button_search.Visible = true; // show search button
            changeTextBoxesReadOnlyStatus(true); // make text boxes non-'editable' or read-only
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            emptyTextBoxes(); // clears texts from text boxes
            changeButtonsVisibility(false); // hide edit and delete buttons
            changeTextBoxesReadOnlyStatus(true); // make text boxes read-only
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            emptyTextBoxes(); // clears texts from text boxes
            changeButtonsVisibility(false);
            button_search.Visible = false;
            button_create.Visible = false;
            button_submit_create.Visible = true;
        }

        private void button_submit_create_Click(object sender, EventArgs e)
        {
            emptyTextBoxes(); // clears texts from text boxes
            changeButtonsVisibility(true);
            button_search.Visible = true;
            button_create.Visible = true;
            button_submit_create.Visible = false;
        }
    }
}
