using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WcfMVC.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please Enter a Valid Salary")]
        public double Salary { get; set; }
        [Required]
        public string Address { get; set; }
        [DepartmentValidator(ErrorMessage = "Please Enter a Valid Department")]
        [Required]
        public string DepartmentName { get; set; }
    }
}