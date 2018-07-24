using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteMeusPedidosLuizCarlos_PCL.Services;
using TesteMeusPedidosLuizCarlos_PCL.Util;

namespace TesteMeusPedidosLuizCarlos_TESTES_PCL
{
    [TestClass]
    public class UtilUnitTest
    {
      
        private readonly CategoriesService _categoriesService;
        private readonly ProductsService _productsService;

        public UtilUnitTest()
        {
            _productsService = new ProductsService();
            _categoriesService = new CategoriesService();
        } 
        
        /// Teste de obtenção de todas as promoções da api
        [TestMethod]
        public async Task TestMethodGetProductsByCategoryId()
        {                        
            // Act
            var products =  await _productsService.FetchProducts();
            var categories =  await _categoriesService.FetchCategories();

            var filter = Util.GetProductsByCategoryId(products, categories[0].Id);

            // Assert   
            Assert.IsNotNull(filter);            
        }
    }
}