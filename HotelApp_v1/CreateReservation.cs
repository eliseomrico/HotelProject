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
    public partial class CreateReservation : Form
    {
        public CreateReservation()
        {
            InitializeComponent();
        }

        private void button_create_customer_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomerForm = new CreateCustomer();
            createCustomerForm.ShowDialog();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {

        }
    }
}
