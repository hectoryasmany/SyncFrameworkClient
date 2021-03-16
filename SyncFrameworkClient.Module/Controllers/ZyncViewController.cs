using BIT.Xpo.Providers.OfflineDataSync;
using BIT.Xpo.Providers.OfflineDataSync.NetworkExtensions;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using SyncFrameworkClient.Module.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;



namespace SyncFrameworkClient.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ZyncViewController : ViewController
    {
        HttpClient httpClient;
        public ZyncViewController()
        {
            InitializeComponent();
            SimpleAction PushDeltas = new SimpleAction(this, "PushDeltasA", PredefinedCategory.View);
            PushDeltas.Caption = "Push Changes to master";
            PushDeltas.Execute += PushDeltas_Execute;

            SimpleAction PullDeltas = new SimpleAction(this, "PullDeltasA", PredefinedCategory.View);
            PullDeltas.Caption = "Pull Deltas from master";
            PullDeltas.Execute += PullDeltas_Execute;
            httpClient = new HttpClient();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        private void PullDeltas_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var SerializationService = new BIT.Data.Services.CompressXmlObjectSerializationService();
            var StringSerializactionService = new BIT.Data.Services.StringSerializationHelper();
            var Config = new SyncDataStoreServerConfiguration(SerializationService, StringSerializactionService, "https://c5c6118e315a.ngrok.io", httpClient);
            IObjectSpaceSyncExtension.Pull(this.ObjectSpace, Config);
        }

        private void PushDeltas_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var SerializationService = new BIT.Data.Services.CompressXmlObjectSerializationService();
            var StringSerializactionService = new BIT.Data.Services.StringSerializationHelper();
            var Config = new SyncDataStoreServerConfiguration(SerializationService, StringSerializactionService, "https://c5c6118e315a.ngrok.io", httpClient);
            IObjectSpaceSyncExtension.Push(this.ObjectSpace, Config);
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
