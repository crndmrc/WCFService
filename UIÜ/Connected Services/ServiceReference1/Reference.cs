//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UIÜ.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetName", ReplyAction="http://tempuri.org/IService/GetNameResponse")]
        string GetName(int _id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetName", ReplyAction="http://tempuri.org/IService/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync(int _id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTable", ReplyAction="http://tempuri.org/IService/GetTableResponse")]
        System.Data.DataTable GetTable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTable", ReplyAction="http://tempuri.org/IService/GetTableResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetTableAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : UIÜ.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<UIÜ.ServiceReference1.IService>, UIÜ.ServiceReference1.IService {
        
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
        
        public string GetName(int _id) {
            return base.Channel.GetName(_id);
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync(int _id) {
            return base.Channel.GetNameAsync(_id);
        }
        
        public System.Data.DataTable GetTable() {
            return base.Channel.GetTable();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetTableAsync() {
            return base.Channel.GetTableAsync();
        }
    }
}
