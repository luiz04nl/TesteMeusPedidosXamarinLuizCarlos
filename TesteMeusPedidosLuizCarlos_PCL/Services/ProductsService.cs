using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TesteMeusPedidosLuizCarlos_PCL.Models;
using TesteMeusPedidosLuizCarlos_PCL.Services.Interfaces;

namespace TesteMeusPedidosLuizCarlos_PCL.Services
{
    
    public class ProductsService : IProductsService
    {
        private readonly HttpClient _httpClient;
        private List<Product> _products;

        public ProductsService ()
        {
            _httpClient = new HttpClient {MaxResponseContentBufferSize = Constants.MAX_RESPONSE_CONTENT_BUFFER_SIZE};
        }

        /// Obter todas os produtos da api
        public async Task<List<Product>> FetchProducts()
        {
            _products = new List<Product>();
            
            try {
                var uri = new Uri (Constants.PRODUCTS_URL);
                var response = await _httpClient.GetAsync(uri); 
                
                if (response.IsSuccessStatusCode){               
                    var content = await response.Content.ReadAsStringAsync();
                    _products = JsonConvert.DeserializeObject <List<Product>> (content);                    
                }
                
            } catch (Exception ex) {
                Debug.WriteLine (@"ERROR {0}", ex.Message);
            }
            
            return _products;
        }
        
    }
    
}