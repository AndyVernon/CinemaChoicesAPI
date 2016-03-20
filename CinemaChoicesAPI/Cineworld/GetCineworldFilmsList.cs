using CinemaChoicesAPI.Models.Cinema;
using System;
using System.Collections.Generic;
using System.Data;

namespace CinemaChoicesAPI.Cineworld
{
    public class GetCineworldFilmsList : BaseCineworldList
    {
        public IEnumerable<CineworldFilmModel> GetFilmsForCinema(int cinemaId)
        {
            List<CineworldFilmModel> films = new List<CineworldFilmModel>();
            var url = string.Format("http://www2.cineworld.co.uk/api/quickbook/films?key=nfhMR3xR&cinema={0}", cinemaId);
            var dataTable = _cineworldHelpers.ReadJsonIntoDataTable(url, "films");
            foreach (DataRow row in dataTable.Rows)
            {
                CineworldFilmModel film = new CineworldFilmModel();
                film.Edi = Convert.ToInt32(row[0]);
                film.Title = (string)row[1];
                films.Add(film);
            }
            return films;
        }
    }
}
