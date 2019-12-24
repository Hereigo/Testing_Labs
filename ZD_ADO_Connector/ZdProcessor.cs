using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ZD_ADO_Connector
{
    internal class ZdProcessor
    {
        public void ApiClientForZendesk()
        {
            // 1. GET ZD-TICKETS 

            GetSomeTickets();

            // SendComment();

            // 2. CHECK  (BY ...) IF ADO NOT CONTAINS THEM YET

            // 3. IF NOT - CREATE NEW IN ADO

        }

        private void GetSomeTickets()
        {
            const long adoCustomFieldId = 360004572998;

            const string adoTicketsTag = "azure";

            // "custom_fields": [{"id": 360004572998, ... (my own created ID)
            // search possible only by TAG !!!
            string requestByTime = $"{GIT_IGNORE.Variables.ZdApiRootPath}/api/v2/search.json?page=0&query=type:ticket fieldvalue:ado3"; // tags:{adoTicketsTag}";

            // string requestByTime = $"{GIT_IGNORE.Variables.ZdApiRootPath}?page=0&query=type:ticket status:open created>{notEarlierThan.ToString("yyyy-MM-ddTHH:mm:ssZ")}";

            Task<string> response = RequestSend(HttpMethod.Get, requestByTime);

            string rez = response.Result;
            Console.WriteLine(rez);
        }

        private async Task<string> RequestSend(HttpMethod httpMethod, string apiRequest, string jsonToSend = "") //, HttpMethod httpMethod, string jsonToSend)
        {
            //string requestUri = MagicWords.ZendeskRequestBaseUrl + _apiRequest; // "/api/v2/search.json?query=82385";

            HttpRequestMessage request = new HttpRequestMessage(httpMethod, apiRequest);

            request.Headers.Add("Accept", "application/json");// Generated with https://developer.zendesk.com/requests/new

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", GIT_IGNORE.Variables.ZDDevConsoleBearerToken);

            if (httpMethod == HttpMethod.Put)
            {
                string jsonMultiline = jsonToSend.Replace("\r\n", "\\n");

                request.Content = new StringContent(jsonMultiline, System.Text.Encoding.UTF8, "application/json");
            }

            using HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

            string logInformation = $"Tasker.SendRequestToZendesk() status = {response.StatusCode} - path: {apiRequest}";

            if (response.IsSuccessStatusCode)
            {
                //_logger.LogInformation(logInformation);

                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                //_logger.LogError(logInformation);

                return "Error - " + response.StatusCode.ToString();
            }
        }

        private void SendComment(long ticketId = 0, string jsonToSend = "", long supportUserId = 0)
        {
            ticketId = 3;

            supportUserId = 368907442298;

            jsonToSend = "{\"ticket\": { \"comment\": { \"body\": \"My new Internal note =)\", \"public\":\"false\", \"author_id\": " + supportUserId + " }}}";

            string apiRequest = $"{GIT_IGNORE.Variables.ZdApiRootPath}/api/v2/tickets/{ticketId}.json";

            Task<string> response = RequestSend(HttpMethod.Put, apiRequest, jsonToSend);

            string rez = response.Result;
            Console.WriteLine(rez);
        }
    }
}