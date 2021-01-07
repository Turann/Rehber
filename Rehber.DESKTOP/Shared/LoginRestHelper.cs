using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rehber.DESKTOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehber.DESKTOP.Shared
{
    class LoginRestHelper
    {
        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        private static readonly string baseUrl = "https://localhost:44340/api/";

        public static List<Kullanici> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = client.GetAsync(baseUrl + "kullanici").Result)
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = res.Content.ReadAsStringAsync().Result;
                        
                        if (data != null)
                        {
                            var Kullani = new List<Kullanici>();
                            JsonConvert.PopulateObject(data.ToString(), Kullani);
                            return Kullani;
                        }
                    }
                }
            }
            return null;
        }

        public static Kullanici Get(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = client.GetAsync(baseUrl + "kullanici/" + Id).Result)
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = res.Content.ReadAsStringAsync().Result;

                        if (data != null)
                        {
                            var Kullani = new Kullanici();
                            JsonConvert.PopulateObject(data.ToString(), Kullani);
                            return Kullani;
                        }
                    }
                }
            }
            return null;
        }
        
        public static async Task<string> Post(Kullanici Kull)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Kull);
            var info = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseUrl + "kullanici/", info))
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

        public static async Task<string> Put(int Id, Kullanici Kull)
        {
            Kull.Id = Id;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Kull);
            var info = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseUrl + "kullanici/"+Id, info))
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
                using (HttpResponseMessage res = await client.DeleteAsync(baseUrl + "kullanici/" + Id))
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