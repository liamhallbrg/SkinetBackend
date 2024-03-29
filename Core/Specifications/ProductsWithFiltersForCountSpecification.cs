﻿using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductsWithFiltersForCountSpecification(ProductSpecificationParameters productParameters)
            : base(x => (string.IsNullOrEmpty(productParameters.Search) || x.Name.ToLower().Contains(productParameters.Search)) &&
                        (!productParameters.BrandId.HasValue || x.ProductBrandId == productParameters.BrandId) &&
                        (!productParameters.TypeId.HasValue || x.ProductTypeId == productParameters.TypeId)
            )
        {
        }
    }
}
