using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EDP_Act8
{
    public partial class main_form : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public main_form()
        {
            InitializeComponent();
            empDataLoad();
            success_msg.Hide();
        }

        // load to datagridview
        public class Employee
        {
            public string emp_id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string contact_num { get; set; }
            public string email { get; set; }
            public string dept_name { get; set; }
            public string dept_location { get; set; }
        }
        async void empDataLoad()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost/php_api/api.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var employees = JsonConvert.DeserializeObject<List<Employee>>(responseBody);
                dataGridView1.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void register_btn_Click(object sender, EventArgs e)
        {
            var empData = new { first_name = fname_tbx.Text, last_name = lname_tbx.Text, contact_num = cnum_tbx.Text, email = email_tbx.Text, dept_id = dept_tbx.Text };
            string json = JsonConvert.SerializeObject(empData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/php_api/api.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var employee = JsonConvert.DeserializeObject<Employee>(responseBody);

                // show success message
                success_msg.Show();
                String e_name = fname_tbx.Text + " " + lname_tbx.Text;
                success_msg.Text = "Employee " + e_name + " registered successfully.";

                // refresh data
                empDataLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}