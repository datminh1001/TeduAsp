using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeduAsp.Application.Catalog.Products.Dtos;
using TeduAsp.Application.Catalog.Products.Dtos.Public;
using TeduAsp.Application.Dtos;

namespace TeduAsp.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
