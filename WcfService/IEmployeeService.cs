using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Project4_WCF.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        List<EmployeeDTO> GetAllEmployees();
        [OperationContract]
        EmployeeDTO GetEmployeeById(int ID);
        [OperationContract]
        int CreateEmployee(string Name, double Salary, string Address, string DepartmentName);
        [OperationContract]
        int UpdateEmployee(int ID, string Name, double Salary, string Address, string DepartmentName);
        [OperationContract]
        int DeleteEmployeeById(int ID);
        
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Project4_WCF.ContractType".
}
