using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Prudential.WeatherApi.Plugins
{
    public class OpenWeatherApiClient : BaseApi
    {
        public async Task<string> GetDailyWeatherInformation()
        {

            //test case for only inocuding uptill 20 citi ids not more than that. Not allowed
            string appId = "aa69195559bd4f88d79f9aadeb77a8f6"; //app config
            HttpClient client = new HttpClient(); // base class

            string url = string.Format(
                "data/2.5/group?id=524901,703448,2643743&units=metric&appid={0}", appId);
            client.BaseAddress = new Uri("https://samples.openweathermap.org/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(url);
            

            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsStringAsync();
                
                
                //var data = response.Content.ReadAsAsync<IEnumerable<YourClass>>().Result;
                //foreach (var x in response.Content.ReadAsStringAsync())
                //{
                //    //Call your store method and pass in your own object
                //}
            }
            else
            {
                //Something has gone wrong, handle it here
            }

            return "";
        }
    }
}
