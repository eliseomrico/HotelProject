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

        private void enableButtons(bool enable)
        {
            button_edit.Visible = enable;
            button_delete.Visible = enable;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            /*
            if (reader.Read())
            {
                // reader statements here
                enableButtons(true);
            }
            else
            {
                MessageBox.Show("Reservation NOT found!");
            }
            */
            enableButtons(true); // delete this when above is filled out
        }
    }
}
