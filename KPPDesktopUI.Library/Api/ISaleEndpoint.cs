using KPPDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace KPPDesktopUI.Library.Api
{
    public interface ISaleEndpoint
    {
        Task PostSale(SaleModel sale);
    }
}