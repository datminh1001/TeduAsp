using System;
using System.Collections.Generic;
using System.Text;
using TeduAsp.ViewModels.Common;

namespace TeduAsp.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { set; get; }
        public string LanguageId { get; set; }
        public List<int> CategoryIds { set; get; }
    }
}
