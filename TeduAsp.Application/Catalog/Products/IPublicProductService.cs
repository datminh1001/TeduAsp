using System;
using System.Collections.Generic;
using System.Text;
using TeduAsp.Application.Catalog.Products.Dtos;
using TeduAsp.Application.Catalog.Products.Dtos.Public;
using TeduAsp.Application.Dtos;

namespace TeduAsp.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
