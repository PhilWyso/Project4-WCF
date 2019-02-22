using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService;

namespace Project4_WCF.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DepartmentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DepartmentService.svc or DepartmentService.svc.cs at the Solution Explorer and start debugging.
    public class DepartmentService : IDepartmentService
    {
        DepartmentDBEntities tstDb = new DepartmentDBEntities();
        public int CreateDepartment(string Name, double Salary, string Address, string DepartmentName)
        {
            throw new NotImplementedException();
        }

        public int DeleteDepartmentById(int ID)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllDepartmentNames()
        {
            try
            {
                List<string> sendList = new List<string>();
                var departList = from k in tstDb.Departments select k.DepartmentName;

                foreach ( var item in departList)
                {
                    string name = item.ToString();
                    sendList.Add(name);
                }
                return sendList;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public List<DepartmentDTO> GetAllDepartments()
        {
            throw new NotImplementedException();
        }

        public List<string> GetDepartmentNamesByPrefix(string Prefix)
        {
            try
            {
                List<string> sendList = new List<string>();
                var departList = (from k in tstDb.Departments where k.DepartmentName.StartsWith(Prefix) select k.DepartmentName);

                foreach (var item in departList)
                {
                    string name = item.ToString();
                    sendList.Add(name);
                }
                return sendList;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int UpdateDepartment(string Name, double Salary, string Address, string DepartmentName)
        {
            throw new NotImplementedException();
        }
    }
}
