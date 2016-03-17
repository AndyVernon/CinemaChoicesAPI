using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CinemaChoicesAPI.Models.Cinema
{
    [DataContract]
    public class CineworldCinemaModel
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string cinema_url { get; set; }
    }
}
