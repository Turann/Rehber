using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Rehber.DESKTOP.Classes;
using System.Collections.ObjectModel;

namespace Rehber.DESKTOP.Shared
{
    class RehberInfoRestHelper
    {
        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        private static readonly string baseUrl = "https://localhost:44340/api/";
        public static List<RehberInfo> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = client.GetAsync(baseUrl + "rehberinfo").Result)
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = res.Content.ReadAsStringAsync().Result;

                        if (data != null)
                        {
                            var Rehb = new List<RehberInfo>();
                            JsonConvert.PopulateObject(data.ToString(), Rehb);
                            return Rehb;
                        }
                    }
                }
            }
            return null;
        }

        public static RehberInfo Get(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = client.GetAsync(baseUrl + "rehberinfo/" + Id).Result)
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = res.Content.ReadAsStringAsync().Result;

                        if (data != null)
                        {
                            var Rehb = new RehberInfo();
                            JsonConvert.PopulateObject(data.ToString(), Rehb);
                            return Rehb;
                        }
                    }
                }
            }
            return null;
        }

        public static async Task<string> Post(RehberInfo Rehb)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Rehb);
            var info = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseUrl + "rehberinfo/", info))
                { 
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Put(int Id, RehberInfo Rehb)
        {
            Rehb.Id = Id;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Rehb);
            var info = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseUrl + "rehberinfo/" + Id, info))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Delete(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync(baseUrl + "rehberinfo/" + Id))
                {
                    using (HttpContent content = res.Content)
                    {

                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}
