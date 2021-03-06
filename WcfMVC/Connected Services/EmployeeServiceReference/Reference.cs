﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfMVC.EmployeeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeDTO", Namespace="http://schemas.datacontract.org/2004/07/Project4_WCF")]
    [System.SerializableAttribute()]
    public partial class EmployeeDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfMVC.EmployeeServiceReference.DepartmentDTO DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SalaryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfMVC.EmployeeServiceReference.DepartmentDTO Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentDTO", Namespace="http://schemas.datacontract.org/2004/07/Project4_WCF")]
    [System.SerializableAttribute()]
    public partial class DepartmentDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetAllEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetAllEmployeesResponse")]
        WcfMVC.EmployeeServiceReference.EmployeeDTO[] GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetAllEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<WcfMVC.EmployeeServiceReference.EmployeeDTO[]> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByIdResponse")]
        WcfMVC.EmployeeServiceReference.EmployeeDTO GetEmployeeById(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<WcfMVC.EmployeeServiceReference.EmployeeDTO> GetEmployeeByIdAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/CreateEmployeeResponse")]
        int CreateEmployee(string Name, double Salary, string Address, string DepartmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/CreateEmployeeResponse")]
        System.Threading.Tasks.Task<int> CreateEmployeeAsync(string Name, double Salary, string Address, string DepartmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmployeeResponse")]
        int UpdateEmployee(int ID, string Name, double Salary, string Address, string DepartmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<int> UpdateEmployeeAsync(int ID, string Name, double Salary, string Address, string DepartmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/DeleteEmployeeById", ReplyAction="http://tempuri.org/IEmployeeService/DeleteEmployeeByIdResponse")]
        int DeleteEmployeeById(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/DeleteEmployeeById", ReplyAction="http://tempuri.org/IEmployeeService/DeleteEmployeeByIdResponse")]
        System.Threading.Tasks.Task<int> DeleteEmployeeByIdAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : WcfMVC.EmployeeServiceReference.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<WcfMVC.EmployeeServiceReference.IEmployeeService>, WcfMVC.EmployeeServiceReference.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfMVC.EmployeeServiceReference.EmployeeDTO[] GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<WcfMVC.EmployeeServiceReference.EmployeeDTO[]> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public WcfMVC.EmployeeServiceReference.EmployeeDTO GetEmployeeById(int ID) {
            return base.Channel.GetEmployeeById(ID);
        }
        
        public System.Threading.Tasks.Task<WcfMVC.EmployeeServiceReference.EmployeeDTO> GetEmployeeByIdAsync(int ID) {
            return base.Channel.GetEmployeeByIdAsync(ID);
        }
        
        public int CreateEmployee(string Name, double Salary, string Address, string DepartmentName) {
            return base.Channel.CreateEmployee(Name, Salary, Address, DepartmentName);
        }
        
        public System.Threading.Tasks.Task<int> CreateEmployeeAsync(string Name, double Salary, string Address, string DepartmentName) {
            return base.Channel.CreateEmployeeAsync(Name, Salary, Address, DepartmentName);
        }
        
        public int UpdateEmployee(int ID, string Name, double Salary, string Address, string DepartmentName) {
            return base.Channel.UpdateEmployee(ID, Name, Salary, Address, DepartmentName);
        }
        
        public System.Threading.Tasks.Task<int> UpdateEmployeeAsync(int ID, string Name, double Salary, string Address, string DepartmentName) {
            return base.Channel.UpdateEmployeeAsync(ID, Name, Salary, Address, DepartmentName);
        }
        
        public int DeleteEmployeeById(int ID) {
            return base.Channel.DeleteEmployeeById(ID);
        }
        
        public System.Threading.Tasks.Task<int> DeleteEmployeeByIdAsync(int ID) {
            return base.Channel.DeleteEmployeeByIdAsync(ID);
        }
    }
}
