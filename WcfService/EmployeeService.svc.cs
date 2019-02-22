
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService;

namespace Project4_WCF.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.

    public class EmployeeService : IEmployeeService
    {
        DepartmentDBEntities tstDb = new DepartmentDBEntities();


        public int CreateEmployee(string Name, double Salary, string Address, string DepartmentName)
        {

            try
            {
                Employee emp = new Employee();
                emp.Name = Name;
                emp.Salary = Salary;
                emp.Address = Address;
                emp.DepartmentID = tstDb.Departments.First(a => a.DepartmentName == DepartmentName).DepartmentID;
                tstDb.Employees.Add(emp);
                int Retval = tstDb.SaveChanges();
                return Retval;
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int DeleteEmployeeById(int ID)
        {
            try { 
            Employee emp = new Employee();
            emp.ID = ID;
            tstDb.Entry(emp).State = EntityState.Deleted;
            int Retval = tstDb.SaveChanges();

            return Retval;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
        

        public List<EmployeeDTO> GetAllEmployees()
        {
            try
            {
                List<EmployeeDTO> sendList = new List<EmployeeDTO>();

                var employList = from k in tstDb.Employees select k;
                foreach( var item in employList)
                {
                    EmployeeDTO emp = new EmployeeDTO();
                    emp.ID = item.ID;
                    emp.Name = item.Name;
                    emp.Salary = item.Salary;
                    emp.Address = item.Address;
                    emp.DepartmentName = item.Department.DepartmentName;

                    sendList.Add(emp);
                }
                return sendList;   
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
        public EmployeeDTO GetEmployeeById(int ID)
        {
            var employList = from k in tstDb.Employees where k.ID == ID select k;
            EmployeeDTO emp = new EmployeeDTO();
            foreach (var item in employList)
            {
                emp.ID = item.ID;
                emp.Name = item.Name;
                emp.Salary = item.Salary;
                emp.Address = item.Address;
                emp.DepartmentName = item.Department.DepartmentName;
            }

            return emp;

        }
        public int UpdateEmployee(int ID, string Name, double Salary, string Address, string DepartmentName)
        {
            try
            {
                Employee emp = new Employee();
                emp.ID = ID;
                emp.Name = Name;
                emp.Salary = Salary;
                emp.Address = Address;
                emp.DepartmentID = tstDb.Departments.First(a => a.DepartmentName == DepartmentName).DepartmentID;
                tstDb.Entry(emp).State = EntityState.Modified;
                int Retval = tstDb.SaveChanges();
                return Retval;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
