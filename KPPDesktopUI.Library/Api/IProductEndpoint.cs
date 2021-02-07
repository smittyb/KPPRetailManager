using KPPDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KPPDesktopUI.Library.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}