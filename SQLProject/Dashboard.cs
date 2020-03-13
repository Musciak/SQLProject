using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLProject
{
    public partial class Dashboard : Form
    {
        List<Customer> customer = new List<Customer>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
            
        }

        private void UpdateBinding()
        {
            customerFoundListBox.DataSource = customer;
            customerFoundListBox.DisplayMember = "FullInfo";
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            customer = db.GetCustomers(lastNameText.Text);

            //we repeat these two lines cause we have to refresh the list
            UpdateBinding();

        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameInsText.Text, lastname2InsText.Text, cityInsText.Text, countryInsText.Text, phoneInsText.Text);

            firstNameInsText.Text = "";
            cityInsText.Text = "";
            countryInsText.Text = "";
            phoneInsText.Text = "";
            lastname2InsText.Text = "";


        }
    }
}
