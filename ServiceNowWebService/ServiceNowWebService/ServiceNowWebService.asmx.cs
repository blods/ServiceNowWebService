using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiceNowWebService
{
    /// <summary>
    /// Summary description for ServiceNowWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceNowWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        //[WebMethod]
        //public ServiceNowReference.getRecordsResponseGetRecordsResult[] getRecords()
        //{
           
        //    // GET RECORDS
        //    ServiceNowReference.ServiceNowSoapClient client = createClient();
        //    ServiceNowReference.getRecords records = new ServiceNowReference.getRecords();
        //    ServiceNowReference.getRecordsResponse recordsResponse = new ServiceNowReference.getRecordsResponse();

        //    try
        //    {     
        //        ServiceNowReference.getRecordsResponseGetRecordsResult[] response = client.getRecords(records);
        //        return response;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        // "ERROR: " + ex.Message;
        //        return null;
        //    }
        //}

        //private ServiceNowReference.ServiceNowSoapClient createClient()
        //{
        //    // CREATE CLIENT AND AUTHENTICATE
        //    ServiceNowReference.ServiceNowSoapClient client = new ServiceNowReference.ServiceNowSoapClient();
        //    Credentials cred = new Credentials();
        //    client.ClientCredentials.UserName.UserName = cred.getUserName();
        //    client.ClientCredentials.UserName.Password = cred.getPassword();
        //    return client;
        //}
    }
}
