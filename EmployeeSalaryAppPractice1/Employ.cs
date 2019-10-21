using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryAppPractice1
{
    class Employ
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public Salary Salary { set; get; }

        public bool MedicalBasic(double medical)
        {
            if(Salary == null)
            {
                return false;
            }
            return Salary.MedicalBasic(medical);
        }
        public bool ConveyanceBasic(double conveyance)
        {
            if(Salary == null)
            {
                return false;
            }
            return Salary.ConveyanceBasic(conveyance);
        }
        public bool Increment(double basicincres)
        {
            return Salary.Increment(basicincres);
        }
    }
}
