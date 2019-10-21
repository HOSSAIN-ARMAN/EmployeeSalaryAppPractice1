using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryAppPractice1
{
    class Salary
    {
        public double Basic { set; get; }
        public double Medical { get;  set; }
        public double Conveyance { get;  set; }

        public double BasicIncrements { set; get; }
        public double Total { get; private set; }

       
        public bool MedicalBasic(double medical)
        {           
            double medicalbasic = (medical * Basic) / 100;
            Medical = medicalbasic;
            return true;
        }
        public bool ConveyanceBasic(double conveyance)
        {

            double conveyanceBasic = (conveyance * Basic) / 100;
            Conveyance = conveyanceBasic;
            return true;
        }

        public bool Increment(double basicincres)
        {

            BasicIncrements = basicincres;

            //Basic = Basic + ((Basic * basicincres) / 100);

            Total = (Basic + ((Basic * basicincres) / 100)) + Medical + Conveyance;
            return true;

        }


    }
}
