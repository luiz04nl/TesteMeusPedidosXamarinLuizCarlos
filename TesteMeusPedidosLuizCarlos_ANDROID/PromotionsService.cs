using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TesteMeusPedidosLuizCarlos_PCL;
using TesteMeusPedidosLuizCarlos_PCL.Models;
using TesteMeusPedidosLuizCarlos_PCL.Services;
using System.Net.Http;

namespace TesteMeusPedidosLuizCarlos
{
    
    public class PromotionsService : IPromotionsService
    {
        private readonly HttpClient _httpClient;

        private List<Promotion> Promotions { get; set; }

        public PromotionsService ()
        {
            _httpClient = new HttpClient {MaxResponseContentBufferSize = 256000};
        }

        public async Task<List<Promotion>> fetchPromotions()
        {
            Promotions = new List<Promotion> ();
            
            var uri = new Uri (Constants.PROMOTIONS_URL);

            try {
                var response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode) {
                    var content = await response.Content.ReadAsStringAsync();
                    Promotions = JsonConvert.DeserializeObject <List<Promotion>> (content);
                }
            } catch (Exception ex) {
                Debug.WriteLine (@"ERROR {0}", ex.Message);
            }

            return Promotions;
        }

//        public async Task SaveTodoItemAsync (TodoItem item, bool isNewItem = false)
//        {
//            var uri = new Uri (Constants.PROMOTIONS_URL);
//
//            try {
//                var json = JsonConvert.SerializeObject (item);
//                var content = new StringContent (json, Encoding.UTF8, "application/json");
//
//                HttpResponseMessage response = null;
//                if (isNewItem) {
//                    response = await client.PostAsync (uri, content);
//                } else {
//                    response = await client.PutAsync (uri, content);
//                }
//				
//                if (response.IsSuccessStatusCode) {
//                    Debug.WriteLine (@"				TodoItem successfully saved.");
//                }
//				
//            } catch (Exception ex) {
//                Debug.WriteLine (@"				ERROR {0}", ex.Message);
//            }
//        }
//
//        public async Task DeleteTodoItemAsync (string id)
//        {
//            var uri = new Uri (Constants.PROMOTIONS_URL);
//
//            try {
//                var response = await client.DeleteAsync (uri);
//
//                if (response.IsSuccessStatusCode) {
//                    Debug.WriteLine (@"				TodoItem successfully deleted.");	
//                }
//				
//            } catch (Exception ex) {
//                Debug.WriteLine (@"				ERROR {0}", ex.Message);
//            }
//        }
    }
}