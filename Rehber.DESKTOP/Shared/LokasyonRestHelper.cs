using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rehber.DESKTOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.DESKTOP.Shared
{
    class LokasyonRestHelper
    {
        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        private static readonly string baseUrl = "https://localhost:44340/api/";
        public static List<Lokasyon> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = client.GetAsync(baseUrl + "lokasyon").Result)
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = res.Content.ReadAsStringAsync().Result;

                        if (data != null)
                        {
                            var Lokas = new List<Lokasyon>();
                            JsonConvert.PopulateObject(data.ToString(), Lokas);
                            return Lokas;
                        }
                    }
                }
            }
            return null;
        }

        public static Lokasyon Get(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = client.GetAsync(baseUrl + "lokasyon/" + Id).Result)
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = res.Content.ReadAsStringAsync().Result;

                        if (data != null)
                        {
                            var Lokas = new Lokasyon();
                            JsonConvert.PopulateObject(data.ToString(), Lokas);
                            return Lokas;
                        }
                    }
                }
            }
            return null;
        }

        public static async Task<string> Post(Lokasyon Lokas)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Lokas);
            var info = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseUrl + "lokasyon/", info))
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

        public static async Task<string> Put(int Id, Lokasyon Lokas)
        {
            Lokas.Id = Id;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Lokas);
            var info = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseUrl + "lokasyon/" + Id, info))
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
                using (HttpResponseMessage res = await client.DeleteAsync(baseUrl + "lokasyon/" + Id))
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
