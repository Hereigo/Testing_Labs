using AutoMapper;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using ZdAdoConnectorMvc.Models;

namespace ZdAdoConnectorMvc.Utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Mapping <Source, Destination> :

            CreateMap<WorkItemCommentVersionRef, CommentVersionRef>();

            CreateMap<WorkItem, AdoWorkItem>().ForAllMembers(opt => opt.AllowNull());
        }
    }
}
