using System;
using System.Collections.Generic;
using System.Text;
using TeduAsp.Application.Dtos;

namespace TeduAsp.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { set; get; }
    }
}
