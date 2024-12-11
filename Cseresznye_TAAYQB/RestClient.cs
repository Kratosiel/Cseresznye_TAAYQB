using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Cseresznye_TAAYQB
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClient
    {
        HttpWebRequest request = null;

        public string endPoint { get; set; }
        public httpVerb verb { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            verb = httpVerb.GET;
        }
        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
                request.Method = verb.ToString();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("Hiba kód: " + response.StatusCode.ToString());
                    }

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                        }
                    }
                }
                request.Method = verb.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Hiba");
            }


            return strResponseValue;
        }
    }
}
