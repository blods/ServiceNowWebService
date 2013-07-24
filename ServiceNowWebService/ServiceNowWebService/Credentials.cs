using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceNowWebService
{
    public class Credentials
    {
        private static string username;
        private static string password;

        public Credentials()
        {
            try
            {
                // Read the file and line by line
                String[] cred = new String[2];

                System.IO.StreamReader file =
                   new System.IO.StreamReader("c:\\login.txt");
               
                cred[0] = file.ReadLine(); // username
                cred[1] = file.ReadLine(); // password
                file.Close();

                username = cred[0];
                password = cred[1];
            }
            catch (Exception e)
            {
                username = "admin";
                password = "password";
            }
        }

        public string getUserName()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
    }
}