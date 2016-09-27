﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace News24RESTTweets.News24Svc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tweet", Namespace="http://schemas.datacontract.org/2004/07/MyRESTService")]
    [System.SerializableAttribute()]
    public partial class Tweet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTimeOffset CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IconField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RelativeTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ScreenNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
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
        public System.DateTimeOffset CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Icon {
            get {
                return this.IconField;
            }
            set {
                if ((object.ReferenceEquals(this.IconField, value) != true)) {
                    this.IconField = value;
                    this.RaisePropertyChanged("Icon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        public string RelativeTime {
            get {
                return this.RelativeTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.RelativeTimeField, value) != true)) {
                    this.RelativeTimeField = value;
                    this.RaisePropertyChanged("RelativeTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ScreenName {
            get {
                return this.ScreenNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ScreenNameField, value) != true)) {
                    this.ScreenNameField = value;
                    this.RaisePropertyChanged("ScreenName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="News24Svc.INews24RESTService")]
    public interface INews24RESTService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INews24RESTService/GetTweets", ReplyAction="http://tempuri.org/INews24RESTService/GetTweetsResponse")]
        System.Collections.Generic.List<News24RESTTweets.News24Svc.Tweet> GetTweets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INews24RESTService/GetTweets", ReplyAction="http://tempuri.org/INews24RESTService/GetTweetsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<News24RESTTweets.News24Svc.Tweet>> GetTweetsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INews24RESTServiceChannel : News24RESTTweets.News24Svc.INews24RESTService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class News24RESTServiceClient : System.ServiceModel.ClientBase<News24RESTTweets.News24Svc.INews24RESTService>, News24RESTTweets.News24Svc.INews24RESTService {
        
        public News24RESTServiceClient() {
        }
        
        public News24RESTServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public News24RESTServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public News24RESTServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public News24RESTServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<News24RESTTweets.News24Svc.Tweet> GetTweets() {
            return base.Channel.GetTweets();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<News24RESTTweets.News24Svc.Tweet>> GetTweetsAsync() {
            return base.Channel.GetTweetsAsync();
        }
    }
}