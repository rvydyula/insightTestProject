using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using insightCloudTest.Models;
using System.Text;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace insightCloudTest.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        private const int CurrentVersion = 3; // Can be set as environment variable
        private const int MinVersion = 2;// Can be set as environment variable
        private const int MaxPageSize = 100;


        [HttpGet("{version}")]
        public Task<IActionResult> GetProducts(
            [FromHeader(Name = "x-v")] int xV,
            [FromQuery(Name = "effective")] string effective = "CURRENT",
            [FromQuery(Name = "updated-since")] DateTime? updatedSince = null,
            [FromQuery(Name = "brand")] string brand = null,
            [FromQuery(Name = "product-category")] string productCategory = null,
            [FromQuery(Name = "page")] int page = 1,
            [FromQuery(Name = "page-size")] int pageSize = 25,
            [FromHeader(Name = "x-min-v")] int? xMinV = null)
        {

            try
            {
                string headers = $"x-v: {xV}\r\n";
                #region Validations

                if (xMinV.HasValue)
                {
                    if (!(xMinV >= MinVersion && xV <= CurrentVersion))
                    {
                        // Return Unsupported Version error
                        var errorMessage = $"Unsupported version. Supported Min version: {MinVersion}";
                        return Task.FromResult<IActionResult>(BadRequest(errorMessage));
                    }
                }
                else
                {
                    if (!(xV == CurrentVersion))
                    {
                        // Return Unsupported Version error
                        var errorMessage = $"Unsupported version. Supported version: {CurrentVersion}";
                        return Task.FromResult<IActionResult>(BadRequest(errorMessage));
                    }
                }


                if (page <= 0 || pageSize <= 0 || pageSize > MaxPageSize)
                {
                    // Return Invalid Page error
                    var errorMessage = $"Invalid page or pageSize. Page: {page}, PageSize: {pageSize}";
                    return Task.FromResult<IActionResult>(BadRequest(errorMessage));
                }

                if (updatedSince == null || updatedSince <= DateTime.Today)
                {
                    // Return Invalid Page error
                    var errorMessage = $"Invalid Date";
                    return Task.FromResult<IActionResult>(BadRequest(errorMessage));
                }

                #endregion

                // Simulated data for demonstration purposes
                var products = new ProductsResponse();

                //Get the PRODUCTS data froom wither database or from other means
                //Can use repository pattern

                // Return the products as an IActionResult
                return Task.FromResult<IActionResult>(Ok(products));
            }
            catch
            {
                return Task.FromResult<IActionResult>(StatusCode(500, "An error occurred while retrieving the data."));
            }


        }


        [HttpPost]
        public IActionResult AddProduct(IProduct product)
        {

            bool isSuccess = true;
            string message = string.Empty;
            
            
            try
            {
                //add logic to add the product
            }
            catch (Exception e)
            {
                isSuccess = false;
                message = e.Message;
                return StatusCode(500, "An error occurred while adding the product." + message);
            }
            finally
            {

                if (isSuccess)
                {
                    //Send Notification after the product is added successfully from front-end
                    message = $"Product {product.ProductId}, {product.Name} added successfully";
                    var result = SendMessage(message);
                }

            }

            return Ok("Product added successfully.");

        }

        private bool SendMessage(string message)
        {
            bool success = true;
            try
            {
                // Retrieve the connection string and queue name from your configuration
                string connectionString = "<ServiceBusConnectionString>";
                string queueName = "<QueueName>";

                //// Create a new Service Bus message
                //var serviceBusMessage = new Message(Encoding.UTF8.GetBytes(message));

                //// Create a new instance of QueueClient using the connection string and queue name
                //var queueClient = new QueueClient(connectionString, queueName);

                //// Send the message to the Service Bus queue
                //await queueClient.SendAsync(serviceBusMessage);

                //// Close the queue client to release resources
                //await queueClient.CloseAsync();

              
            }
            catch
            {
                success = false;
            }

            return success;
        }
    }
}

