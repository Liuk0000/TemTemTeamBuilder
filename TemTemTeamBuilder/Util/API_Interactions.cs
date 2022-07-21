using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemTemTeamBuilder.Util
{
    public class API_Interactions
    {

        public static string GetAllTemsAsString()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(LocalStorageHandler.Properties()["GetAllLink"]).Result;

            client.Dispose();

            var result = response.Content.ReadAsStringAsync().Result;
            return result;

        }
    }
}
