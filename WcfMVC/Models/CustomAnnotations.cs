using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WcfMVC.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class DepartmentValidator : ValidationAttribute
    {
        DepartmentServiceReference.DepartmentServiceClient ds = new DepartmentServiceReference.DepartmentServiceClient();
        public override bool IsValid(object value)
        {
           var Departments = ds.GetAllDepartmentNames();
           List<string> departmentNames = new List<string>();
            if (value == null)
            {
                return false;
            }
            string input = value.ToString();
            foreach (var item in Departments)
            {
                string name = item.ToString();
                departmentNames.Add(name);
            }

            if(departmentNames.Contains(input))
            {
                return true;
            } else
            {
                return false;
            }
         
        }

    }
}