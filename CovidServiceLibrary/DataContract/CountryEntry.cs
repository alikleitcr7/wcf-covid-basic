using System;
using System.Runtime.Serialization;

namespace CovidServiceLibrary.DataContract
{
    [DataContract]
    public class CountryEntry
    {

        [DataMember(Name = "Country")]
        public string Country { get; set; }

        [DataMember(Name = "CountryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        [DataMember(Name = "NewConfirmed")]
        public int NewConfirmed { get; set; }

        [DataMember(Name = "TotalConfirmed")]
        public int TotalConfirmed { get; set; }

        [DataMember(Name = "NewDeaths")]
        public int NewDeaths { get; set; }

        [DataMember(Name = "TotalDeaths")]
        public int TotalDeaths { get; set; }

        [DataMember(Name = "NewRecovered")]
        public int NewRecovered { get; set; }

        [DataMember(Name = "TotalRecovered")]
        public int TotalRecovered { get; set; }

        [DataMember(Name = "Date")]
        public DateTime Date { get; set; }
    }
}
