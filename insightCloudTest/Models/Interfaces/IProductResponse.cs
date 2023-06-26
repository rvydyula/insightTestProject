using System;
namespace insightCloudTest.Models
{
	public interface IProductResponse
	{
        public List<IProduct> Products { get; set; }
    }
}

