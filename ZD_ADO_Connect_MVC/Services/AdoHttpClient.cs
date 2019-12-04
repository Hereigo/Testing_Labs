using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ZdAdoConnectorMvc.Services
{
    internal static class AdoHttpClient
    {
        // GET PROJECTS LIST FOR MY-TEST ONLY ! NOT WORK FOR PROD ...

        public static async Task<string> GetProjects()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(
                        string.Format("{0}:{1}", "", GIT_IGNORE.Variables.AdoPatHotmail))));

                    using (HttpResponseMessage response = await client.GetAsync(GIT_IGNORE.Variables.AdoNsHotmail +
                        "/_apis/projects?api-version=5.1").ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();

                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
