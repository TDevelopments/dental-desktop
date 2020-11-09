using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace CapaDatos
{
    public class DoctorData
    {
        string host = ConfigurationManager.ConnectionStrings["host"].ConnectionString;
        string token = Properties.Settings.Default.Token.ToString();
        string contentType = "application/json;charset=UTF-8";

        public bool SaveToken(string email, string password)
        {
            const string endpoint = "/doctors/login";
            string result;
            WebRequest oRequest = WebRequest.Create(host + endpoint);
            oRequest.Method = "post";
            oRequest.ContentType = contentType ;

            var jsonBody = new
            {
                email = email,
                password = password
            };

            try
            {
                using(var oSW = new StreamWriter(oRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(jsonBody, Formatting.Indented);
                    oSW.Write(json);
                    oSW.Flush();
                    oSW.Close();
                }
            } catch ( Exception e)
            {
                // TODO: Controlar bien la excepcion
                return false;

            }

            WebResponse oResponse = oRequest.GetResponse();
            
            using (var oSR = new StreamReader(oResponse.GetResponseStream()))
            {
                result = oSR.ReadToEnd();
                var jss = new JavaScriptSerializer();
                var dict = jss.Deserialize<Dictionary<string, string>>(result);
                Properties.Settings.Default.Token = dict["token"];
                Properties.Settings.Default.Save();
                return true;
            }
        }
    }
}
