using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
using ZdAdoConnectorMvc.Utils;

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

        // Execute a WIQL (Work Item Query Language) query to return a list of open bugs.

        public async Task<IList<WorkItem>> QueryOpenBugs(string project, string[] fields)
        {
            var credentials = new VssAadCredential(GIT_IGNORE.Variables.AdoMagicWord1, GIT_IGNORE.Variables.AdoMagicWord2);

            // create a wiql object and build our query
            var wiql = new Wiql()
            {
                // NOTE: Even if other columns are specified, only the ID & URL will be available in the WorkItemReference
                Query = "Select [Id] " +
                        "From WorkItems " +
                        "Where [Work Item Type] = 'Task' " +
                        "And [System.TeamProject] = '" + project + "' " +
                        "And [System.State] <> 'Closed' " +
                        "Order By [State] Asc, [Changed Date] Desc",
            };

            // create instance of work item tracking http client
            using (var httpClient = new WorkItemTrackingHttpClient(new Uri(GIT_IGNORE.Variables.AdoUri__PROD__), credentials))
            {
                // execute the query to get the list of work items in the results
                var result = await httpClient.QueryByWiqlAsync(wiql).ConfigureAwait(false);

                var ids = result.WorkItems.Select(item => item.Id).ToArray();

                // some error handling
                if (ids.Length == 0)
                {
                    return Array.Empty<WorkItem>();
                }

                // get work items for the ids found in query
                return await httpClient.GetWorkItemsAsync(ids, fields, result.AsOf).ConfigureAwait(false);
            }
        }

        // PRINTING REZULTS :

        public async Task PrintOpenBugsAsync(string project, string[] fields)
        {
            IList<WorkItem> workItems = await this.QueryOpenBugs(project, fields).ConfigureAwait(false);

            Console.WriteLine("Query Results: {0} items found", workItems.Count);

            // loop though work items and write to console
            foreach (var workItem in workItems)
            {
                Console.WriteLine(
                    "{0}\t{1}\t{2}",
                    workItem.Id,
                    workItem.Fields["System.Title"],
                    workItem.Fields["System.State"],
                    workItem.Fields[fields[3]]
                    );
            }
        }

        // ==================================================

        internal WorkItem CreateIssueUsingClientLib()
        {
            const string newItemType = "Issue";

            JsonPatchDocument patchDocument = JsonPatchDocumentToCreateOrUpdate();

            WorkItemTrackingHttpClient workItemTrackingHttpClient = _connection.GetClient<WorkItemTrackingHttpClient>();

            try
            {
                WorkItem result = workItemTrackingHttpClient.CreateWorkItemAsync(patchDocument, _project, newItemType).Result;

                Console.WriteLine($"{newItemType} Successfully Created : {newItemType} #{result.Id}");

                return result;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Error creating {newItemType} : {ex.InnerException.Message}");
                return null;
            }
        }

        internal void GetWorkItems()
        {
            // Get 200 items maximum ! GetWorkItemsAsync
            WorkItemTrackingHttpClient workItemTrackingHttpClient = _connection.GetClient<WorkItemTrackingHttpClient>();

            // var REZ = workItemTrackingHttpClient.GetWorkItemsBatchAsync(...
            var REZ = workItemTrackingHttpClient.GetWorkItemsAsync(new int[] { 21022, 21032, 21033 });

            var FinRez = REZ.Result;

        }

        private JsonPatchDocument JsonPatchDocumentToCreateOrUpdate()
        {
            return new JsonPatchDocument
            {
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = Strings.operationTitle,
                    Value = "Bla-bla-bla New Task."
                },
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = Strings.operationReproSteps,
                    Value = "Our authorization logic needs to allow for users with Microsoft accounts (formerly Live Ids) - http:// msdn.microsoft.com/library/live/hh826547.aspx"
                },
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = Strings.operationPriority,
                    Value = "1"
                },
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = Strings.operationSeverity,
                    Value = "2 - High"
                }
            };
        }

        internal WorkItem UpdateWorkItemAsyncUsingClientLib(int itemIdToUpdate)
        {
            JsonPatchDocument patchDocument = JsonPatchDocumentToCreateOrUpdate();

            WorkItemTrackingHttpClient workItemTrackingHttpClient = _connection.GetClient<WorkItemTrackingHttpClient>();

            try
            {
                WorkItem result = workItemTrackingHttpClient.UpdateWorkItemAsync(patchDocument, itemIdToUpdate).Result;

                Console.WriteLine($"Item #{itemIdToUpdate} Successfully Updated : Item #{result.Id}");

                return result;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Error updating Item #{itemIdToUpdate} : {ex.InnerException.Message}");
                return null;
            }
        }


        // ==================================================


        internal static void Run()
        {


            // Create a connection object, which we will use to get httpclient objects.  This is more robust
            // then newing up httpclient objects directly.  Be sure to send in the full collection uri.
            // For example:  http://myserver:8080/tfs/defaultcollection
            // We are using default VssCredentials which uses NTLM against a Team Foundation Server.  See additional provided
            // examples for creating credentials for other types of authentication.

            VssConnection connection = new VssConnection(new Uri(GIT_IGNORE.Variables.AdoUri__TEST__),
                new VssAadCredential(GIT_IGNORE.Variables.AdoMagicWord1, GIT_IGNORE.Variables.AdoMagicWord2));

            // Create instance of WorkItemTrackingHttpClient using VssConnection
            WorkItemTrackingHttpClient witClient = connection.GetClient<WorkItemTrackingHttpClient>();

            System.Threading.Tasks.Task<List<WorkItem>> workItems = witClient.GetWorkItemsAsync(new int[] { 5, 1 });

            // System.Threading.Tasks.Task<List<WorkItem>> workItems = witClient.GetWorkItemsAsync(new int[] { }, null, DateTime.Now.AddDays(-1));

            // WorkItem result = witClient.CreateWorkItemAsync(patchDocument, _PROJECT, newItemType).Result;

            foreach (var item in workItems.Result)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Url);
                Console.WriteLine();
            }

        }
    }
}
