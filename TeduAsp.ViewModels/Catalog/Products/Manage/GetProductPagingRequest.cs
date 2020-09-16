using System;
using System.Collections.Generic;
using System.Text;
using TeduAsp.ViewModels.Common;

namespace TeduAsp.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { set; get; }

        public List<int> CategoryIds { set; get; }
    }
}
