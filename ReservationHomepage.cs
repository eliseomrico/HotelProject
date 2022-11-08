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
    public partial class ReservationHomepage : Form
    {
        public ReservationHomepage()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void createResBttn_Click(object sender, EventArgs e)
        {
            CreateReservation newRes = new CreateReservation();
            newRes.TopLevel = false;
            reservationPanel.Controls.Add(newRes);
            newRes.BringToFront();
            newRes.Show();
        }

        private void searchResBttn_Click(object sender, EventArgs e)
        {
            ReservationSearchForm searchRes = new ReservationSearchForm();
            searchRes.TopLevel = false;
            reservationPanel.Controls.Add(searchRes);
            searchRes.BringToFront();
            searchRes.Show();
        }
    }
}
