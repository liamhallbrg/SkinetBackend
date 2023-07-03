using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductSpecificationParameters
    {
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1;

        private int pageSize = 6;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        public int? TypeId { get; set; }
        public int? BrandId { get; set; }
        public string Sort { get; set; }


        private string search;
        public string Search
        {
            get { return search; }
            set { search = value.ToLower(); }
        }


    }
}
