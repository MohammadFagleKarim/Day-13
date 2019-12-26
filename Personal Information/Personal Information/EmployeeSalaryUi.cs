using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class EmployeeSalaryUi : Form
    {
        public EmployeeSalaryUi()
        {
            InitializeComponent();
        }

        private Employee employee1;

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            employee1 = new Employee(employeeNameTextBox.Text, Convert.ToDouble(basicAmountTextBox.Text), Convert.ToDouble(houseRentTextBox.Text), Convert.ToDouble(medicalAllowanceTextBox.Text));

            List<Employee> employees = new List<Employee>();

            employees.Add(employee1);

            employee1.HouseRent(Convert.ToDouble(houseRentTextBox.Text));
            employee1.MedicalAllowance(Convert.ToDouble(medicalAllowanceTextBox.Text));

            if (houseRentTextBox.Text != null)
            {
                basicAmountTextBox.Clear();
            }

            if (medicalAllowanceTextBox.Text != null)
            {
                houseRentTextBox.Clear();
            }

            if (basicAmountTextBox.Text != null)
            {
                medicalAllowanceTextBox.Clear();
            }

            if (employeeNameTextBox.Text != null)
            {
                employeeNameTextBox.Clear();
            }

            string message = employee1.GetBalanceInfomation();
            MessageBox.Show(message);

            //employee1.employeeName = employeeNameTextBox.Text;
            //double Basic = Convert.ToDouble(basicAmountTextBox.Text);
            //double Rent = Convert.ToDouble(houseRentTextBox.Text);
            //double Medical = Convert.ToDouble(medicalAllowanceTextBox.Text);

            //bool isBasicAmount = employee1.BasicAmount(Basic);
            //bool isHouseRent = employee1.HouseRent(Rent);
            //bool isMedical = employee1.MedicalAllowance(Medical);

            //if (isBasicAmount)
            //{
            //    basicAmountTextBox.Text = "";
            //}

            //if (isHouseRent)
            //{
            //    houseRentTextBox.Text = "";
            //}

            //if (isMedical)
            //{
            //    medicalAllowanceTextBox.Text = "";
            //}

            //string message = employee1.GetBalanceInfo();
            //MessageBox.Show(message);

            //employee1.BasicAmount();
            //employee1.HouseRent();
            //employee1.MedicalAllowance();
        }
    }
}
