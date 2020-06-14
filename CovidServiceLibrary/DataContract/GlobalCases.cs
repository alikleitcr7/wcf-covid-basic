using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CovidServiceLibrary.DataContract
{

    [DataContract]
    public class GlobalCases
    {

        [DataMember(Name = "Global")]
        public Global Global { get; set; }

        [DataMember(Name = "Countries")]
        public IList<CountryEntry> Countries { get; set; }

        [DataMember(Name = "Date")]
        public DateTime Date { get; set; }
    }
}
