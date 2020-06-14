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

        public async Task<GlobalCases> GetGlobalCases()
        {
            return await Get<GlobalCases>("/summary");
        }

        public async Task<List<CountryCaseByDate>> GetByCountry(GetByCountryLiveParamters parameters)
        {
            string path = $"/total/country/{parameters.CountryCode.ToLower()}";

            List<CountryCaseByDate> results = await Get<List<CountryCaseByDate>>(path);

            if (results != null)
            {
                // filter from date
                if (parameters.From != null && DateTime.TryParse(parameters.From, out DateTime fromDate))
                {
                    results = results.Where(k => k.Date >= fromDate).ToList();
                }

                // group by date only (since the results include date and time) and take the top 40

                results = results.GroupBy(k => k.Date.Date)
                                 .Select(k => new CountryCaseByDate()
                                 {
                                     Date = k.Key,
                                     Confirmed = k.Sum(c => c.Confirmed),
                                     Recovered = k.Sum(c => c.Recovered),
                                     Deaths = k.Sum(c => c.Deaths),
                                 })
                                 .OrderByDescending(k => k.Date)
                                 .Take(40)
                                 .ToList();
            }

            return results;
        }

        public async Task<List<Country>> GetCountries()
        {
            return await Get<List<Country>>("/countries");
        }
    }
}
