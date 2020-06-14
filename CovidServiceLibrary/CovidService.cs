using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using CovidServiceLibrary.DataContract;
using CovidServiceLibrary.DataContract.Parameters;

namespace CovidServiceLibrary
{
    public class CovidService : ICovidService
    {
        private readonly string baseUrl = ConfigurationManager.AppSettings["BaseApi"];
        private readonly HttpClient client;

        public CovidService()
        {

            client = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async Task<T> Get<T>(string urlParameters)
        {
            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(urlParameters);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();


                    return JsonConvert.DeserializeObject<T>(data);
                }
                else
                {
                    return default;
                }
            }
        }

        public async Task<Global> GetGlobalCases()
        {
            return (await Get<GlobalCases>("/summary"))?.Global;
        }

        public async Task<List<CountryCaseByDate>> GetByCountry(GetByCountryLiveParamters parameters)
        {
            string path = $"/total/{parameters.CountryCode.ToLower()}/lebanon";


            //List<string> query = new List<string>();

            //if (parameters.From != null)
            //{
            //    //query.Add("from=" + parameters.From);

            //    path += $"/date/{parameters.From}T00:00:00Z";

            //    //query.Add("from=" + parameters.From);
            //}

            ////if (parameters.To != null)
            ////{
            ////    query.Add("to=" + parameters.To);
            ////}

            ////if (query.Count > 0)
            ////{
            ////    path += $"?{string.Join("&", query)}";
            ////}

            return (await Get<List<CountryCaseByDate>>(path))?.GroupBy(k => k.Date.Date).Select(k => new CountryCaseByDate()
            {
                Date = k.Key,
                Confirmed = k.Sum(c=>c.Confirmed),
                Recovered = k.Sum(c=>c.Recovered),
                Deaths = k.Sum(c=>c.Deaths),
            }).Take(40).ToList();
        }

        public async Task<List<Country>> GetCountries()
        {
            return await Get<List<Country>>("/countries");
        }
    }
}
