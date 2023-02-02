using ECommerce.Products.Application.ApplicationServices.IServices;
using ECommerce.Products.Application.Contract.DTOs;
using ECommerce.Products.Application.Contract.RespondResult;
using ECommerce.Products.Domain.Enum;
using Newtonsoft.Json;
using System.Net;

namespace ECommerce.Products.Application.ApplicationServices.Services
{
    public class ProductsServices : IProductsServices
    {
        private readonly HttpClient HttpClient;
        public ProductsServices(IHttpClientFactory httpClient)
        {
            HttpClient = httpClient.CreateClient();
        }

        public async Task<ICustomeRespondResult<ProductsDTO>> GetProductAsync(int id)
        {
            var result = new CustomeRespondResult<ProductsDTO>();

            var url = $"http://localhost:5058/api/Products/Products?id={id}";

            var response = await HttpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                
                var model = JsonConvert.DeserializeObject<ProductsDTO>(json);

                result.SetResult(model, ResultStatus.Success, Messages.Ok);
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
