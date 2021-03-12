using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Statistici.repository
{
    class DataAPI
    {
        private Dictionary<string, int> BusNivPol = new Dictionary<string, int>();
        private String baseRequest;
        private WebRequest req;
        
        public DataAPI(string baseRequest, String req)
        {
            this.baseRequest = baseRequest;
            this.req = WebRequest.Create(baseRequest + req);
        }

        public void setRequest()
        {
            req.Method = "GET";
            req.Headers["X-User-id"] = "7055";
            req.Headers["X-User-hash"] = "dc131fff7b6a5dcdaef9427e9da9d9d1";
        }

        public void getResponse()
        {
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            String respString;
            using (Stream stream = resp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                respString = reader.ReadToEnd();
            }

            dynamic din = JsonConvert.DeserializeObject(respString);
            //Console.WriteLine(din);
            char[] c = { '}', ',' };
            String[] data = JsonConvert.DeserializeObject(respString).ToString().Split(c);
            char[] c2 = { ' ', '"' };
            //Console.WriteLine(data[25].Split(':')[1].Trim(c2));
            BusNivPol["BV18DKZ"] = Int32.Parse(data[25].Split(':')[1].Trim(c2));
            BusNivPol["BV18EIK"] = Int32.Parse(data[53].Split(':')[1].Trim(c2));
            BusNivPol["BV18EHX"] = Int32.Parse(data[81].Split(':')[1].Trim(c2));
            BusNivPol["BV18EIL"] = Int32.Parse(data[109].Split(':')[1].Trim(c2));
            BusNivPol["BV18DKY"] = Int32.Parse(data[25].Split(':')[1].Trim(c2));
        }

        public Dictionary<string, int> getPolLvl()
        {
            return this.BusNivPol;
        }
    }
}
