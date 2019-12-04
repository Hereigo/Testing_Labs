using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

namespace ZdAdoConnectorMvc.Services
{
    public class AdoService : IAdoService
    {
        private readonly VssBasicCredential _credentials;
        private readonly VssConnection _connection;
        private readonly WorkItemTrackingHttpClient _witClient;
        private readonly string _project;

        public AdoService()
        {
            _project = GIT_IGNORE.Variables.AdoProjectHotmail;

            _credentials = new VssBasicCredential(string.Empty, GIT_IGNORE.Variables.AdoPatHotmail);

            // Create a connection object, which we will use to get httpclient objects. This is more robust then newing up httpclient objects directly.  
            _connection = new VssConnection(new Uri(GIT_IGNORE.Variables.AdoNsHotmail), _credentials);

            // Create instance of WorkItemTrackingHttpClient using VssConnection
            _witClient = _connection.GetClient<WorkItemTrackingHttpClient>();
        }

        public Task<List<WorkItem>> GetWorkItemsAsync(int[] workItemsIds)
        {
            try
            {
                return _witClient.GetWorkItemsAsync(workItemsIds);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
