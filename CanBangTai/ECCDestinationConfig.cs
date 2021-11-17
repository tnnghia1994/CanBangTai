using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector; // your sap connector
using System.Xml;

namespace CanBangTai
{
    class ECCDestinationConfig : IDestinationConfiguration
    {
        public bool ChangeEventsSupported()
        {
            return false;
        }

        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;

        public RfcConfigParameters GetParameters(string destinationName)
        {

            RfcConfigParameters parms = new RfcConfigParameters();

            if (destinationName.Equals("mySAPdestination"))
            {
                parms.Add(RfcConfigParameters.User, "ct.abap"); // user
                parms.Add(RfcConfigParameters.Password, "123456z@#"); // password
                parms.Add(RfcConfigParameters.Client, "300"); // client 
                parms.Add(RfcConfigParameters.Language, "EN"); // language
                parms.Add(RfcConfigParameters.AppServerHost, "192.168.140.35"); // AppServerHost 
                parms.Add(RfcConfigParameters.SystemNumber, "01"); // system number
                parms.Add(RfcConfigParameters.MaxPoolSize, "10"); // PoolSize
                parms.Add(RfcConfigParameters.IdleTimeout, "20"); //idle Timeout 
                parms.Add(RfcConfigParameters.SAPRouter, "/H/113.160.245.25/S/3297/H/"); // sapRouter
            }
            return parms;

        }
    }
}
