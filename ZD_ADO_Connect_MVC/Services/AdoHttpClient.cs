using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ZdAdoConnectorMvc.Services
{
    internal static class AdoHttpClient
    {
        // GET PROJECTS LIST FOR MY-TEST ONLY ! NOT WORK FOR PROD ...

        public static async void GetProjects()
        {
            try
            {
                // WORK in CORE 3.0 :

                //using HttpClient client = new HttpClient();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                //Convert.ToBase64String(
                //    System.Text.ASCIIEncoding.ASCII.GetBytes(
                //        string.Format("{0}:{1}", "", GIT_IGNORE.Variables.AdoPat))));

                //// PROJECTS :

                //using HttpResponseMessage response = await client.GetAsync(GIT_IGNORE.Variables.AdoUri__TEST__ + "/_apis/projects?api-version=5.1");

                //response.EnsureSuccessStatusCode();

                //string responseBody = await response.Content.ReadAsStringAsync();

                //Console.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        internal static async void GetProjects_OLD()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        Encoding.ASCII.GetBytes(
                            string.Format("{0}:{1}", "", GIT_IGNORE.Variables.AdoPat))));

                    using (HttpResponseMessage response = await client.GetAsync(GIT_IGNORE.Variables.AdoUri__TEST__ + "_apis/projects?api-version=5.1"))
                    {
                        response.EnsureSuccessStatusCode();

                        string responseBody = await response.Content.ReadAsStringAsync();

                        Console.WriteLine(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


    }
}
