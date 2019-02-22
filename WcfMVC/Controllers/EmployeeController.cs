using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfMVC.Models;

namespace WcfMVC.Controllers
{
    public class EmployeeController : Controller
    {
        DepartmentServiceReference.DepartmentServiceClient ds = new DepartmentServiceReference.DepartmentServiceClient();
        EmployeeServiceReference.EmployeeServiceClient ur = new EmployeeServiceReference.EmployeeServiceClient();
        public ActionResult Index()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            var listDTO = ur.GetAllEmployees();

            foreach (var item in listDTO)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.ID = item.ID;
                emp.Name = item.Name;
                emp.Salary = item.Salary;
                emp.Address = item.Address;
                emp.DepartmentName = item.DepartmentName;
                listEmp.Add(emp);
            }
            return View(listEmp);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel empModel)
        {
            if (ModelState.IsValid)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.Name = empModel.Name;
                emp.Salary = empModel.Salary;
                emp.Address = empModel.Address;
                emp.DepartmentName = empModel.DepartmentName;
                ur.CreateEmployee(emp.Name, emp.Salary, emp.Address, emp.DepartmentName);
                return RedirectToAction("Index", "Employee");
            }
            return View(empModel);
          
        }
        public ActionResult Delete(int ID)
        {
            int retval = ur.DeleteEmployeeById(ID);
            if (retval > 0)
            {
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }
        public ActionResult Edit(int ID)
        {
            var empDTO = ur.GetEmployeeById(ID);
            EmployeeModel emp = new EmployeeModel();
            emp.Name = empDTO.Name;
            emp.Salary = empDTO.Salary;
            emp.Address = empDTO.Address;
            emp.DepartmentName = empDTO.DepartmentName;
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit( EmployeeModel empEdits)
        {
            if (ModelState.IsValid) {
                EmployeeModel emp = new EmployeeModel();
                emp.ID = empEdits.ID;
                emp.Name = empEdits.Name;
                emp.Salary = empEdits.Salary;
                emp.Address = empEdits.Address;
                emp.DepartmentName = empEdits.DepartmentName;

                int Retval = ur.UpdateEmployee(emp.ID, emp.Name, emp.Salary, emp.Address, emp.DepartmentName);
                if (Retval > 0)
                {
                    return RedirectToAction("Index", "Employee");
                }
            }
            return View();
        }
        public ActionResult AutoComplete(string Prefix)
        {
           var Departments = ds.GetDepartmentNamesByPrefix(Prefix);
           List<string> departmentNames = new List<string>();
            foreach (var item in Departments)
            {
                string name = item.ToString();
                departmentNames.Add(name);
            }
            return Json(departmentNames, JsonRequestBehavior.AllowGet);
        }

    }
}