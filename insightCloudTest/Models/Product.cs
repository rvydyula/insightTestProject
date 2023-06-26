using System;
namespace insightCloudTest.Models
{
    public class ProductsResponse:IProductResponse
    {
        public List<IProduct> Products { get; set; }

        public ProductsResponse()
        {
           
        }
        public ProductsResponse(List<IProduct> products)
        {
            Products = products;
        }
    }

    public class Product:IProduct
    {
        public string ProductId { get; set; }
        public string EffectiveFrom { get; set; }
        public string EffectiveTo { get; set; }
        public string LastUpdated { get; set; }
        public string ProductCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string BrandName { get; set; }
        public string ApplicationUri { get; set; }
        public bool IsTailored { get; set; }
        public IAdditionalInformation AdditionalInformation { get; set; }
        public List<ICardArt> CardArt { get; set; }
    }

    public class AdditionalInformation:IAdditionalInformation
    {
        public string OverviewUri { get; set; }
        public string TermsUri { get; set; }
        public string EligibilityUri { get; set; }
        public string FeesAndPricingUri { get; set; }
        public string BundleUri { get; set; }
        public List<IAdditionalUri> AdditionalOverviewUris { get; set; }
        public List<IAdditionalUri> AdditionalTermsUris { get; set; }
        public List<IAdditionalUri> AdditionalEligibilityUris { get; set; }
        public List<IAdditionalUri> AdditionalFeesAndPricingUris { get; set; }
        public List<IAdditionalUri> AdditionalBundleUris { get; set; }
    }

    public class AdditionalUri:IAdditionalUri
    {
        public string Description { get; set; }
        public string AdditionalInfoUri { get; set; }
    }

    public class CardArt:ICardArt
    {
        public string Title { get; set; }
        public string ImageUri { get; set; }
    }

    public enum EffectiveParameter
    {
        ALL,
        CURRENT,
        FUTURE
    }

    public enum ProductCategory
    {
        BUSINESS_LOANS,
        CRED_AND_CHRG_CARDS,
        LEASES,
        MARGIN_LOANS,
        OVERDRAFTS,
        PERS_LOANS,
        REGULATED_TRUST_ACCOUNTS,
        RESIDENTIAL_MORTGAGES,
        TERM_DEPOSITS,
        TRADE_FINANCE,
        TRANS_AND_SAVINGS_ACCOUNTS,
        TRAVEL_CARDS
    }
}

