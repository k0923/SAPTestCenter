﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAPLogonClient.AccountService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/SAPLogonService.Model")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SAPLogonClient.AccountService.AccountUser[] AcctUsersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BusinessUnitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ManagerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NTAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhotoUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public SAPLogonClient.AccountService.AccountUser[] AcctUsers {
            get {
                return this.AcctUsersField;
            }
            set {
                if ((object.ReferenceEquals(this.AcctUsersField, value) != true)) {
                    this.AcctUsersField = value;
                    this.RaisePropertyChanged("AcctUsers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BusinessUnit {
            get {
                return this.BusinessUnitField;
            }
            set {
                if ((object.ReferenceEquals(this.BusinessUnitField, value) != true)) {
                    this.BusinessUnitField = value;
                    this.RaisePropertyChanged("BusinessUnit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Manager {
            get {
                return this.ManagerField;
            }
            set {
                if ((object.ReferenceEquals(this.ManagerField, value) != true)) {
                    this.ManagerField = value;
                    this.RaisePropertyChanged("Manager");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NTAccount {
            get {
                return this.NTAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.NTAccountField, value) != true)) {
                    this.NTAccountField = value;
                    this.RaisePropertyChanged("NTAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhotoUrl {
            get {
                return this.PhotoUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoUrlField, value) != true)) {
                    this.PhotoUrlField = value;
                    this.RaisePropertyChanged("PhotoUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountUser", Namespace="http://schemas.datacontract.org/2004/07/SAPLogonService.Model")]
    [System.SerializableAttribute()]
    public partial class AccountUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SAPLogonClient.AccountService.Account AccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AcctIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAvailableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsOwnerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPrimaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SAPLogonClient.AccountService.User UserField;
        
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
        public SAPLogonClient.AccountService.Account Account {
            get {
                return this.AccountField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountField, value) != true)) {
                    this.AccountField = value;
                    this.RaisePropertyChanged("Account");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AcctId {
            get {
                return this.AcctIdField;
            }
            set {
                if ((this.AcctIdField.Equals(value) != true)) {
                    this.AcctIdField = value;
                    this.RaisePropertyChanged("AcctId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAvailable {
            get {
                return this.IsAvailableField;
            }
            set {
                if ((this.IsAvailableField.Equals(value) != true)) {
                    this.IsAvailableField = value;
                    this.RaisePropertyChanged("IsAvailable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOwner {
            get {
                return this.IsOwnerField;
            }
            set {
                if ((this.IsOwnerField.Equals(value) != true)) {
                    this.IsOwnerField = value;
                    this.RaisePropertyChanged("IsOwner");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPrimary {
            get {
                return this.IsPrimaryField;
            }
            set {
                if ((this.IsPrimaryField.Equals(value) != true)) {
                    this.IsPrimaryField = value;
                    this.RaisePropertyChanged("IsPrimary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Uid {
            get {
                return this.UidField;
            }
            set {
                if ((this.UidField.Equals(value) != true)) {
                    this.UidField = value;
                    this.RaisePropertyChanged("Uid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SAPLogonClient.AccountService.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/SAPLogonService.Model")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SAPLogonClient.AccountService.AccountUser[] AcctUsersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BoxIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAvailableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPublicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsWebLoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public SAPLogonClient.AccountService.AccountUser[] AcctUsers {
            get {
                return this.AcctUsersField;
            }
            set {
                if ((object.ReferenceEquals(this.AcctUsersField, value) != true)) {
                    this.AcctUsersField = value;
                    this.RaisePropertyChanged("AcctUsers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BoxId {
            get {
                return this.BoxIdField;
            }
            set {
                if ((object.ReferenceEquals(this.BoxIdField, value) != true)) {
                    this.BoxIdField = value;
                    this.RaisePropertyChanged("BoxId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Client {
            get {
                return this.ClientField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientField, value) != true)) {
                    this.ClientField = value;
                    this.RaisePropertyChanged("Client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAvailable {
            get {
                return this.IsAvailableField;
            }
            set {
                if ((this.IsAvailableField.Equals(value) != true)) {
                    this.IsAvailableField = value;
                    this.RaisePropertyChanged("IsAvailable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPublic {
            get {
                return this.IsPublicField;
            }
            set {
                if ((this.IsPublicField.Equals(value) != true)) {
                    this.IsPublicField = value;
                    this.RaisePropertyChanged("IsPublic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsWebLogin {
            get {
                return this.IsWebLoginField;
            }
            set {
                if ((this.IsWebLoginField.Equals(value) != true)) {
                    this.IsWebLoginField = value;
                    this.RaisePropertyChanged("IsWebLogin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Server {
            get {
                return this.ServerField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerField, value) != true)) {
                    this.ServerField = value;
                    this.RaisePropertyChanged("Server");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SAPBox", Namespace="http://schemas.datacontract.org/2004/07/SAPLogonService.Model")]
    [System.SerializableAttribute()]
    public partial class SAPBox : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BoxNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public string BoxName {
            get {
                return this.BoxNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BoxNameField, value) != true)) {
                    this.BoxNameField = value;
                    this.RaisePropertyChanged("BoxName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountService.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/RegisterUser", ReplyAction="http://tempuri.org/IAccountService/RegisterUserResponse")]
        void RegisterUser(SAPLogonClient.AccountService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/RegisterUser", ReplyAction="http://tempuri.org/IAccountService/RegisterUserResponse")]
        System.Threading.Tasks.Task RegisterUserAsync(SAPLogonClient.AccountService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccountUsers", ReplyAction="http://tempuri.org/IAccountService/GetAccountUsersResponse")]
        SAPLogonClient.AccountService.AccountUser[] GetAccountUsers(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccountUsers", ReplyAction="http://tempuri.org/IAccountService/GetAccountUsersResponse")]
        System.Threading.Tasks.Task<SAPLogonClient.AccountService.AccountUser[]> GetAccountUsersAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UserInfo", ReplyAction="http://tempuri.org/IAccountService/UserInfoResponse")]
        SAPLogonClient.AccountService.User UserInfo(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UserInfo", ReplyAction="http://tempuri.org/IAccountService/UserInfoResponse")]
        System.Threading.Tasks.Task<SAPLogonClient.AccountService.User> UserInfoAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsBoxExisted", ReplyAction="http://tempuri.org/IAccountService/IsBoxExistedResponse")]
        bool IsBoxExisted(string BoxName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/IsBoxExisted", ReplyAction="http://tempuri.org/IAccountService/IsBoxExistedResponse")]
        System.Threading.Tasks.Task<bool> IsBoxExistedAsync(string BoxName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/BoxInfo", ReplyAction="http://tempuri.org/IAccountService/BoxInfoResponse")]
        SAPLogonClient.AccountService.SAPBox[] BoxInfo(bool isRest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/BoxInfo", ReplyAction="http://tempuri.org/IAccountService/BoxInfoResponse")]
        System.Threading.Tasks.Task<SAPLogonClient.AccountService.SAPBox[]> BoxInfoAsync(bool isRest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/AccountInfoByName", ReplyAction="http://tempuri.org/IAccountService/AccountInfoByNameResponse")]
        SAPLogonClient.AccountService.Account AccountInfoByName(string name, string pc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/AccountInfoByName", ReplyAction="http://tempuri.org/IAccountService/AccountInfoByNameResponse")]
        System.Threading.Tasks.Task<SAPLogonClient.AccountService.Account> AccountInfoByNameAsync(string name, string pc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/AccountInfo", ReplyAction="http://tempuri.org/IAccountService/AccountInfoResponse")]
        SAPLogonClient.AccountService.Account AccountInfo(int id, string pc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/AccountInfo", ReplyAction="http://tempuri.org/IAccountService/AccountInfoResponse")]
        System.Threading.Tasks.Task<SAPLogonClient.AccountService.Account> AccountInfoAsync(int id, string pc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/AddLog", ReplyAction="http://tempuri.org/IAccountService/AddLogResponse")]
        string AddLog(int id, string pc, bool m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/AddLog", ReplyAction="http://tempuri.org/IAccountService/AddLogResponse")]
        System.Threading.Tasks.Task<string> AddLogAsync(int id, string pc, bool m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/MyAccounts", ReplyAction="http://tempuri.org/IAccountService/MyAccountsResponse")]
        SAPLogonClient.AccountService.Account[] MyAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/MyAccounts", ReplyAction="http://tempuri.org/IAccountService/MyAccountsResponse")]
        System.Threading.Tasks.Task<SAPLogonClient.AccountService.Account[]> MyAccountsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateAccount", ReplyAction="http://tempuri.org/IAccountService/UpdateAccountResponse")]
        bool UpdateAccount(string xmlData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateAccount", ReplyAction="http://tempuri.org/IAccountService/UpdateAccountResponse")]
        System.Threading.Tasks.Task<bool> UpdateAccountAsync(string xmlData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccess", ReplyAction="http://tempuri.org/IAccountService/GetAccessResponse")]
        bool GetAccess(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccess", ReplyAction="http://tempuri.org/IAccountService/GetAccessResponse")]
        System.Threading.Tasks.Task<bool> GetAccessAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/FailLogin", ReplyAction="http://tempuri.org/IAccountService/FailLoginResponse")]
        void FailLogin(SAPLogonClient.AccountService.Account acct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/FailLogin", ReplyAction="http://tempuri.org/IAccountService/FailLoginResponse")]
        System.Threading.Tasks.Task FailLoginAsync(SAPLogonClient.AccountService.Account acct);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : SAPLogonClient.AccountService.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<SAPLogonClient.AccountService.IAccountService>, SAPLogonClient.AccountService.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RegisterUser(SAPLogonClient.AccountService.User user) {
            base.Channel.RegisterUser(user);
        }
        
        public System.Threading.Tasks.Task RegisterUserAsync(SAPLogonClient.AccountService.User user) {
            return base.Channel.RegisterUserAsync(user);
        }
        
        public SAPLogonClient.AccountService.AccountUser[] GetAccountUsers(int id) {
            return base.Channel.GetAccountUsers(id);
        }
        
        public System.Threading.Tasks.Task<SAPLogonClient.AccountService.AccountUser[]> GetAccountUsersAsync(int id) {
            return base.Channel.GetAccountUsersAsync(id);
        }
        
        public SAPLogonClient.AccountService.User UserInfo(string email) {
            return base.Channel.UserInfo(email);
        }
        
        public System.Threading.Tasks.Task<SAPLogonClient.AccountService.User> UserInfoAsync(string email) {
            return base.Channel.UserInfoAsync(email);
        }
        
        public bool IsBoxExisted(string BoxName) {
            return base.Channel.IsBoxExisted(BoxName);
        }
        
        public System.Threading.Tasks.Task<bool> IsBoxExistedAsync(string BoxName) {
            return base.Channel.IsBoxExistedAsync(BoxName);
        }
        
        public SAPLogonClient.AccountService.SAPBox[] BoxInfo(bool isRest) {
            return base.Channel.BoxInfo(isRest);
        }
        
        public System.Threading.Tasks.Task<SAPLogonClient.AccountService.SAPBox[]> BoxInfoAsync(bool isRest) {
            return base.Channel.BoxInfoAsync(isRest);
        }
        
        public SAPLogonClient.AccountService.Account AccountInfoByName(string name, string pc) {
            return base.Channel.AccountInfoByName(name, pc);
        }
        
        public System.Threading.Tasks.Task<SAPLogonClient.AccountService.Account> AccountInfoByNameAsync(string name, string pc) {
            return base.Channel.AccountInfoByNameAsync(name, pc);
        }
        
        public SAPLogonClient.AccountService.Account AccountInfo(int id, string pc) {
            return base.Channel.AccountInfo(id, pc);
        }
        
        public System.Threading.Tasks.Task<SAPLogonClient.AccountService.Account> AccountInfoAsync(int id, string pc) {
            return base.Channel.AccountInfoAsync(id, pc);
        }
        
        public string AddLog(int id, string pc, bool m) {
            return base.Channel.AddLog(id, pc, m);
        }
        
        public System.Threading.Tasks.Task<string> AddLogAsync(int id, string pc, bool m) {
            return base.Channel.AddLogAsync(id, pc, m);
        }
        
        public SAPLogonClient.AccountService.Account[] MyAccounts() {
            return base.Channel.MyAccounts();
        }
        
        public System.Threading.Tasks.Task<SAPLogonClient.AccountService.Account[]> MyAccountsAsync() {
            return base.Channel.MyAccountsAsync();
        }
        
        public bool UpdateAccount(string xmlData) {
            return base.Channel.UpdateAccount(xmlData);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAccountAsync(string xmlData) {
            return base.Channel.UpdateAccountAsync(xmlData);
        }
        
        public bool GetAccess(int Id) {
            return base.Channel.GetAccess(Id);
        }
        
        public System.Threading.Tasks.Task<bool> GetAccessAsync(int Id) {
            return base.Channel.GetAccessAsync(Id);
        }
        
        public void FailLogin(SAPLogonClient.AccountService.Account acct) {
            base.Channel.FailLogin(acct);
        }
        
        public System.Threading.Tasks.Task FailLoginAsync(SAPLogonClient.AccountService.Account acct) {
            return base.Channel.FailLoginAsync(acct);
        }
    }
}
