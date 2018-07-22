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
    
    public class CategoriesService : ICategoriesService
    {
        private readonly HttpClient _httpClient;
        private List<Category> _products;

        public CategoriesService ()
        {
            _httpClient = new HttpClient {MaxResponseContentBufferSize = Constants.MAX_RESPONSE_CONTENT_BUFFER_SIZE};
        }

        /// Obter todas as categorias da api
        public async Task<List<Category>> FetchCategories()
        {
            _products = new List<Category>();
            
            try {
                var uri = new Uri (Constants.CATEGORIES_URL);
                var response = await _httpClient.GetAsync(uri); 
                
                if (response.IsSuccessStatusCode){               
                    var content = await response.Content.ReadAsStringAsync();
                    _products = JsonConvert.DeserializeObject <List<Category>> (content);                    
                }
                
            } catch (Exception ex) {
                Debug.WriteLine (@"ERROR {0}", ex.Message);
            }
            
            return _products;
        }
        
    }
    
}