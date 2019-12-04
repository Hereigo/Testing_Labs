using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;

namespace ZdAdoConnectorMvc.Services
{
    public interface IAdoService
    {
        Task<List<WorkItem>> GetWorkItemsAsync(int[] workItemsIds);
    }
}
