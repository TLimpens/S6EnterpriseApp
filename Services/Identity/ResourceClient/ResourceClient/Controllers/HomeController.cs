using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityModel.Client;

namespace ResourceClient.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {

            //retrieve acces token
            var serverClient = _httpClientFactory.CreateClient();

            var discoveryDocument = await serverClient.GetDiscoveryDocumentAsync("https://localhost:5001/");


            var tokenResponse = await serverClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest {
            
                Address = discoveryDocument.TokenEndpoint,

                ClientId = "client_id",
                ClientSecret = "client_secret",

                Scope = "ResourceServer"
            });

            //retrive secret data
            var apiClient = _httpClientFactory.CreateClient();

            apiClient.SetBearerToken(tokenResponse.AccessToken);

            var response = await apiClient.GetAsync("https://localhost:5003/secret");

            var content = await response.Content.ReadAsStringAsync();

            return Ok(new {
            
                acces_token = tokenResponse.AccessToken,
                message = content,
            
            });
        }
    }
}