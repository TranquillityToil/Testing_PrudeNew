using Newtonsoft.Json.Linq;
using Prudential.WeatherApi.Models;
using Prudential.WeatherApi.Plugins;
using Prudential.WeatherApi.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Prudential.WeatherApi.Controllers
{
    public class WeatherController : ApiController // baseAPI contr
    {
        [HttpGet]
        public async Task<IHttpActionResult> ValidatePassengers()
        {
           // OpenWeatherApiClient cl = new OpenWeatherApiClient();
           // var dasta = await cl.GetDailyWeatherInformation();

            string path = string.Empty;
            string xmlInputData = string.Empty;
            string xmlOutputData = string.Empty;

            // EXAMPLE 1
            //path = HttpContext.Current.Server.MapPath("~/App_Data/CitiesData.xml");
            path = HttpContext.Current.Server.MapPath("~/App_Data/TextFile1.txt");
            xmlInputData = File.ReadAllText(path);

            //var details = JObject.Parse(xmlInputData);

            
            dynamic details = Newtonsoft.Json.JsonConvert.DeserializeObject(xmlInputData);
            int c = Convert.ToInt32(details.cnt);
            dynamic datalist = details.list;
            for (var i = 0; i < c; i++)
            {
                var item = datalist[i];

                if(item!=null )
                {
                    string cityIfo = "Name: {0}, Age: {1}" + (string)item.id + (string)item.name;
                    
                }
                
                //Newtonsoft.Json.JsonConvert.SerializeObject(item)
            }

            // Console.WriteLine(string.Concat("Hi ", details["FirstName"], " " + details["LastName"]));

            Serializer<List<CityModel>> obj = new Serializer<List<CityModel>>();
            var data = obj.Deserialize(xmlInputData);
            


            return null;
        }

        private void SaveWeatherInformation(Object cityInformation )
        {
            Newtonsoft.Json.JsonConvert.SerializeObject(item);
        }

       private string GetOutputFileLocation()
        {
            string outputPath = "D:\\WeatherInformation";//  Convert.ToString(ConfigurationManager.AppSettings["StoragePath"]);


        }
    }
}
