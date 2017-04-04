﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoggerClient.LoggerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoggerClient.LoggerService.SeverityLevel LevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
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
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LoggerClient.LoggerService.SeverityLevel Level {
            get {
                return this.LevelField;
            }
            set {
                if ((this.LevelField.Equals(value) != true)) {
                    this.LevelField = value;
                    this.RaisePropertyChanged("Level");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SeverityLevel", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    public enum SeverityLevel : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Debug = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warn = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Critical = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoggerService.ILoggerService")]
    public interface ILoggerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggerService/Log", ReplyAction="http://tempuri.org/ILoggerService/LogResponse")]
        void Log(LoggerClient.LoggerService.Message msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggerService/Log", ReplyAction="http://tempuri.org/ILoggerService/LogResponse")]
        System.Threading.Tasks.Task LogAsync(LoggerClient.LoggerService.Message msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoggerServiceChannel : LoggerClient.LoggerService.ILoggerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoggerServiceClient : System.ServiceModel.ClientBase<LoggerClient.LoggerService.ILoggerService>, LoggerClient.LoggerService.ILoggerService {
        
        public LoggerServiceClient() {
        }
        
        public LoggerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoggerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Log(LoggerClient.LoggerService.Message msg) {
            base.Channel.Log(msg);
        }
        
        public System.Threading.Tasks.Task LogAsync(LoggerClient.LoggerService.Message msg) {
            return base.Channel.LogAsync(msg);
        }
    }
}
