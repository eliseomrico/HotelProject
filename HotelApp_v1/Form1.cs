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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_CUSTOMER_Click(object sender, EventArgs e)
        {
            CustomerSearchForm customerSearchForm = new CustomerSearchForm();
            customerSearchForm.ShowDialog();
        }

        private void button_RESERVATION_Click(object sender, EventArgs e)
        {
            ReservationSearchForm reservationSearchForm = new ReservationSearchForm();
            reservationSearchForm.ShowDialog();
        }
    }
}
