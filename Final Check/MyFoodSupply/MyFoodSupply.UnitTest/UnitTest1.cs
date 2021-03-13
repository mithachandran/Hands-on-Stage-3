using System;
using NUnit.Framework;

namespace MyFoodSupply.UnitTest
{
    [TestFixture]
    public class UnitTest1
    {

        private Program p;

        [SetUp]
        public void SetUp()
        {
            p = new Program();
        }

        //NUnit Test cases for CreateFoodDetail Method
        [Test]
        [TestCase("string", 2, "2021-03-20", 20.50)]
        public void CreateFoodDetail_WhenCalled_ReturnFoodDetail(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = p.CreateFoodDetail(name, dishType, expiryDate, price);

            Assert.That(result, Is.TypeOf<FoodDetail>());
        }

        [Test]
        [TestCase(null, 2, "2021-03-20", 20.50)]
        [TestCase("", 2, "2021-03-20", 20.50)]
        public void CreateFoodDetail_FoodNameIsNullOrEmpty_RaiseException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("string", 2, "2021-03-20", 0)]
        [TestCase("string", 2, "2021-03-20", -1)]
        public void CreateFoodDetail_PriceLessThanZero_RaiseException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("string", 2, "2020-03-20", 20.50)]
        public void CreateFoodDetail_ExpiryDateLessThanCurrentDate_RaiseException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
        }
        //NUnit Test cases for CreateSupplyDetail Method
        [Test]
        [TestCase(10, "2021-03-20", "string", 10.50)]
        public void CreateSupplyDetail_WhenCalled_ReturnSupplyDetail(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "string",
                DishType = (FoodDetail.Category)1,
                ExpiryDate = new DateTime(2021, 6, 9),
                Price = 30.75
            };

            var result = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem);

            Assert.That(result, Is.TypeOf<SupplyDetail>());
        }

        [Test]
        [TestCase(0, "2021-03-20", "string", 10.50)]
        [TestCase(-1, "2021-03-20", "string", 10.50)]
        public void CreateSupplyDetail_FoodItemCountLessThanZero_RaiseException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "string",
                DishType = (FoodDetail.Category)1,
                ExpiryDate = new DateTime(2021, 5, 8),
                Price = 30.75
            };

            Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem));
        }

        [Test]
        [TestCase(10, "2020-03-20", "string", 10.50)]
        public void CreateSupplyDetail_RequestDateLessThanCurrentDate_RaiseException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "string",
                DishType = (FoodDetail.Category)1,
                ExpiryDate = new DateTime(2021, 5, 8),
                Price = 30.75
            };

            Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem));
        }

        [Test]
        [TestCase(10, "2021-03-20", "string", 10.50, null)]
        public void CreateSupplyDetail_NullFoodDetail_RaiseException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, FoodDetail foodItem)
        {
            foodItem = new FoodDetail();
            var result = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem);

            Assert.That(result, Is.EqualTo(null));
        }


    }
}
