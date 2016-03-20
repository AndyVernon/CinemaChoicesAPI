﻿using System.Collections.Generic;
using CinemaChoicesAPI.Models.Cinema;
using System.Net;
using System.Data;
using Newtonsoft.Json;
using System;

namespace CinemaChoicesAPI.Cineworld
{
    public static class GetCineworldCinemasList
    {   
        public static IEnumerable<CineworldCinemaModel> GetCinemaList()
        { 
            List<CineworldCinemaModel> cinemas = new List<CineworldCinemaModel>();
            var url = "http://www.cineworld.com/api/quickbook/cinemas?key=nfhMR3xR";
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(content);
            DataTable dataTable = dataSet.Tables["cinemas"];
            foreach (DataRow row in dataTable.Rows)
            {
                CineworldCinemaModel cinema = new CineworldCinemaModel();
                cinema.Id = Convert.ToInt32(row[0]);
                cinema.Name = (string)row[1];
                cinema.CinemaUrl = (string)row[2];
                cinemas.Add(cinema);
            }
            return cinemas;
        }
    }
}
