using CinemaChoicesAPI.Helpers;
using CinemaChoicesAPI.Postcode.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace CinemaChoicesAPI.Postcode
{
    public class PostcodeApiReader
    {
        private string _url;
        private CineworldHelpers _cineworldHelpers;

        public PostcodeApiReader(CineworldHelpers cineworldHelpers)
        {
            _url = "https://api.postcodes.io/postcodes/";
            _cineworldHelpers = cineworldHelpers;
        }

        public Location GetLocationForPostcode(string postCode)
        {
            Location location = new Location();
            var callUrl = string.Format("{0}{1}", _url, postCode);
            using (var webClient = new System.Net.WebClient())
            {
                try
                {
                    var json = webClient.DownloadString(callUrl);
                    // Now parse with JSON.Net
                    var jObject = (JObject)JsonConvert.DeserializeObject(json);
                    location.Longitude = jObject["result"]["longitude"].ToString();
                    location.Latitude = jObject["result"]["latitude"].ToString();
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return location;
        }
    }
}
