﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace Stocker.Uygula {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bıcımlendır", Namespace="http://schemas.datacontract.org/2004/07/Stocker.Web.Fonksiyonlar")]
    public partial class Bıcımlendır : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string KullanıcıAdıField;
        
        private string UruhnAcıklamaField;
        
        private int UrunFıyatField;
        
        private string UrunIsmıField;
        
        private int UrunKoduField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KullanıcıAdı {
            get {
                return this.KullanıcıAdıField;
            }
            set {
                if ((object.ReferenceEquals(this.KullanıcıAdıField, value) != true)) {
                    this.KullanıcıAdıField = value;
                    this.RaisePropertyChanged("KullanıcıAdı");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UruhnAcıklama {
            get {
                return this.UruhnAcıklamaField;
            }
            set {
                if ((object.ReferenceEquals(this.UruhnAcıklamaField, value) != true)) {
                    this.UruhnAcıklamaField = value;
                    this.RaisePropertyChanged("UruhnAcıklama");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UrunFıyat {
            get {
                return this.UrunFıyatField;
            }
            set {
                if ((this.UrunFıyatField.Equals(value) != true)) {
                    this.UrunFıyatField = value;
                    this.RaisePropertyChanged("UrunFıyat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UrunIsmı {
            get {
                return this.UrunIsmıField;
            }
            set {
                if ((object.ReferenceEquals(this.UrunIsmıField, value) != true)) {
                    this.UrunIsmıField = value;
                    this.RaisePropertyChanged("UrunIsmı");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UrunKodu {
            get {
                return this.UrunKoduField;
            }
            set {
                if ((this.UrunKoduField.Equals(value) != true)) {
                    this.UrunKoduField = value;
                    this.RaisePropertyChanged("UrunKodu");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="Uygula.Uygulayıcı")]
    public interface Uygulayıcı {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Uygulayıcı/TümKayıtlarıAl", ReplyAction="urn:Uygulayıcı/TümKayıtlarıAlResponse")]
        System.IAsyncResult BeginTümKayıtlarıAl(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<Stocker.Uygula.Bıcımlendır> EndTümKayıtlarıAl(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Uygulayıcı/Ekleme", ReplyAction="urn:Uygulayıcı/EklemeResponse")]
        System.IAsyncResult BeginEkleme(Stocker.Uygula.Bıcımlendır bcm, System.AsyncCallback callback, object asyncState);
        
        int EndEkleme(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Uygulayıcı/Güncelle", ReplyAction="urn:Uygulayıcı/GüncelleResponse")]
        System.IAsyncResult BeginGüncelle(Stocker.Uygula.Bıcımlendır bcm, System.AsyncCallback callback, object asyncState);
        
        int EndGüncelle(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Uygulayıcı/Silme", ReplyAction="urn:Uygulayıcı/SilmeResponse")]
        System.IAsyncResult BeginSilme(int bcm, System.AsyncCallback callback, object asyncState);
        
        bool EndSilme(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Uygulayıcı/Ara", ReplyAction="urn:Uygulayıcı/AraResponse")]
        System.IAsyncResult BeginAra(Stocker.Uygula.Bıcımlendır ara, System.AsyncCallback callback, object asyncState);
        
        string EndAra(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UygulayıcıChannel : Stocker.Uygula.Uygulayıcı, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TümKayıtlarıAlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public TümKayıtlarıAlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Stocker.Uygula.Bıcımlendır> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<Stocker.Uygula.Bıcımlendır>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EklemeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public EklemeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GüncelleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GüncelleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SilmeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SilmeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AraCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AraCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UygulayıcıClient : System.ServiceModel.ClientBase<Stocker.Uygula.Uygulayıcı>, Stocker.Uygula.Uygulayıcı {
        
        private BeginOperationDelegate onBeginTümKayıtlarıAlDelegate;
        
        private EndOperationDelegate onEndTümKayıtlarıAlDelegate;
        
        private System.Threading.SendOrPostCallback onTümKayıtlarıAlCompletedDelegate;
        
        private BeginOperationDelegate onBeginEklemeDelegate;
        
        private EndOperationDelegate onEndEklemeDelegate;
        
        private System.Threading.SendOrPostCallback onEklemeCompletedDelegate;
        
        private BeginOperationDelegate onBeginGüncelleDelegate;
        
        private EndOperationDelegate onEndGüncelleDelegate;
        
        private System.Threading.SendOrPostCallback onGüncelleCompletedDelegate;
        
        private BeginOperationDelegate onBeginSilmeDelegate;
        
        private EndOperationDelegate onEndSilmeDelegate;
        
        private System.Threading.SendOrPostCallback onSilmeCompletedDelegate;
        
        private BeginOperationDelegate onBeginAraDelegate;
        
        private EndOperationDelegate onEndAraDelegate;
        
        private System.Threading.SendOrPostCallback onAraCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public UygulayıcıClient() {
        }
        
        public UygulayıcıClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UygulayıcıClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UygulayıcıClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UygulayıcıClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<TümKayıtlarıAlCompletedEventArgs> TümKayıtlarıAlCompleted;
        
        public event System.EventHandler<EklemeCompletedEventArgs> EklemeCompleted;
        
        public event System.EventHandler<GüncelleCompletedEventArgs> GüncelleCompleted;
        
        public event System.EventHandler<SilmeCompletedEventArgs> SilmeCompleted;
        
        public event System.EventHandler<AraCompletedEventArgs> AraCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Stocker.Uygula.Uygulayıcı.BeginTümKayıtlarıAl(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTümKayıtlarıAl(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<Stocker.Uygula.Bıcımlendır> Stocker.Uygula.Uygulayıcı.EndTümKayıtlarıAl(System.IAsyncResult result) {
            return base.Channel.EndTümKayıtlarıAl(result);
        }
        
        private System.IAsyncResult OnBeginTümKayıtlarıAl(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Stocker.Uygula.Uygulayıcı)(this)).BeginTümKayıtlarıAl(callback, asyncState);
        }
        
        private object[] OnEndTümKayıtlarıAl(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<Stocker.Uygula.Bıcımlendır> retVal = ((Stocker.Uygula.Uygulayıcı)(this)).EndTümKayıtlarıAl(result);
            return new object[] {
                    retVal};
        }
        
        private void OnTümKayıtlarıAlCompleted(object state) {
            if ((this.TümKayıtlarıAlCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TümKayıtlarıAlCompleted(this, new TümKayıtlarıAlCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TümKayıtlarıAlAsync() {
            this.TümKayıtlarıAlAsync(null);
        }
        
        public void TümKayıtlarıAlAsync(object userState) {
            if ((this.onBeginTümKayıtlarıAlDelegate == null)) {
                this.onBeginTümKayıtlarıAlDelegate = new BeginOperationDelegate(this.OnBeginTümKayıtlarıAl);
            }
            if ((this.onEndTümKayıtlarıAlDelegate == null)) {
                this.onEndTümKayıtlarıAlDelegate = new EndOperationDelegate(this.OnEndTümKayıtlarıAl);
            }
            if ((this.onTümKayıtlarıAlCompletedDelegate == null)) {
                this.onTümKayıtlarıAlCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTümKayıtlarıAlCompleted);
            }
            base.InvokeAsync(this.onBeginTümKayıtlarıAlDelegate, null, this.onEndTümKayıtlarıAlDelegate, this.onTümKayıtlarıAlCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Stocker.Uygula.Uygulayıcı.BeginEkleme(Stocker.Uygula.Bıcımlendır bcm, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginEkleme(bcm, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int Stocker.Uygula.Uygulayıcı.EndEkleme(System.IAsyncResult result) {
            return base.Channel.EndEkleme(result);
        }
        
        private System.IAsyncResult OnBeginEkleme(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Stocker.Uygula.Bıcımlendır bcm = ((Stocker.Uygula.Bıcımlendır)(inValues[0]));
            return ((Stocker.Uygula.Uygulayıcı)(this)).BeginEkleme(bcm, callback, asyncState);
        }
        
        private object[] OnEndEkleme(System.IAsyncResult result) {
            int retVal = ((Stocker.Uygula.Uygulayıcı)(this)).EndEkleme(result);
            return new object[] {
                    retVal};
        }
        
        private void OnEklemeCompleted(object state) {
            if ((this.EklemeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.EklemeCompleted(this, new EklemeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void EklemeAsync(Stocker.Uygula.Bıcımlendır bcm) {
            this.EklemeAsync(bcm, null);
        }
        
        public void EklemeAsync(Stocker.Uygula.Bıcımlendır bcm, object userState) {
            if ((this.onBeginEklemeDelegate == null)) {
                this.onBeginEklemeDelegate = new BeginOperationDelegate(this.OnBeginEkleme);
            }
            if ((this.onEndEklemeDelegate == null)) {
                this.onEndEklemeDelegate = new EndOperationDelegate(this.OnEndEkleme);
            }
            if ((this.onEklemeCompletedDelegate == null)) {
                this.onEklemeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnEklemeCompleted);
            }
            base.InvokeAsync(this.onBeginEklemeDelegate, new object[] {
                        bcm}, this.onEndEklemeDelegate, this.onEklemeCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Stocker.Uygula.Uygulayıcı.BeginGüncelle(Stocker.Uygula.Bıcımlendır bcm, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGüncelle(bcm, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int Stocker.Uygula.Uygulayıcı.EndGüncelle(System.IAsyncResult result) {
            return base.Channel.EndGüncelle(result);
        }
        
        private System.IAsyncResult OnBeginGüncelle(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Stocker.Uygula.Bıcımlendır bcm = ((Stocker.Uygula.Bıcımlendır)(inValues[0]));
            return ((Stocker.Uygula.Uygulayıcı)(this)).BeginGüncelle(bcm, callback, asyncState);
        }
        
        private object[] OnEndGüncelle(System.IAsyncResult result) {
            int retVal = ((Stocker.Uygula.Uygulayıcı)(this)).EndGüncelle(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGüncelleCompleted(object state) {
            if ((this.GüncelleCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GüncelleCompleted(this, new GüncelleCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GüncelleAsync(Stocker.Uygula.Bıcımlendır bcm) {
            this.GüncelleAsync(bcm, null);
        }
        
        public void GüncelleAsync(Stocker.Uygula.Bıcımlendır bcm, object userState) {
            if ((this.onBeginGüncelleDelegate == null)) {
                this.onBeginGüncelleDelegate = new BeginOperationDelegate(this.OnBeginGüncelle);
            }
            if ((this.onEndGüncelleDelegate == null)) {
                this.onEndGüncelleDelegate = new EndOperationDelegate(this.OnEndGüncelle);
            }
            if ((this.onGüncelleCompletedDelegate == null)) {
                this.onGüncelleCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGüncelleCompleted);
            }
            base.InvokeAsync(this.onBeginGüncelleDelegate, new object[] {
                        bcm}, this.onEndGüncelleDelegate, this.onGüncelleCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Stocker.Uygula.Uygulayıcı.BeginSilme(int bcm, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSilme(bcm, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool Stocker.Uygula.Uygulayıcı.EndSilme(System.IAsyncResult result) {
            return base.Channel.EndSilme(result);
        }
        
        private System.IAsyncResult OnBeginSilme(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int bcm = ((int)(inValues[0]));
            return ((Stocker.Uygula.Uygulayıcı)(this)).BeginSilme(bcm, callback, asyncState);
        }
        
        private object[] OnEndSilme(System.IAsyncResult result) {
            bool retVal = ((Stocker.Uygula.Uygulayıcı)(this)).EndSilme(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSilmeCompleted(object state) {
            if ((this.SilmeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SilmeCompleted(this, new SilmeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SilmeAsync(int bcm) {
            this.SilmeAsync(bcm, null);
        }
        
        public void SilmeAsync(int bcm, object userState) {
            if ((this.onBeginSilmeDelegate == null)) {
                this.onBeginSilmeDelegate = new BeginOperationDelegate(this.OnBeginSilme);
            }
            if ((this.onEndSilmeDelegate == null)) {
                this.onEndSilmeDelegate = new EndOperationDelegate(this.OnEndSilme);
            }
            if ((this.onSilmeCompletedDelegate == null)) {
                this.onSilmeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSilmeCompleted);
            }
            base.InvokeAsync(this.onBeginSilmeDelegate, new object[] {
                        bcm}, this.onEndSilmeDelegate, this.onSilmeCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Stocker.Uygula.Uygulayıcı.BeginAra(Stocker.Uygula.Bıcımlendır ara, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAra(ara, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string Stocker.Uygula.Uygulayıcı.EndAra(System.IAsyncResult result) {
            return base.Channel.EndAra(result);
        }
        
        private System.IAsyncResult OnBeginAra(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Stocker.Uygula.Bıcımlendır ara = ((Stocker.Uygula.Bıcımlendır)(inValues[0]));
            return ((Stocker.Uygula.Uygulayıcı)(this)).BeginAra(ara, callback, asyncState);
        }
        
        private object[] OnEndAra(System.IAsyncResult result) {
            string retVal = ((Stocker.Uygula.Uygulayıcı)(this)).EndAra(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAraCompleted(object state) {
            if ((this.AraCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AraCompleted(this, new AraCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AraAsync(Stocker.Uygula.Bıcımlendır ara) {
            this.AraAsync(ara, null);
        }
        
        public void AraAsync(Stocker.Uygula.Bıcımlendır ara, object userState) {
            if ((this.onBeginAraDelegate == null)) {
                this.onBeginAraDelegate = new BeginOperationDelegate(this.OnBeginAra);
            }
            if ((this.onEndAraDelegate == null)) {
                this.onEndAraDelegate = new EndOperationDelegate(this.OnEndAra);
            }
            if ((this.onAraCompletedDelegate == null)) {
                this.onAraCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAraCompleted);
            }
            base.InvokeAsync(this.onBeginAraDelegate, new object[] {
                        ara}, this.onEndAraDelegate, this.onAraCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Stocker.Uygula.Uygulayıcı CreateChannel() {
            return new UygulayıcıClientChannel(this);
        }
        
        private class UygulayıcıClientChannel : ChannelBase<Stocker.Uygula.Uygulayıcı>, Stocker.Uygula.Uygulayıcı {
            
            public UygulayıcıClientChannel(System.ServiceModel.ClientBase<Stocker.Uygula.Uygulayıcı> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginTümKayıtlarıAl(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("TümKayıtlarıAl", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<Stocker.Uygula.Bıcımlendır> EndTümKayıtlarıAl(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<Stocker.Uygula.Bıcımlendır> _result = ((System.Collections.ObjectModel.ObservableCollection<Stocker.Uygula.Bıcımlendır>)(base.EndInvoke("TümKayıtlarıAl", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginEkleme(Stocker.Uygula.Bıcımlendır bcm, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = bcm;
                System.IAsyncResult _result = base.BeginInvoke("Ekleme", _args, callback, asyncState);
                return _result;
            }
            
            public int EndEkleme(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("Ekleme", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGüncelle(Stocker.Uygula.Bıcımlendır bcm, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = bcm;
                System.IAsyncResult _result = base.BeginInvoke("Güncelle", _args, callback, asyncState);
                return _result;
            }
            
            public int EndGüncelle(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("Güncelle", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginSilme(int bcm, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = bcm;
                System.IAsyncResult _result = base.BeginInvoke("Silme", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndSilme(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("Silme", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginAra(Stocker.Uygula.Bıcımlendır ara, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = ara;
                System.IAsyncResult _result = base.BeginInvoke("Ara", _args, callback, asyncState);
                return _result;
            }
            
            public string EndAra(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Ara", _args, result)));
                return _result;
            }
        }
    }
}
