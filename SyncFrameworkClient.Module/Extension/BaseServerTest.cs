
//using BIT.Data.Functions;
//using BIT.Data.Functions.RestClientNet;
//using BIT.Data.Services;
//using Microsoft.AspNetCore.Hosting;
//using RestClient.Net;
//using RestClient.Net.Abstractions;
//using System.Net.Http;


//namespace ZyncFrameworkTest.Module
//{
//    public class BaseServerTest
//    {
       
        
      
        
        
//        public virtual void Setup()
//        {
//            //TestServerClientFactory = GetTestClientFactory();
           


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
//        //protected TestClientFactory TestServerClientFactory;
//        //private static HttpClient MintClient()
//        //{
//        //    return _testServer.CreateClient();
//        //}
//        public const string LocalBaseUriString = "http://localhost:8080";

//        //protected int GetCustomerCountFromServer(IObjectSerializationService SerializationService)
//        //{
//        //    var client = new Client(new NewtonsoftSerializationAdapter(), createHttpClient: (name) => this.TestServerClientFactory.CreateClient());
//        //    var Function = new ApiFunction(client, BaseServerTest.LocalBaseUriString + "/Sync", null);
//        //    DataParameters parameters = new DataParameters() { MemberName = "GetCustomerCount" };
//        //    var Result = Function.ExecuteFunction(parameters);
//        //    int Count = SerializationService.GetObjectsFromByteArray<int>(Result.ResultValue);
//        //    return Count;
//        //}
//    }
//}