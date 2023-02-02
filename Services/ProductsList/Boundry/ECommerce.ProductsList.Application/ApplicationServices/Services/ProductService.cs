using ECommerce.ProductsList.Application.ApplicationServices.IServices;
using ECommerce.ProductsList.Application.Contract.DTOs;
using ECommerce.ProductsList.Application.Contract.RespondResult;
using ECommerce.ProductsList.Domain.Enum;
using Newtonsoft.Json;
using System.Net;

namespace ECommerce.ProductsList.Application.ApplicationServices.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient HttpClient;
        public ProductService(IHttpClientFactory httpClient)
        {
            HttpClient = httpClient.CreateClient();
        }

        public async Task<ICustomeRespondResult<List<ProductsDTO>>> ProductList()
        {
            var result = new CustomeRespondResult<List<ProductsDTO>>();

            var listmodel = new List<ProductsDTO>();

            var url = "http://localhost:5058/api/Products/ProductsList";

            var response = await HttpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();

                listmodel = JsonConvert.DeserializeObject<List<ProductsDTO>>(json);

                result.SetResult(listmodel, ResultStatus.Success, Messages.Ok);
            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {
                result.SetResult(null, ResultStatus.NoContent, Messages.NoContent);
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                result.SetResult(null, ResultStatus.Error, Messages.Error);
            }

            return result;
        }
    }
}
