using KPPDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KPPDesktopUI.Library.Api
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAll();
    }
}