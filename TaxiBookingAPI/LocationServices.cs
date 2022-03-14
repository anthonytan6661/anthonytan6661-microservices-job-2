using RestSharp;
using TaxiBookingAPI.Models;

namespace TaxiBookingAPI
{
    public class LocationServices : ILocationServices
    {
        public LocationServices()
        {

        }

        public Location GetLocation()
        {
            var url = "https://api.freegeoip.app/json/?apikey=7322ce70-2741-11ec-a395-7f2b5c241db6";
            var client = new RestClient(url);
            var response = client.ExecuteAsync<Location>(new RestRequest());

            return response.Result.Data;

        }

    }
}
