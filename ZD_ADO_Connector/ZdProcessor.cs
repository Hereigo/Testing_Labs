using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ZD_ADO_Connector
{
    internal class ZdProcessor
    {
        //private HttpMethod httpMethod = HttpMethod.Get;

        public void ZendeskApiClient()
        {
            const long adoCustomFieldId = 360004572998;

            const string adoTicketsTag = "azure";

            // 1. GET ZD-TICKETS CREATED NOT MORE THAN ... ( X HOURS AGO )

            // string requestByTime = $"{GIT_IGNORE.Variables.ZdApiRootPath}?page=0&query=type:ticket status:open created>{notEarlierThan.ToString("yyyy-MM-ddTHH:mm:ssZ")}";
            // Add 5 hours for the difference of Time Zones :
            DateTime notEarlierThan = DateTime.Now.AddHours(-30);

            // "custom_fields": [{"id": 360004572998, ... (my own created ID)
            // search possible only by TAG !!!
            string requestByTime = $"{GIT_IGNORE.Variables.ZdApiRootPath}?page=0&query=type:ticket tags:{adoTicketsTag}";

            Task<string> response = RequestSend(requestByTime);

            string rez = response.Result;


            Console.WriteLine(rez);
            // 2. CHECK  (BY ...) IF ADO NOT CONTAINS THEM YET

            // 3. IF NOT - CREATE NEW IN ADO

        }

        private async Task<string> RequestSend(string _apiRequest) //, HttpMethod httpMethod, string jsonToSend)
        {
            //string requestUri = MagicWords.ZendeskRequestBaseUrl + _apiRequest; // "/api/v2/search.json?query=82385";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, _apiRequest);

            request.Headers.Add("Accept", "application/json");// Generated with https://developer.zendesk.com/requests/new

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", GIT_IGNORE.Variables.ZDDevConsoleBearerToken);

            //request.Content = new StringContent(jsonToSend, System.Text.Encoding.UTF8, "application/json");

            using HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

            string logInformation = $"Tasker.SendRequestToZendesk() status = {response.StatusCode} - path: {_apiRequest}";

            if (response.IsSuccessStatusCode)
            {
                //_logger.LogInformation(logInformation);

                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                //_logger.LogError(logInformation);

                return response.StatusCode.ToString();
            }
        }



        //
    }
}
