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
    
    public class PromotionsService : IPromotionsService
    {
        private readonly HttpClient _httpClient;
        private List<Promotion> _promotions;

        public PromotionsService ()
        {
            _httpClient = new HttpClient {MaxResponseContentBufferSize = Constants.MAX_RESPONSE_CONTENT_BUFFER_SIZE};
        }

        /// Obter todas as promoções da api
        public async Task<List<Promotion>> FetchPromotions()
        {
            _promotions = new List<Promotion>();
            
            try {
                var uri = new Uri (Constants.PROMOTIONS_URL);
                var response = await _httpClient.GetAsync(uri); 
                
                if (response.IsSuccessStatusCode){               
                    var content = await response.Content.ReadAsStringAsync();
                    _promotions = JsonConvert.DeserializeObject <List<Promotion>> (content);                    
                }
                
            } catch (Exception ex) {
                Debug.WriteLine (@"ERROR {0}", ex.Message);
            }
            
            return _promotions;
        }

//        /// Salva nova promoção na api
//        /// <param name="Int1">Used to indicate status.</param>
//        public async Task PostPromotion(Promotion promotion)
//        {
//            var uri = new Uri (Constants.PROMOTIONS_URL);
//
//            try {
//                var json = JsonConvert.SerializeObject (promotion);
//                var content = new StringContent (json, Encoding.UTF8, "application/json");
//
//                var response = await _httpClient.PostAsync (uri, content);
//                if (response.IsSuccessStatusCode) {
//                    Debug.WriteLine (@"Promotion successfully saved.");
//                }
//				
//            } catch (Exception ex) {
//                Debug.WriteLine (@"ERROR {0}", ex.Message);
//            }
//        }
//
//        public async Task DeletePromotion(string id)
//        {
//            var uri = new Uri (Constants.PROMOTIONS_URL);
//
//            try {
//                var response = await _httpClient.DeleteAsync (uri);
//                if (response.IsSuccessStatusCode) {
//                    Debug.WriteLine (@"Promotion successfully deleted.");	
//                }
//				
//            } catch (Exception ex) {
//                Debug.WriteLine (@"ERROR {0}", ex.Message);
//            }
//        }
        
    }
    
}