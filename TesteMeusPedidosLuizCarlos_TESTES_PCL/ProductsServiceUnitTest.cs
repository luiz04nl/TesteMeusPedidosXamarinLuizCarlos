using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteMeusPedidosLuizCarlos_PCL.Services;
using Assert = NUnit.Framework.Assert;

namespace TesteMeusPedidosLuizCarlos_TESTES_PCL
{
    [TestClass]
    public class ProductsServiceUnitTest
    {
              
        private readonly ProductsService _productsService;

        public ProductsServiceUnitTest()
        {
            _productsService = new ProductsService();
        } 
        
        /// Teste de obtenção de todas as promoções da api
        [TestMethod]
        public async Task TestMethodFetchProducts()
        {                        
            // Act
            var products =  await _productsService.FetchProducts();

            // Assert   
            Assert.IsTrue(products.Count > 0);            
        }
    }
}