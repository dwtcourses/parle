﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OperatorConsole.OperatorServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OperatorEntity", Namespace="http://schemas.datacontract.org/2004/07/LiveChat.Entities")]
    [System.SerializableAttribute()]
    public partial class OperatorEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsOnlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public int EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((this.EntityIdField.Equals(value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOnline {
            get {
                return this.IsOnlineField;
            }
            set {
                if ((this.IsOnlineField.Equals(value) != true)) {
                    this.IsOnlineField = value;
                    this.RaisePropertyChanged("IsOnline");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChannelEntity", Namespace="http://schemas.datacontract.org/2004/07/LiveChat.Entities")]
    [System.SerializableAttribute()]
    public partial class ChannelEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> AcceptDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CloseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OpenDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OperatorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RequestIdField;
        
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
        public System.Nullable<System.DateTime> AcceptDate {
            get {
                return this.AcceptDateField;
            }
            set {
                if ((this.AcceptDateField.Equals(value) != true)) {
                    this.AcceptDateField = value;
                    this.RaisePropertyChanged("AcceptDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CloseDate {
            get {
                return this.CloseDateField;
            }
            set {
                if ((this.CloseDateField.Equals(value) != true)) {
                    this.CloseDateField = value;
                    this.RaisePropertyChanged("CloseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityIdField, value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OpenDate {
            get {
                return this.OpenDateField;
            }
            set {
                if ((this.OpenDateField.Equals(value) != true)) {
                    this.OpenDateField = value;
                    this.RaisePropertyChanged("OpenDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OperatorId {
            get {
                return this.OperatorIdField;
            }
            set {
                if ((this.OperatorIdField.Equals(value) != true)) {
                    this.OperatorIdField = value;
                    this.RaisePropertyChanged("OperatorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RequestId {
            get {
                return this.RequestIdField;
            }
            set {
                if ((this.RequestIdField.Equals(value) != true)) {
                    this.RequestIdField = value;
                    this.RaisePropertyChanged("RequestId");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentEntity", Namespace="http://schemas.datacontract.org/2004/07/LiveChat.Entities")]
    [System.SerializableAttribute()]
    public partial class DepartmentEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
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
        public int EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((this.EntityIdField.Equals(value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OperatorServiceReference.IOperator")]
    public interface IOperator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/GetOnlineOperator", ReplyAction="http://tempuri.org/IOperator/GetOnlineOperatorResponse")]
        OperatorConsole.OperatorServiceReference.OperatorEntity[] GetOnlineOperator();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/IsOperatorOnline", ReplyAction="http://tempuri.org/IOperator/IsOperatorOnlineResponse")]
        bool IsOperatorOnline();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/Create", ReplyAction="http://tempuri.org/IOperator/CreateResponse")]
        int Create(string name, string password, string email, bool isAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/UpdateStatus", ReplyAction="http://tempuri.org/IOperator/UpdateStatusResponse")]
        void UpdateStatus(int operatorId, bool isOnline);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/LogIn", ReplyAction="http://tempuri.org/IOperator/LogInResponse")]
        OperatorConsole.OperatorServiceReference.OperatorEntity LogIn(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/Remove", ReplyAction="http://tempuri.org/IOperator/RemoveResponse")]
        bool Remove(int operatorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/GetChatChannel", ReplyAction="http://tempuri.org/IOperator/GetChatChannelResponse")]
        OperatorConsole.OperatorServiceReference.ChannelEntity[] GetChatChannel(int operatorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/GetOnlineDepartment", ReplyAction="http://tempuri.org/IOperator/GetOnlineDepartmentResponse")]
        OperatorConsole.OperatorServiceReference.DepartmentEntity[] GetOnlineDepartment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/Fetch", ReplyAction="http://tempuri.org/IOperator/FetchResponse")]
        OperatorConsole.OperatorServiceReference.OperatorEntity[] Fetch();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/Save", ReplyAction="http://tempuri.org/IOperator/SaveResponse")]
        bool Save(OperatorConsole.OperatorServiceReference.OperatorEntity updatedEntity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/FetchDepartment", ReplyAction="http://tempuri.org/IOperator/FetchDepartmentResponse")]
        OperatorConsole.OperatorServiceReference.DepartmentEntity[] FetchDepartment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/CreateDepartment", ReplyAction="http://tempuri.org/IOperator/CreateDepartmentResponse")]
        int CreateDepartment(string departmentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/RemoveDepartment", ReplyAction="http://tempuri.org/IOperator/RemoveDepartmentResponse")]
        bool RemoveDepartment(int departmentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/AddOperatorToDepartment", ReplyAction="http://tempuri.org/IOperator/AddOperatorToDepartmentResponse")]
        bool AddOperatorToDepartment(int departmentId, int operatorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/RemoveOperatorFromDepartment", ReplyAction="http://tempuri.org/IOperator/RemoveOperatorFromDepartmentResponse")]
        bool RemoveOperatorFromDepartment(int departmentId, int operatoriId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperator/GetOperator", ReplyAction="http://tempuri.org/IOperator/GetOperatorResponse")]
        OperatorConsole.OperatorServiceReference.OperatorEntity[] GetOperator(int departmentId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IOperatorChannel : OperatorConsole.OperatorServiceReference.IOperator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class OperatorClient : System.ServiceModel.ClientBase<OperatorConsole.OperatorServiceReference.IOperator>, OperatorConsole.OperatorServiceReference.IOperator {
        
        public OperatorClient() {
        }
        
        public OperatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OperatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OperatorConsole.OperatorServiceReference.OperatorEntity[] GetOnlineOperator() {
            return base.Channel.GetOnlineOperator();
        }
        
        public bool IsOperatorOnline() {
            return base.Channel.IsOperatorOnline();
        }
        
        public int Create(string name, string password, string email, bool isAdmin) {
            return base.Channel.Create(name, password, email, isAdmin);
        }
        
        public void UpdateStatus(int operatorId, bool isOnline) {
            base.Channel.UpdateStatus(operatorId, isOnline);
        }
        
        public OperatorConsole.OperatorServiceReference.OperatorEntity LogIn(string name, string password) {
            return base.Channel.LogIn(name, password);
        }
        
        public bool Remove(int operatorId) {
            return base.Channel.Remove(operatorId);
        }
        
        public OperatorConsole.OperatorServiceReference.ChannelEntity[] GetChatChannel(int operatorId) {
            return base.Channel.GetChatChannel(operatorId);
        }
        
        public OperatorConsole.OperatorServiceReference.DepartmentEntity[] GetOnlineDepartment() {
            return base.Channel.GetOnlineDepartment();
        }
        
        public OperatorConsole.OperatorServiceReference.OperatorEntity[] Fetch() {
            return base.Channel.Fetch();
        }
        
        public bool Save(OperatorConsole.OperatorServiceReference.OperatorEntity updatedEntity) {
            return base.Channel.Save(updatedEntity);
        }
        
        public OperatorConsole.OperatorServiceReference.DepartmentEntity[] FetchDepartment() {
            return base.Channel.FetchDepartment();
        }
        
        public int CreateDepartment(string departmentName) {
            return base.Channel.CreateDepartment(departmentName);
        }
        
        public bool RemoveDepartment(int departmentId) {
            return base.Channel.RemoveDepartment(departmentId);
        }
        
        public bool AddOperatorToDepartment(int departmentId, int operatorId) {
            return base.Channel.AddOperatorToDepartment(departmentId, operatorId);
        }
        
        public bool RemoveOperatorFromDepartment(int departmentId, int operatoriId) {
            return base.Channel.RemoveOperatorFromDepartment(departmentId, operatoriId);
        }
        
        public OperatorConsole.OperatorServiceReference.OperatorEntity[] GetOperator(int departmentId) {
            return base.Channel.GetOperator(departmentId);
        }
    }
}
