using System;
namespace insightCloudTest.Models
{
	public interface IAdditionalInformation
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
}

