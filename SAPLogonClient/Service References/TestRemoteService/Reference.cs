﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//namespace SAPLogonClient.TestRemoteService {
    
    
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
//    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestRemoteService.IRemoteExecutionService")]
//    public interface IRemoteExecutionService {
        
//        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteExecutionService/SendFile", ReplyAction="http://tempuri.org/IRemoteExecutionService/SendFileResponse")]
//        bool SendFile(TestRemote.File file);
        
//        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteExecutionService/SendFile", ReplyAction="http://tempuri.org/IRemoteExecutionService/SendFileResponse")]
//        System.Threading.Tasks.Task<bool> SendFileAsync(TestRemote.File file);
        
//        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteExecutionService/Run", ReplyAction="http://tempuri.org/IRemoteExecutionService/RunResponse")]
//        void Run(TestRemote.File file);
        
//        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteExecutionService/Run", ReplyAction="http://tempuri.org/IRemoteExecutionService/RunResponse")]
//        System.Threading.Tasks.Task RunAsync(TestRemote.File file);
//    }
    
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
//    public interface IRemoteExecutionServiceChannel : SAPLogonClient.TestRemoteService.IRemoteExecutionService, System.ServiceModel.IClientChannel {
//    }
    
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
//    public partial class RemoteExecutionServiceClient : System.ServiceModel.ClientBase<SAPLogonClient.TestRemoteService.IRemoteExecutionService>, SAPLogonClient.TestRemoteService.IRemoteExecutionService {
        
//        public RemoteExecutionServiceClient() {
//        }
        
//        public RemoteExecutionServiceClient(string endpointConfigurationName) : 
//                base(endpointConfigurationName) {
//        }
        
//        public RemoteExecutionServiceClient(string endpointConfigurationName, string remoteAddress) : 
//                base(endpointConfigurationName, remoteAddress) {
//        }
        
//        public RemoteExecutionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
//                base(endpointConfigurationName, remoteAddress) {
//        }
        
//        public RemoteExecutionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
//                base(binding, remoteAddress) {
//        }
        
//        public bool SendFile(TestRemote.File file) {
//            return base.Channel.SendFile(file);
//        }
        
//        public System.Threading.Tasks.Task<bool> SendFileAsync(TestRemote.File file) {
//            return base.Channel.SendFileAsync(file);
//        }
        
//        public void Run(TestRemote.File file) {
//            base.Channel.Run(file);
//        }
        
//        public System.Threading.Tasks.Task RunAsync(TestRemote.File file) {
//            return base.Channel.RunAsync(file);
//        }
//    }
//}
