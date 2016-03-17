using System;
using System.Collections.Generic;
using CinemaChoicesAPI.Models.Cinema;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace CinemaChoicesAPI.Cineworld
{
    public static class GetCineworldCinemasList
    {   
        public static IEnumerable<CineworldCinemaModel> GetCinemaList()
        { 
            List<CineworldCinemaModel> cinemas = new List<CineworldCinemaModel>();
            var url = "http://www.cineworld.com/api/quickbook/cinemas?key=nfhMR3xR";
            //var syncClient = new WebClient();
            //var content = syncClient.DownloadString(url);
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<CineworldCinemaModel>));
            //using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            //{
            //    var cinemaData = (List<CineworldCinemaModel>)serializer.ReadObject(ms);
            //}
            return cinemas;
        }
    }
}
