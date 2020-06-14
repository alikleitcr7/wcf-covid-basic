using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CovidServiceLibrary.DataContract
{
    [DataContract]
    public class Country
    {

        [DataMember(Name = "Country")]
        public string Name { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        [DataMember(Name = "ISO2")]
        public string ISO2 { get; set; }
    }
}
