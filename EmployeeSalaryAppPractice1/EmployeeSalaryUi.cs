using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryAppPractice1
{
    public partial class EmployeeSalaryUi : Form
    {
        public EmployeeSalaryUi()
        {
            InitializeComponent();
        }
        private Employ _employ;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _employ = new Employ();
            _employ.Id = IdTextBox.Text;
            _employ.Name = nameTextBox.Text;
            _employ.Email = emailTextBox.Text;

            //_employ.Salary = new Salary();
            //_employ.Salary.Basic = Convert.ToDouble(basicTextBox.Text);
            //_employ.Salary.Medical = Convert.ToDouble(medicalTextBox.Text);
            //_employ.Salary.Conveyance = Convert.ToDouble(conveyanceTextBox.Text);

            

            


            Salary salary = new Salary();
            salary.Basic = Convert.ToDouble(basicTextBox.Text);           
            _employ.Salary = salary;

            _employ.MedicalBasic(Convert.ToDouble(medicalTextBox.Text));
            _employ.ConveyanceBasic(Convert.ToDouble(conveyanceTextBox.Text));

            //this part is abastract part and associate with the salary in Employ class


        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            double basicincres = Convert.ToDouble(increaseTextBox.Text);
            _employ.Increment(basicincres);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
           

            noOfIncrementsTextBox.Text = _employ.Salary.BasicIncrements.ToString();
            showBasicTextBox.Text = _employ.Salary.Basic.ToString();
            showMedicalTextBox.Text = _employ.Salary.Medical.ToString();
            showConveyanceTextBox.Text = _employ.Salary.Conveyance.ToString();
            showTotalTextBox.Text = _employ.Salary.Total.ToString();
        }
    }
}
