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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace NoisePollution.LBHLicensingAPP {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendSRToCivicaAppOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendSRToCivicaAppExOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSRListOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateContactLARNOperationCompleted;
        
        private System.Threading.SendOrPostCallback MergeAndSendXMLToAPPOperationCompleted;
        
        private System.Threading.SendOrPostCallback TestOperationCompleted;
        
        private System.Threading.SendOrPostCallback GeneratePdfOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::NoisePollution.Properties.Settings.Default.NoisePollution_LBHLicensingAPP_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SendSRToCivicaAppCompletedEventHandler SendSRToCivicaAppCompleted;
        
        /// <remarks/>
        public event SendSRToCivicaAppExCompletedEventHandler SendSRToCivicaAppExCompleted;
        
        /// <remarks/>
        public event GetSRListCompletedEventHandler GetSRListCompleted;
        
        /// <remarks/>
        public event UpdateContactLARNCompletedEventHandler UpdateContactLARNCompleted;
        
        /// <remarks/>
        public event MergeAndSendXMLToAPPCompletedEventHandler MergeAndSendXMLToAPPCompleted;
        
        /// <remarks/>
        public event TestCompletedEventHandler TestCompleted;
        
        /// <remarks/>
        public event GeneratePdfCompletedEventHandler GeneratePdfCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendSRToCivicaApp", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response SendSRToCivicaApp(string TicketNumber, string TemplateName) {
            object[] results = this.Invoke("SendSRToCivicaApp", new object[] {
                        TicketNumber,
                        TemplateName});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void SendSRToCivicaAppAsync(string TicketNumber, string TemplateName) {
            this.SendSRToCivicaAppAsync(TicketNumber, TemplateName, null);
        }
        
        /// <remarks/>
        public void SendSRToCivicaAppAsync(string TicketNumber, string TemplateName, object userState) {
            if ((this.SendSRToCivicaAppOperationCompleted == null)) {
                this.SendSRToCivicaAppOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSRToCivicaAppOperationCompleted);
            }
            this.InvokeAsync("SendSRToCivicaApp", new object[] {
                        TicketNumber,
                        TemplateName}, this.SendSRToCivicaAppOperationCompleted, userState);
        }
        
        private void OnSendSRToCivicaAppOperationCompleted(object arg) {
            if ((this.SendSRToCivicaAppCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendSRToCivicaAppCompleted(this, new SendSRToCivicaAppCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendSRToCivicaAppEx", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response SendSRToCivicaAppEx(string TicketNumber) {
            object[] results = this.Invoke("SendSRToCivicaAppEx", new object[] {
                        TicketNumber});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void SendSRToCivicaAppExAsync(string TicketNumber) {
            this.SendSRToCivicaAppExAsync(TicketNumber, null);
        }
        
        /// <remarks/>
        public void SendSRToCivicaAppExAsync(string TicketNumber, object userState) {
            if ((this.SendSRToCivicaAppExOperationCompleted == null)) {
                this.SendSRToCivicaAppExOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSRToCivicaAppExOperationCompleted);
            }
            this.InvokeAsync("SendSRToCivicaAppEx", new object[] {
                        TicketNumber}, this.SendSRToCivicaAppExOperationCompleted, userState);
        }
        
        private void OnSendSRToCivicaAppExOperationCompleted(object arg) {
            if ((this.SendSRToCivicaAppExCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendSRToCivicaAppExCompleted(this, new SendSRToCivicaAppExCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSRList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CivicaAppSR[] GetSRList(string strCrmCategory, string strCivicaCategory) {
            object[] results = this.Invoke("GetSRList", new object[] {
                        strCrmCategory,
                        strCivicaCategory});
            return ((CivicaAppSR[])(results[0]));
        }
        
        /// <remarks/>
        public void GetSRListAsync(string strCrmCategory, string strCivicaCategory) {
            this.GetSRListAsync(strCrmCategory, strCivicaCategory, null);
        }
        
        /// <remarks/>
        public void GetSRListAsync(string strCrmCategory, string strCivicaCategory, object userState) {
            if ((this.GetSRListOperationCompleted == null)) {
                this.GetSRListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSRListOperationCompleted);
            }
            this.InvokeAsync("GetSRList", new object[] {
                        strCrmCategory,
                        strCivicaCategory}, this.GetSRListOperationCompleted, userState);
        }
        
        private void OnGetSRListOperationCompleted(object arg) {
            if ((this.GetSRListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSRListCompleted(this, new GetSRListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateContactLARN", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateContactLARN(string strLARN, string strCivicaAPPId, string strFirstName, string strLastName) {
            object[] results = this.Invoke("UpdateContactLARN", new object[] {
                        strLARN,
                        strCivicaAPPId,
                        strFirstName,
                        strLastName});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateContactLARNAsync(string strLARN, string strCivicaAPPId, string strFirstName, string strLastName) {
            this.UpdateContactLARNAsync(strLARN, strCivicaAPPId, strFirstName, strLastName, null);
        }
        
        /// <remarks/>
        public void UpdateContactLARNAsync(string strLARN, string strCivicaAPPId, string strFirstName, string strLastName, object userState) {
            if ((this.UpdateContactLARNOperationCompleted == null)) {
                this.UpdateContactLARNOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateContactLARNOperationCompleted);
            }
            this.InvokeAsync("UpdateContactLARN", new object[] {
                        strLARN,
                        strCivicaAPPId,
                        strFirstName,
                        strLastName}, this.UpdateContactLARNOperationCompleted, userState);
        }
        
        private void OnUpdateContactLARNOperationCompleted(object arg) {
            if ((this.UpdateContactLARNCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateContactLARNCompleted(this, new UpdateContactLARNCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MergeAndSendXMLToAPP", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response MergeAndSendXMLToAPP(string strProjName, string strXML, string strTemplateFilename) {
            object[] results = this.Invoke("MergeAndSendXMLToAPP", new object[] {
                        strProjName,
                        strXML,
                        strTemplateFilename});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void MergeAndSendXMLToAPPAsync(string strProjName, string strXML, string strTemplateFilename) {
            this.MergeAndSendXMLToAPPAsync(strProjName, strXML, strTemplateFilename, null);
        }
        
        /// <remarks/>
        public void MergeAndSendXMLToAPPAsync(string strProjName, string strXML, string strTemplateFilename, object userState) {
            if ((this.MergeAndSendXMLToAPPOperationCompleted == null)) {
                this.MergeAndSendXMLToAPPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMergeAndSendXMLToAPPOperationCompleted);
            }
            this.InvokeAsync("MergeAndSendXMLToAPP", new object[] {
                        strProjName,
                        strXML,
                        strTemplateFilename}, this.MergeAndSendXMLToAPPOperationCompleted, userState);
        }
        
        private void OnMergeAndSendXMLToAPPOperationCompleted(object arg) {
            if ((this.MergeAndSendXMLToAPPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MergeAndSendXMLToAPPCompleted(this, new MergeAndSendXMLToAPPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Test", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Test(string strInput) {
            object[] results = this.Invoke("Test", new object[] {
                        strInput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void TestAsync(string strInput) {
            this.TestAsync(strInput, null);
        }
        
        /// <remarks/>
        public void TestAsync(string strInput, object userState) {
            if ((this.TestOperationCompleted == null)) {
                this.TestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTestOperationCompleted);
            }
            this.InvokeAsync("Test", new object[] {
                        strInput}, this.TestOperationCompleted, userState);
        }
        
        private void OnTestOperationCompleted(object arg) {
            if ((this.TestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TestCompleted(this, new TestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GeneratePdf", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response GeneratePdf(string TicketNumber) {
            object[] results = this.Invoke("GeneratePdf", new object[] {
                        TicketNumber});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void GeneratePdfAsync(string TicketNumber) {
            this.GeneratePdfAsync(TicketNumber, null);
        }
        
        /// <remarks/>
        public void GeneratePdfAsync(string TicketNumber, object userState) {
            if ((this.GeneratePdfOperationCompleted == null)) {
                this.GeneratePdfOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGeneratePdfOperationCompleted);
            }
            this.InvokeAsync("GeneratePdf", new object[] {
                        TicketNumber}, this.GeneratePdfOperationCompleted, userState);
        }
        
        private void OnGeneratePdfOperationCompleted(object arg) {
            if ((this.GeneratePdfCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GeneratePdfCompleted(this, new GeneratePdfCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Response {
        
        private int errorCodeField;
        
        private string debugInfoField;
        
        private string failureReasonField;
        
        private string returnValueField;
        
        /// <remarks/>
        public int ErrorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DebugInfo {
            get {
                return this.debugInfoField;
            }
            set {
                this.debugInfoField = value;
            }
        }
        
        /// <remarks/>
        public string FailureReason {
            get {
                return this.failureReasonField;
            }
            set {
                this.failureReasonField = value;
            }
        }
        
        /// <remarks/>
        public string ReturnValue {
            get {
                return this.returnValueField;
            }
            set {
                this.returnValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CivicaAppSR {
        
        private string eastingField;
        
        private string northingField;
        
        private double latitudeField;
        
        private double longitudeField;
        
        private System.DateTime dateCreatedField;
        
        private string titleField;
        
        private string descriptionField;
        
        /// <remarks/>
        public string Easting {
            get {
                return this.eastingField;
            }
            set {
                this.eastingField = value;
            }
        }
        
        /// <remarks/>
        public string Northing {
            get {
                return this.northingField;
            }
            set {
                this.northingField = value;
            }
        }
        
        /// <remarks/>
        public double Latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        public double Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void SendSRToCivicaAppCompletedEventHandler(object sender, SendSRToCivicaAppCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendSRToCivicaAppCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendSRToCivicaAppCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void SendSRToCivicaAppExCompletedEventHandler(object sender, SendSRToCivicaAppExCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendSRToCivicaAppExCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendSRToCivicaAppExCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void GetSRListCompletedEventHandler(object sender, GetSRListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSRListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSRListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CivicaAppSR[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CivicaAppSR[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void UpdateContactLARNCompletedEventHandler(object sender, UpdateContactLARNCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateContactLARNCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateContactLARNCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void MergeAndSendXMLToAPPCompletedEventHandler(object sender, MergeAndSendXMLToAPPCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MergeAndSendXMLToAPPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MergeAndSendXMLToAPPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void TestCompletedEventHandler(object sender, TestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void GeneratePdfCompletedEventHandler(object sender, GeneratePdfCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GeneratePdfCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GeneratePdfCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591