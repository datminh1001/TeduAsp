using System;
using System.Collections.Generic;
using System.Text;
using TeduAsp.ViewModels.Common;

namespace TeduAsp.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { set; get; }
    }
}
