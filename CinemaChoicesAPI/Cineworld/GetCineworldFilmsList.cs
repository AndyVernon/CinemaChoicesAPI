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

        public IEnumerable<CineworldFilmModel> GetFilmsForCinemaWithDetails(int cinemaId)
        {
            List<CineworldFilmModel> films = new List<CineworldFilmModel>();
            var url = string.Format("http://www2.cineworld.co.uk/api/quickbook/films?key=nfhMR3xR&cinema={0}&full=true", cinemaId);
            var dataTable = _cineworldHelpers.ReadJsonIntoDataTable(url, "films");
            foreach (DataRow row in dataTable.Rows)
            {
                CineworldFilmModel film = new CineworldFilmModel();
                film.Edi = Convert.ToInt32(row[0]);
                film.Title = (string)row[1];
                film.Id = Convert.ToInt32(row[2]);
                film.Classification = (string)row[3];
                film.Advisory = (string)row[4];
                film.PosterUrl = (string)row[5];
                film.StillUrl = (string)row[6];
                film.FilmUrl = (string)row[7];
                films.Add(film);
            }
            return films;
        }

        public IEnumerable<CineworldFilmModel> GetAllFilms()
        {
            List<CineworldFilmModel> films = new List<CineworldFilmModel>();
            var url = string.Format("http://www2.cineworld.co.uk/api/quickbook/films?key=nfhMR3xR&full=true");
            var dataTable = _cineworldHelpers.ReadJsonIntoDataTable(url, "films");
            foreach (DataRow row in dataTable.Rows)
            {
                CineworldFilmModel film = new CineworldFilmModel();
                film.Edi = _cineworldHelpers.GetColumnValueAsIntegerOrZero(row, 0);
                film.Title = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 1);
                film.Id = _cineworldHelpers.GetColumnValueAsIntegerOrZero(row, 2);
                film.Classification = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 3);
                film.Advisory = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 4);
                film.PosterUrl = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 5);
                film.StillUrl = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 6);
                film.FilmUrl = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 7);
                films.Add(film);
            }
            return films;
        }
    }
}
