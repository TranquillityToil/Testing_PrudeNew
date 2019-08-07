using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prudential.WeatherApi.Models
{
    public class CityModel
    {
        public  string  Identifier { get; set; }

        public  string Name { get; set; }


        public CityModel()
        {

        }

        //public CityModel(string identifier, string name)
        //{
        //    if (string.IsNullOrEmpty(identifier))
        //        throw new ArgumentNullException("identifier");


        //    if (string.IsNullOrEmpty(name))
        //        throw new ArgumentNullException("name");

        //    this.Identifier = identifier;
        //    this.Name = name;
        //}
    }
}