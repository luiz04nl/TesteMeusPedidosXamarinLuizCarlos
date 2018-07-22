using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteMeusPedidosLuizCarlos_PCL.Services;
using Assert = NUnit.Framework.Assert;

namespace TesteMeusPedidosLuizCarlos_TESTES_PCL
{
    [TestClass]
    public class CategoriesServiceUnitTest
    {
              
        private readonly CategoriesService _categoriesService;

        public CategoriesServiceUnitTest()
        {
            _categoriesService = new CategoriesService();
        } 
        
        /// Teste de obtenção de todas as promoções da api
        [TestMethod]
        public async Task TestMethodFetchCategories()
        {                        
            // Act
            var categories =  await _categoriesService.FetchCategories();

            // Assert   
            Assert.IsTrue(categories.Count > 0);            
        }
    }
}