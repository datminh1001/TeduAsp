using System;
using System.Collections.Generic;
using System.Text;
using TeduAsp.ViewModels.Common;

namespace TeduAsp.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { set; get; }

        public string LanguageId { set; get; }
    }
}
