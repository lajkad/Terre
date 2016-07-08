﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace ProjectNice.SendFeedbackMenssageService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SendFeedbackMenssageService.FeedbackSoap")]
    public interface FeedbackSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendFeedbackEmail", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailResponse> SendFeedbackEmailAsync(ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendFeedbackEmailRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendFeedbackEmail", Namespace="http://tempuri.org/", Order=0)]
        public ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailRequestBody Body;
        
        public SendFeedbackEmailRequest() {
        }
        
        public SendFeedbackEmailRequest(ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendFeedbackEmailRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xProject;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string xMenssage;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string xMail;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string xSubject;
        
        public SendFeedbackEmailRequestBody() {
        }
        
        public SendFeedbackEmailRequestBody(string xProject, string xMenssage, string xMail, string xSubject) {
            this.xProject = xProject;
            this.xMenssage = xMenssage;
            this.xMail = xMail;
            this.xSubject = xSubject;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendFeedbackEmailResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendFeedbackEmailResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailResponseBody Body;
        
        public SendFeedbackEmailResponse() {
        }
        
        public SendFeedbackEmailResponse(ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SendFeedbackEmailResponseBody {
        
        public SendFeedbackEmailResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FeedbackSoapChannel : ProjectNice.SendFeedbackMenssageService.FeedbackSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FeedbackSoapClient : System.ServiceModel.ClientBase<ProjectNice.SendFeedbackMenssageService.FeedbackSoap>, ProjectNice.SendFeedbackMenssageService.FeedbackSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FeedbackSoapClient() : 
                base(FeedbackSoapClient.GetDefaultBinding(), FeedbackSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.FeedbackSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FeedbackSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(FeedbackSoapClient.GetBindingForEndpoint(endpointConfiguration), FeedbackSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FeedbackSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FeedbackSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FeedbackSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FeedbackSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FeedbackSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailResponse> ProjectNice.SendFeedbackMenssageService.FeedbackSoap.SendFeedbackEmailAsync(ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailRequest request) {
            return base.Channel.SendFeedbackEmailAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailResponse> SendFeedbackEmailAsync(string xProject, string xMenssage, string xMail, string xSubject) {
            ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailRequest inValue = new ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailRequest();
            inValue.Body = new ProjectNice.SendFeedbackMenssageService.SendFeedbackEmailRequestBody();
            inValue.Body.xProject = xProject;
            inValue.Body.xMenssage = xMenssage;
            inValue.Body.xMail = xMail;
            inValue.Body.xSubject = xSubject;
            return ((ProjectNice.SendFeedbackMenssageService.FeedbackSoap)(this)).SendFeedbackEmailAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.FeedbackSoap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.FeedbackSoap)) {
                return new System.ServiceModel.EndpointAddress("http://vtnorton.com/Services/Feedback.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return FeedbackSoapClient.GetBindingForEndpoint(EndpointConfiguration.FeedbackSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return FeedbackSoapClient.GetEndpointAddress(EndpointConfiguration.FeedbackSoap);
        }
        
        public enum EndpointConfiguration {
            
            FeedbackSoap,
        }
    }
}
