using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeduAsp.ViewModels.Catalog.Products;
using TeduAsp.ViewModels.Catalog.Products.Public;
using TeduAsp.ViewModels.Common;

namespace TeduAsp.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
