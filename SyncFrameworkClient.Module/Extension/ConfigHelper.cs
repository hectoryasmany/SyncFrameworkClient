//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore;

//namespace ZyncFrameworkTest.Module.Extension
//{
//    public class ConfigHelper
//    {
//        HttpClient _client;
//        public ConfigHelper(HttpClient testClient)
//        {
//            _client = testClient;
//        }
//        public HttpClient CreateClient(string name)
//        {
//            return _client;
//        }

//        //private static Microsoft.AspNetCore.TestHost.TestServer _testServer;
//        //public static TestClientFactory GetTestClientFactory()
//        //{
//        //    if (_testServer == null)
//        //    {
//        //        var hostBuilder = new WebHostBuilder();
//        //        hostBuilder.UseStartup<Startup>();
//        //        _testServer = new Microsoft.AspNetCore.TestHost.TestServer(hostBuilder);
//        //    }

//        //    var testClient = MintClient();
//        //    var testServerHttpClientFactory = new TestClientFactory(testClient);
//        //    return testServerHttpClientFactory;
//        //}
//    }
//}
