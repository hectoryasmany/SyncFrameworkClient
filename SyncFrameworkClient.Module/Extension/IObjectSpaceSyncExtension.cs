using BIT.Xpo.Providers.OfflineDataSync;
using BIT.Xpo.Providers.OfflineDataSync.NetworkExtensions;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyncFrameworkClient.Module.Extension
{
    public static class IObjectSpaceSyncExtension
    {
        static IDataStore Cast(IObjectSpace ObjectSpace)
        {
            var Dal = (ObjectSpace as XPObjectSpace).Session.DataLayer as SimpleDataLayer;
            DataStorePool Pool = Dal.ConnectionProvider as DataStorePool;
            var ISyncDataStore = Pool.AcquireChangeProvider() as ISyncDataStore;
            return ISyncDataStore;
            
        }
        public static  void Push(this IObjectSpace ObjectSpace, ISyncDataStoreServerConfiguration config)
        {
            ISyncDataStore ISyncDataStore = Cast(ObjectSpace) as ISyncDataStore;
            ISyncDataStore.PushDeltas(config);
        }
        public static void Pull(this IObjectSpace ObjectSpace, ISyncDataStoreServerConfiguration config)
        {  
            ISyncDataStore ISyncDataStore = Cast(ObjectSpace) as ISyncDataStore;
            ISyncDataStore.PullDeltas(config);
        }
    }
}
