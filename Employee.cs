using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Employee
    {
        public int Id=0;
        private string name;
        public string Lastname;
        public long Pesel;
        public DateTime BirthDate;
        public string Email;
        public string City;
        public string HouseNumber;
        public string PostalCode;
        public string Department;
        public double Wage;
        public string Adnotations=" ";

        public static string CheckStringCorrectness(string str)
        {
            char[] strCharArray = str.ToCharArray();
            foreach(char element in strCharArray)
            {

                int.TryParse(element, out int variable);
                if (variable == null)
                    continue;
                else break;
            }
            return str;
        }
        public Employee()
        {

        }
        public string Name {
            get
            {
                return name;
            }
            set
            {
                if(name!=null||name.)
                name = value;
            }
        }
    }
}
