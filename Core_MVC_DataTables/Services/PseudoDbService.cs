using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core_MVC_DataTables.Contracts;
using Core_MVC_DataTables.Models;
using JqueryDataTables.ServerSide.AspNetCoreWeb;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Core_MVC_DataTables.Services
{
    public class PseudoDbService : IPseudoDbService
    {
        private readonly DatabaseContext _context;

        private readonly IConfigurationProvider _mappingConfiguration;

        public PseudoDbService(DatabaseContext context, IConfigurationProvider mappingConfiguration)
        {
            _context = context;
            _mappingConfiguration = mappingConfiguration;
        }

        public async Task<UserViewModel[]> GetUsersAsync(DTParameters tableParams)
        {
            IQueryable<UserModel> query = _context.Users;

            query = new SearchOptionsProcessor<UserViewModel, UserModel>().Apply(query, tableParams.Columns);
            query = new SortOptionsProcessor<UserViewModel, UserModel>().Apply(query, tableParams);

            UserViewModel[] users = await query
                .AsNoTracking()
                .Skip(tableParams.Start - 1 * tableParams.Length)
                .Take(tableParams.Length)
                .ProjectTo<UserViewModel>(_mappingConfiguration)
                .ToArrayAsync();

            return users;
        }

        public UserModel[] Get500Users()
        {
            return _context.Users.Take(500).ToArray();
        }
    }
}