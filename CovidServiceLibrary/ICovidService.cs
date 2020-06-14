using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using CovidServiceLibrary.DataContract;
using CovidServiceLibrary.DataContract.Parameters;

namespace CovidServiceLibrary
{
    [ServiceContract]
    public interface ICovidService
    {
        [OperationContract]
        Task<Global> GetGlobalCases();

        [OperationContract]
        Task<List<CountryCaseByDate>> GetByCountry(GetByCountryLiveParamters parameters);

        [OperationContract]
        Task<List<Country>> GetCountries();
    }
}