using System.Threading.Tasks;
using KPPDesktopUI.Models;

namespace KPPDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}