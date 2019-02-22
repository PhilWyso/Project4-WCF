using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Project4_WCF
{
    [DataContract]
    public class EmployeeDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string DepartmentName { get; set; }
        [DataMember]
        public DepartmentDTO Department { get; set; }
    }
    [DataContract]
    public class DepartmentDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
