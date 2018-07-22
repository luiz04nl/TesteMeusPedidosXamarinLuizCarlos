////using Microsoft.VisualStudio.TestTools.UnitTesting;
////using TesteMeusPedidosLuizCarlos_PCL.Services;
////
////namespace TesteMeusPedidosLuizCarlos_TESTES_PCL
////{
////    [TestClass]
////    public class PromotionsServiceTest
////    {
////        private readonly PromotionsService _promotionsService;
////
////        public PromotionsServiceTest()
////        {
////            _promotionsService = new PromotionsService();
////        } 
//// 
////        /// Teste de obtenção de todas as promoções da api
////        [TestMethod]
////        private async void FetchPromotionsTest()
////        {
////            // Arrange
////            
////            // Act
////            var promotions =  await _promotionsService.FetchPromotions();
////
////            // Assert   
////            Assert.IsTrue(promotions.Count > 0);
////
////        }
////        
////    }
////}
//
//using NUnit.Framework;
//using TesteMeusPedidosLuizCarlos_PCL.Services;
//
//namespace TesteMeusPedidosLuizCarlos_TESTES_PCL
//{
//    [TestFixture]
//    public class PromotionsServiceTest
//    {
//        private readonly PromotionsService _promotionsService;
//
//        public PromotionsServiceTest()
//        {
//            _promotionsService = new PromotionsService();
//        } 
//
//       
//        [Test]
//        private async void FetchPromotionsTest()
//        {
//            // Arrange
//            
//            // Act
//            var promotions =  await _promotionsService.FetchPromotions();
//
//            // Assert               
//            Assert.That(promotions.Count > 0, Is.True);
//
//        }
//    }
//}