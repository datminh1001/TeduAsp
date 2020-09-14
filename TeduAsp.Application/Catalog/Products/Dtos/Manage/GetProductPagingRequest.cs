using System;
using System.Collections.Generic;
using System.Text;
using TeduAsp.Application.Dtos;

namespace TeduAsp.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { set; get; }

        public List<int> CategoryIds { set; get; }
    }
}
