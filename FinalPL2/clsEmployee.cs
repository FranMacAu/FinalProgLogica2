using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPL2
{
    internal class clsEmployee
    {
        public string FileName = "HR_Employee.csv";
        public struct Employee
        {
            int BusinessEntityID;
            int NationalIDNumber;
            string LoginID;
            string OrganizationNode;
            int OrganizationLevel;
            string JobTitle;
            DateTime BirthDate;
            char MaritalStatus;
            char Gender;
            DateTime HireDate;
            int SalariedFlag;
            int VacationHours;
            int SickLeaveHours;
            int CurrentFlag;
            string rowguid;
            DateTime ModifiedDate;
        }

        private Employee[] Employees = new Employee[500];



    }
}
