using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using ZdAdoConnectorMvc.Models;
using ZdAdoConnectorMvc.Services;

namespace ZdAdoConnectorMvc.Providers
{
    public class AdoProvider
    {
        private readonly IMapper _mapper;
        private readonly AdoService _adoService;

        public AdoProvider(AdoService adoService, IMapper mapper)
        {
            _adoService = adoService;
            _mapper = mapper;
        }

        public List<AdoWorkItem> GetWorkItems(int[] workItemsIds)
        {
            Task<List<WorkItem>> response = _adoService.GetWorkItemsAsync(workItemsIds);

            List<AdoWorkItem> adoWorkItems = new List<AdoWorkItem>();

            List<WorkItem> workItems = response.Result;

            if (workItems.Count > 0)
            {
                foreach (WorkItem item in workItems)
                {
                    var TEST = _mapper.Map<AdoWorkItem>(item);

                    adoWorkItems.Add(TEST);
                }
            }

            return adoWorkItems;
        }
    }
}
