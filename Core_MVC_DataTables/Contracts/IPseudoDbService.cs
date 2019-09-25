using Core_MVC_DataTables.Models;
using JqueryDataTables.ServerSide.AspNetCoreWeb;
using System.Threading.Tasks;

namespace Core_MVC_DataTables.Contracts
{
    public interface IPseudoDbService
    {
        // Processing Data on Client :
        UserModel[] Get500Users();

        // Server-Side Processing :
        Task<UserViewModel[]> GetUsersAsync(DTParameters parameters);
    }
}