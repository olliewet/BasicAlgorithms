using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BasicAlgorithms
{
    class NetworkingAlgorithms
    {
        #region Is IP Address Valid 
        public static bool is_valid_IP(string ipAddres)
        {
            //Declaring IP Address using system.Net 
            IPAddress ip;
            //Using bool to see if IP is valid using Parse 
            bool validIp = IPAddress.TryParse(ipAddres, out ip);
            // Return the bool and turning ip to string
            return validIp && ip.ToString() == ipAddres;
        }
        #endregion 
    }
}
