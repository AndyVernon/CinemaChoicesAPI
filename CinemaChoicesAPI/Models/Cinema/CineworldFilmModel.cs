namespace CinemaChoicesAPI.Models.Cinema
{
    /// <summary>
    /// The model representing a Cineworld Film
    /// </summary>
    public class CineworldFilmModel
    {
        /// <summary>
        /// The Film Edi (Cineworld reference)
        /// </summary>
        public int Edi { get; set; }

        /// <summary>
        /// The Film title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The Film Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Film classification
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// The Film advisory information
        /// </summary>
        public string Advisory { get; set; }

        /// <summary>
        /// The Film poster Url
        /// </summary>
        public string PosterUrl { get; set; }

        /// <summary>
        /// The Film still Url
        /// </summary>
        public string StillUrl { get; set; }

        /// <summary>
        /// The Film film Url
        /// </summary>
        public string FilmUrl { get; set; }
    }
}
