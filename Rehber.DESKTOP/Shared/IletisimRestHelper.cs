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
    class IletisimRestHelper { 
    public static string BeautifyJson(string jsonStr)
    {
        JToken parseJson = JToken.Parse(jsonStr);
        return parseJson.ToString(Formatting.Indented);
    }

    private static readonly string baseUrl = "https://localhost:44340/api/";
    public static List<Iletisim> GetAll()
    {
        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage res = client.GetAsync(baseUrl + "iletisim").Result)
            {
                using (HttpContent content = res.Content)
                {
                    string data = res.Content.ReadAsStringAsync().Result;

                    if (data != null)
                    {
                        var Ilet = new List<Iletisim>();
                        JsonConvert.PopulateObject(data.ToString(), Ilet);
                        return Ilet;
                    }
                }
            }
        }
        return null;
    }

    public static Iletisim Get(int Id)
    {
        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage res = client.GetAsync(baseUrl + "iletisim/" + Id).Result)
            {
                using (HttpContent content = res.Content)
                {
                    string data = res.Content.ReadAsStringAsync().Result;

                    if (data != null)
                    {
                        var Ilet = new Iletisim();
                        JsonConvert.PopulateObject(data.ToString(), Ilet);
                        return Ilet;
                    }
                }
            }
        }
        return null;
    }

    public static async Task<string> Post(Iletisim Ilet)
    {
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(Ilet);
        var info = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage res = await client.PostAsync(baseUrl + "iletisim/", info))
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

    public static async Task<string> Put(int Id, Iletisim Ilet)
    {
        Ilet.Id = Id;
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(Ilet);
        var info = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage res = await client.PutAsync(baseUrl + "iletisim/" + Id, info))
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
                using (HttpResponseMessage res = await client.DeleteAsync(baseUrl + "iletisim/" + Id))
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