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

        private void viewButtonsForAdmin(bool view) // after login for admin display all buttons
        {
            button_home_page_employees.Visible = view;
            button_home_page_locations.Visible = view;
            button_home_page_search_res.Visible = view;
            button_home_page_room_avail.Visible = view;
            button_home_page_cust_search.Visible = view;
            button_home_page_checkin.Visible = view;
            button_home_page_check_out.Visible = view;
            button_home_page_log_out.Visible = view;
            button_home_page_login.Visible = !view;
        }

        private void viewButtonsForRegEmployee(bool view) // after login for regular employee display the following buttons
        {
            button_home_page_locations.Visible = view;
            button_home_page_search_res.Visible = view;
            button_home_page_room_avail.Visible = view;
            button_home_page_cust_search.Visible = view;
            button_home_page_checkin.Visible = view;
            button_home_page_check_out.Visible = view;
            button_home_page_log_out.Visible = view;
            button_home_page_login.Visible = !view;
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
            //RoomAvailabilityForm roomAvailabilityForm = new RoomAvailabilityForm();
            //roomAvailabilityForm.ShowDialog();

            roomAvailability1.Visible = true;
        }

        private void button_home_page_cust_search_Click(object sender, EventArgs e)
        {
            //CustomerSearchForm customerSearchForm = new CustomerSearchForm();
            //customerSearchForm.ShowDialog();

            customerQueryForm1.Visible = true;
        }

        private void button_home_page_checkin_Click(object sender, EventArgs e)
        {
            //CheckIn checkInForm = new CheckIn();
            //checkInForm.ShowDialog();

            checkInForm1.Visible = true;
        }

        private void button_home_page_check_out_Click(object sender, EventArgs e)
        {
            //CheckOut checkOutForm = new CheckOut();
            //checkOutForm.ShowDialog();

            checkOutForm1.Visible = true;
        }

        private void button_home_page_search_res_Click(object sender, EventArgs e)
        {
            //ReservationSearchForm reservationSearchForm = new ReservationSearchForm();
            //reservationSearchForm.ShowDialog();

            reservationQueryForm1.Visible = true;
        }

        private void button_home_page_login_Click(object sender, EventArgs e)
        {
            //EmployeeLogin employeeLoginForm = new EmployeeLogin();
            //employeeLoginForm.ShowDialog();

            employeeLoginForm1.Visible = true;
        }

        private void button_home_page_employees_Click(object sender, EventArgs e)
        {
            //EmployeesForm employeesForm = new EmployeesForm();
            //employeesForm.ShowDialog();

            employees1.Visible = true;
        }

        private void button_home_page_locations_Click(object sender, EventArgs e)
        {
            //LocationsForm locationsForm = new LocationsForm();
            //locationsForm.ShowDialog();

            locations1.Visible = true;
        }
    }
}