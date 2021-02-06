using System.Threading.Tasks;
using KPPDesktopUI.Library.Models;


namespace KPPDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}