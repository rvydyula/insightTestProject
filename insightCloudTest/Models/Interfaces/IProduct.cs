using System;
namespace insightCloudTest.Models
{
	public interface IProduct
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
}

