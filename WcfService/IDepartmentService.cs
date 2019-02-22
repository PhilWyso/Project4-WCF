using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Project4_WCF.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDepartmentService
    {
        [OperationContract]
        List<DepartmentDTO> GetAllDepartments();
        [OperationContract]
        int CreateDepartment(string Name, double Salary, string Address, string DepartmentName);
        [OperationContract]
        int UpdateDepartment(string Name, double Salary, string Address, string DepartmentName);
        [OperationContract]
        int DeleteDepartmentById(int ID);
        [OperationContract]
        [WebGet]
        List<string> GetAllDepartmentNames();
        [OperationContract]
        List<string> GetDepartmentNamesByPrefix(string Prefix);
  
    }

}
