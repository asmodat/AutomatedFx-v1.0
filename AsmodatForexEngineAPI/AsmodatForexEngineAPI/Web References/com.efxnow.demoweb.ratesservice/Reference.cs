﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34003.
// 
#pragma warning disable 1591

namespace AsmodatForexEngineAPI.com.efxnow.demoweb.ratesservice {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="RatesServiceSoap", Namespace="www.GainCapital.com.WebServices")]
    public partial class RatesService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private Authenticator authenticatorValueField;
        
        private System.Threading.SendOrPostCallback getRateBlotterOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRatesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAnonymousRateBlotterOperationCompleted;
        
        private System.Threading.SendOrPostCallback getRateOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAnonymousRateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public RatesService() {
            this.Url = global::AsmodatForexEngineAPI.Properties.Settings.Default.AsmodatForexEngineAPI_com_efxnow_demoweb_RatesService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public Authenticator AuthenticatorValue {
            get {
                return this.authenticatorValueField;
            }
            set {
                this.authenticatorValueField = value;
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
        public event getRateBlotterCompletedEventHandler getRateBlotterCompleted;
        
        /// <remarks/>
        public event GetRatesCompletedEventHandler GetRatesCompleted;
        
        /// <remarks/>
        public event getAnonymousRateBlotterCompletedEventHandler getAnonymousRateBlotterCompleted;
        
        /// <remarks/>
        public event getRateCompletedEventHandler getRateCompleted;
        
        /// <remarks/>
        public event getAnonymousRateCompletedEventHandler getAnonymousRateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticatorValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.GainCapital.com.WebServices/getRateBlotter", RequestNamespace="www.GainCapital.com.WebServices", ResponseNamespace="www.GainCapital.com.WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getRateBlotter(string Token) {
            object[] results = this.Invoke("getRateBlotter", new object[] {
                        Token});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getRateBlotterAsync(string Token) {
            this.getRateBlotterAsync(Token, null);
        }
        
        /// <remarks/>
        public void getRateBlotterAsync(string Token, object userState) {
            if ((this.getRateBlotterOperationCompleted == null)) {
                this.getRateBlotterOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRateBlotterOperationCompleted);
            }
            this.InvokeAsync("getRateBlotter", new object[] {
                        Token}, this.getRateBlotterOperationCompleted, userState);
        }
        
        private void OngetRateBlotterOperationCompleted(object arg) {
            if ((this.getRateBlotterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getRateBlotterCompleted(this, new getRateBlotterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticatorValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.GainCapital.com.WebServices/GetRates", RequestNamespace="www.GainCapital.com.WebServices", ResponseNamespace="www.GainCapital.com.WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRates(string Token, bool IBRates, long Keyvalue, CollectionOfInt32 currencygroup) {
            object[] results = this.Invoke("GetRates", new object[] {
                        Token,
                        IBRates,
                        Keyvalue,
                        currencygroup});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetRatesAsync(string Token, bool IBRates, long Keyvalue, CollectionOfInt32 currencygroup) {
            this.GetRatesAsync(Token, IBRates, Keyvalue, currencygroup, null);
        }
        
        /// <remarks/>
        public void GetRatesAsync(string Token, bool IBRates, long Keyvalue, CollectionOfInt32 currencygroup, object userState) {
            if ((this.GetRatesOperationCompleted == null)) {
                this.GetRatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRatesOperationCompleted);
            }
            this.InvokeAsync("GetRates", new object[] {
                        Token,
                        IBRates,
                        Keyvalue,
                        currencygroup}, this.GetRatesOperationCompleted, userState);
        }
        
        private void OnGetRatesOperationCompleted(object arg) {
            if ((this.GetRatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRatesCompleted(this, new GetRatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticatorValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.GainCapital.com.WebServices/getAnonymousRateBlotter", RequestNamespace="www.GainCapital.com.WebServices", ResponseNamespace="www.GainCapital.com.WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAnonymousRateBlotter(string Token, bool IBRates, long Keyvalue, int currencygroup) {
            object[] results = this.Invoke("getAnonymousRateBlotter", new object[] {
                        Token,
                        IBRates,
                        Keyvalue,
                        currencygroup});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAnonymousRateBlotterAsync(string Token, bool IBRates, long Keyvalue, int currencygroup) {
            this.getAnonymousRateBlotterAsync(Token, IBRates, Keyvalue, currencygroup, null);
        }
        
        /// <remarks/>
        public void getAnonymousRateBlotterAsync(string Token, bool IBRates, long Keyvalue, int currencygroup, object userState) {
            if ((this.getAnonymousRateBlotterOperationCompleted == null)) {
                this.getAnonymousRateBlotterOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAnonymousRateBlotterOperationCompleted);
            }
            this.InvokeAsync("getAnonymousRateBlotter", new object[] {
                        Token,
                        IBRates,
                        Keyvalue,
                        currencygroup}, this.getAnonymousRateBlotterOperationCompleted, userState);
        }
        
        private void OngetAnonymousRateBlotterOperationCompleted(object arg) {
            if ((this.getAnonymousRateBlotterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAnonymousRateBlotterCompleted(this, new getAnonymousRateBlotterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticatorValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.GainCapital.com.WebServices/getRate", RequestNamespace="www.GainCapital.com.WebServices", ResponseNamespace="www.GainCapital.com.WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getRate(string Token, string Product) {
            object[] results = this.Invoke("getRate", new object[] {
                        Token,
                        Product});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getRateAsync(string Token, string Product) {
            this.getRateAsync(Token, Product, null);
        }
        
        /// <remarks/>
        public void getRateAsync(string Token, string Product, object userState) {
            if ((this.getRateOperationCompleted == null)) {
                this.getRateOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRateOperationCompleted);
            }
            this.InvokeAsync("getRate", new object[] {
                        Token,
                        Product}, this.getRateOperationCompleted, userState);
        }
        
        private void OngetRateOperationCompleted(object arg) {
            if ((this.getRateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getRateCompleted(this, new getRateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticatorValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("www.GainCapital.com.WebServices/getAnonymousRate", RequestNamespace="www.GainCapital.com.WebServices", ResponseNamespace="www.GainCapital.com.WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAnonymousRate(string Token, string Product, bool IBRates, long Keyvalue, int currencygroup) {
            object[] results = this.Invoke("getAnonymousRate", new object[] {
                        Token,
                        Product,
                        IBRates,
                        Keyvalue,
                        currencygroup});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAnonymousRateAsync(string Token, string Product, bool IBRates, long Keyvalue, int currencygroup) {
            this.getAnonymousRateAsync(Token, Product, IBRates, Keyvalue, currencygroup, null);
        }
        
        /// <remarks/>
        public void getAnonymousRateAsync(string Token, string Product, bool IBRates, long Keyvalue, int currencygroup, object userState) {
            if ((this.getAnonymousRateOperationCompleted == null)) {
                this.getAnonymousRateOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAnonymousRateOperationCompleted);
            }
            this.InvokeAsync("getAnonymousRate", new object[] {
                        Token,
                        Product,
                        IBRates,
                        Keyvalue,
                        currencygroup}, this.getAnonymousRateOperationCompleted, userState);
        }
        
        private void OngetAnonymousRateOperationCompleted(object arg) {
            if ((this.getAnonymousRateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAnonymousRateCompleted(this, new getAnonymousRateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="www.GainCapital.com.WebServices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="www.GainCapital.com.WebServices", IsNullable=false)]
    public partial class Authenticator : System.Web.Services.Protocols.SoapHeader {
        
        private string applicationNameField;
        
        private string iPAddressField;
        
        private string machineNameField;
        
        private string languageField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string ApplicationName {
            get {
                return this.applicationNameField;
            }
            set {
                this.applicationNameField = value;
            }
        }
        
        /// <remarks/>
        public string IPAddress {
            get {
                return this.iPAddressField;
            }
            set {
                this.iPAddressField = value;
            }
        }
        
        /// <remarks/>
        public string MachineName {
            get {
                return this.machineNameField;
            }
            set {
                this.machineNameField = value;
            }
        }
        
        /// <remarks/>
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="www.GainCapital.com.WebServices")]
    public partial class CollectionOfInt32 {
        
        private int[] inputField;
        
        /// <remarks/>
        public int[] Input {
            get {
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getRateBlotterCompletedEventHandler(object sender, getRateBlotterCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getRateBlotterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getRateBlotterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetRatesCompletedEventHandler(object sender, GetRatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getAnonymousRateBlotterCompletedEventHandler(object sender, getAnonymousRateBlotterCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAnonymousRateBlotterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAnonymousRateBlotterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getRateCompletedEventHandler(object sender, getRateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getRateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getRateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getAnonymousRateCompletedEventHandler(object sender, getAnonymousRateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAnonymousRateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAnonymousRateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591