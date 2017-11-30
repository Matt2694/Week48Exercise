﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceValueChanger.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string[] GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string[]> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddData", ReplyAction="http://tempuri.org/IService/AddDataResponse")]
        void AddData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddData", ReplyAction="http://tempuri.org/IService/AddDataResponse")]
        System.Threading.Tasks.Task AddDataAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ServiceValueChanger.Service.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ServiceValueChanger.Service.IService>, ServiceValueChanger.Service.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<string[]> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public void AddData(string value) {
            base.Channel.AddData(value);
        }
        
        public System.Threading.Tasks.Task AddDataAsync(string value) {
            return base.Channel.AddDataAsync(value);
        }
    }
}
