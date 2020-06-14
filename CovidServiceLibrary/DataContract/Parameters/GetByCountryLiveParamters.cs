using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CovidServiceLibrary.DataContract.Parameters
{
    [DataContract]
    public class GetByCountryLiveParamters
    {
        [DataMember]
        public string CountryCode { get; set; }
        [DataMember]
        public string From { get; set; }
        [DataMember]
        public string To { get; set; }
    }
}
