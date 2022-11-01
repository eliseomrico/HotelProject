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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void spacerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_home_page_log_out_Click(object sender, EventArgs e)
        {
            EmployeeLogin employeeLogin = new EmployeeLogin();
            employeeLogin.ShowDialog();
        }

        private void button_home_page_room_avail_Click(object sender, EventArgs e)
        {

        }

        private void button_home_page_cust_search_Click(object sender, EventArgs e)
        {
            CustomerSearchForm customerSearchForm = new CustomerSearchForm();
            customerSearchForm.ShowDialog();
        }

        private void button_home_page_checkin_Click(object sender, EventArgs e)
        {
            CheckIn checkInForm = new CheckIn();
            checkInForm.ShowDialog();
        }

        private void button_home_page_check_out_Click(object sender, EventArgs e)
        {
            CheckOut checkOutForm = new CheckOut();
            checkOutForm.ShowDialog();
        }

        private void button_home_page_search_res_Click(object sender, EventArgs e)
        {
            ReservationSearchForm reservationSearchForm = new ReservationSearchForm();
            reservationSearchForm.ShowDialog();
        }
    }
}