using EmployeeRegister.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister.repository {
    internal class EmployeeRepository {

        private List<Employee> employees = new List<Employee>();

        public EmployeeRepository() { }
        public List<Employee> Employees {
            get { return employees; }
        } 
    }
}
