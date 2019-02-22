﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfMVC.DepartmentServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DepartmentServiceReference.IDepartmentService")]
    public interface IDepartmentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/GetAllDepartments", ReplyAction="http://tempuri.org/IDepartmentService/GetAllDepartmentsResponse")]
        Project4_WCF.DepartmentDTO[] GetAllDepartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/GetAllDepartments", ReplyAction="http://tempuri.org/IDepartmentService/GetAllDepartmentsResponse")]
        System.Threading.Tasks.Task<Project4_WCF.DepartmentDTO[]> GetAllDepartmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/CreateDepartment", ReplyAction="http://tempuri.org/IDepartmentService/CreateDepartmentResponse")]
        int CreateDepartment(string Name, double Salary, string Address, string DepartmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/CreateDepartment", ReplyAction="http://tempuri.org/IDepartmentService/CreateDepartmentResponse")]
        System.Threading.Tasks.Task<int> CreateDepartmentAsync(string Name, double Salary, string Address, string DepartmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/UpdateDepartment", ReplyAction="http://tempuri.org/IDepartmentService/UpdateDepartmentResponse")]
        int UpdateDepartment(string Name, double Salary, string Address, string DepartmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/UpdateDepartment", ReplyAction="http://tempuri.org/IDepartmentService/UpdateDepartmentResponse")]
        System.Threading.Tasks.Task<int> UpdateDepartmentAsync(string Name, double Salary, string Address, string DepartmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/DeleteDepartmentById", ReplyAction="http://tempuri.org/IDepartmentService/DeleteDepartmentByIdResponse")]
        int DeleteDepartmentById(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/DeleteDepartmentById", ReplyAction="http://tempuri.org/IDepartmentService/DeleteDepartmentByIdResponse")]
        System.Threading.Tasks.Task<int> DeleteDepartmentByIdAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/GetAllDepartmentNames", ReplyAction="http://tempuri.org/IDepartmentService/GetAllDepartmentNamesResponse")]
        string[] GetAllDepartmentNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/GetAllDepartmentNames", ReplyAction="http://tempuri.org/IDepartmentService/GetAllDepartmentNamesResponse")]
        System.Threading.Tasks.Task<string[]> GetAllDepartmentNamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/GetDepartmentNamesByPrefix", ReplyAction="http://tempuri.org/IDepartmentService/GetDepartmentNamesByPrefixResponse")]
        string[] GetDepartmentNamesByPrefix(string Prefix);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartmentService/GetDepartmentNamesByPrefix", ReplyAction="http://tempuri.org/IDepartmentService/GetDepartmentNamesByPrefixResponse")]
        System.Threading.Tasks.Task<string[]> GetDepartmentNamesByPrefixAsync(string Prefix);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDepartmentServiceChannel : WcfMVC.DepartmentServiceReference.IDepartmentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DepartmentServiceClient : System.ServiceModel.ClientBase<WcfMVC.DepartmentServiceReference.IDepartmentService>, WcfMVC.DepartmentServiceReference.IDepartmentService {
        
        public DepartmentServiceClient() {
        }
        
        public DepartmentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DepartmentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepartmentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepartmentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Project4_WCF.DepartmentDTO[] GetAllDepartments() {
            return base.Channel.GetAllDepartments();
        }
        
        public System.Threading.Tasks.Task<Project4_WCF.DepartmentDTO[]> GetAllDepartmentsAsync() {
            return base.Channel.GetAllDepartmentsAsync();
        }
        
        public int CreateDepartment(string Name, double Salary, string Address, string DepartmentName) {
            return base.Channel.CreateDepartment(Name, Salary, Address, DepartmentName);
        }
        
        public System.Threading.Tasks.Task<int> CreateDepartmentAsync(string Name, double Salary, string Address, string DepartmentName) {
            return base.Channel.CreateDepartmentAsync(Name, Salary, Address, DepartmentName);
        }
        
        public int UpdateDepartment(string Name, double Salary, string Address, string DepartmentName) {
            return base.Channel.UpdateDepartment(Name, Salary, Address, DepartmentName);
        }
        
        public System.Threading.Tasks.Task<int> UpdateDepartmentAsync(string Name, double Salary, string Address, string DepartmentName) {
            return base.Channel.UpdateDepartmentAsync(Name, Salary, Address, DepartmentName);
        }
        
        public int DeleteDepartmentById(int ID) {
            return base.Channel.DeleteDepartmentById(ID);
        }
        
        public System.Threading.Tasks.Task<int> DeleteDepartmentByIdAsync(int ID) {
            return base.Channel.DeleteDepartmentByIdAsync(ID);
        }
        
        public string[] GetAllDepartmentNames() {
            return base.Channel.GetAllDepartmentNames();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllDepartmentNamesAsync() {
            return base.Channel.GetAllDepartmentNamesAsync();
        }
        
        public string[] GetDepartmentNamesByPrefix(string Prefix) {
            return base.Channel.GetDepartmentNamesByPrefix(Prefix);
        }
        
        public System.Threading.Tasks.Task<string[]> GetDepartmentNamesByPrefixAsync(string Prefix) {
            return base.Channel.GetDepartmentNamesByPrefixAsync(Prefix);
        }
    }
}