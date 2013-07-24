using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

// IMPORTANT: REMEMBER TO UPDATE THE WEB.CONFIG FILE FOR THE CORRECT AUTHENTICATION SCHEME
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
        string USERNAME = "admin";
        string PASSWORD = "password";

        private void getCredentials() {
            Credentials c = new Credentials();
            USERNAME = c.getUserName();
            PASSWORD = c.getPassword(); 
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int add(int x, int y)
        {
            return x + y;
        }

        [WebMethod]
        public string login()
        {            
            // CREATE CLIENT AND AUTHENTICATE
            ServiceNowReference.ServiceNowSoapClient client = getClient();
     
            // TRY LOGIN CREDENTIALS, CALLING AN ARBITRARY FUNCTION TO TEST THE CONNECTION
            ServiceNowReference.get get = new ServiceNowReference.get();
            ServiceNowReference.getResponse getResponse = new ServiceNowReference.getResponse();
            get.sys_id = "FOO BAR"; // "9733fb902bbe4500e487f39fe8da1521" is a typical sys_id;

            try
            {
                getResponse = client.get(get); // this had errors before, needed to change the service reference to "arrayList" vs. "array"
                return "Logged in successfully as " + USERNAME; //" + getResponse.sys_class_name;
            }
            catch (Exception ex)
            {
                return "USERNAME: " + USERNAME + "\r\n" + 
                    "PASSWORD: " + PASSWORD + "\r\n" + 
                    "Unable to log in. Please check username and password, and ensure you have a network connection.\r\n\r\n" + ex.ToString();
            }
        }

        private ServiceNowReference.ServiceNowSoapClient getClient()
        {
            // SET CREDENTIALS BEFORE CALLING
            getCredentials(); // USERNAME AND PASSWORD LOADED FROM LOGIN.TXT FILE

            // CREATE CLIENT
            ServiceNowReference.ServiceNowSoapClient client = new ServiceNowReference.ServiceNowSoapClient();
            client.ClientCredentials.UserName.UserName = USERNAME;
            client.ClientCredentials.UserName.Password = PASSWORD;
            return client;
        }
    }
}
