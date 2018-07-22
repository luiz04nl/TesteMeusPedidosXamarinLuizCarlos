using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TesteMeusPedidosLuizCarlos_PCL.Services;
using Assert = NUnit.Framework.Assert;

namespace TesteMeusPedidosLuizCarlos_TESTES_PCL
{
    [TestClass]
//    [TestFixture]
    public class PromotionsServiceUnitTest
    {
              
        private readonly PromotionsService _promotionsService;

        public PromotionsServiceUnitTest()
        {
            _promotionsService = new PromotionsService();
        } 
        
        /// Teste de obtenção de todas as promoções da api
        [TestMethod]
//        [Test]
        public async Task TestMethodFetchPromotions()
        {            
//             Arrange
            
            // Act
            var promotions =  await _promotionsService.FetchPromotions();

            // Assert   
            Assert.IsTrue(promotions.Count > 0);
//            Assert.That(promotions.Count > 0, Is.True);
            
        }
    }
}