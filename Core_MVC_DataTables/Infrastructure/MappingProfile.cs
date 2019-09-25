using AutoMapper;
using Core_MVC_DataTables.Models;

namespace Core_MVC_DataTables.Infrastructure
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<UserModel, UserViewModel>();
		}
	}
}
