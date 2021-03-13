using NUnit.Framework;
using System;

namespace GenericMedicine.UnitTest
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

        // NUnit test cases for Create Medicine detail
        [Test]
        [TestCase("string", "string", "string", "2021-03-20", 1)]
        public void CreateMedicineDetail_WhenCalled_ReturnMedicine(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

            Assert.That(result, Is.TypeOf<Medicine>());
        }

        [Test]
        [TestCase("string", null, "string", "2021-03-20", 1)]
        [TestCase("string", "", "string", "2021-03-20", 1)]
        public void CreateMedicineDetail_MedicineNameIsNullOrEmpty_RaiseExcception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [Test]
        [TestCase("string", "string", "string", "2021-03-20", 0)]
        [TestCase("string", "string", "string", "2021-03-20", -1)]
        public void CreateMedicineDetail_PricePerStripIsLessThanOrEqualZero_RaiseExcception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [Test]
        [TestCase("string", "string", "string", "2020-03-20", 1)]
        public void CreateMedicineDetail_ExpiryDateLessThanCurrentDate_RaiseExcception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        // NUnit test cases for Carton detail
        [Test]
        [TestCase(1, "2021-03-20", "string")]
        public void CreateCartonDetail_WhenCalled_ReturnCartonDetail(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var medicine = new Medicine()
            {
                Name = "string",
                GenericMedicineName = "string",
                Composition = "string",
                ExpiryDate = new DateTime(2021, 5, 8),
                PricePerStrip = 1
            };

            var result = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine);

            Assert.That(result, Is.TypeOf<CartonDetail>());
        }

        [Test]
        [TestCase(0, "2021-03-20", "string")]
        [TestCase(-1, "2021-03-20", "string")]
        public void CreateCartonDetail_MedicineStripCountIsLessOrEqualZero_RaiseException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var medicine = new Medicine()
            {
                Name = "string",
                GenericMedicineName = "string",
                Composition = "string",
                ExpiryDate = new DateTime(2021, 4, 7),
                PricePerStrip = 1
            };

            Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine));
        }

        [Test]
        [TestCase(1, "2022-03-08", "string")]
        [TestCase(1, "2020-04-08", "string")]
        public void CreateCartonDetail_LaunchDateLessThanCurrentDate_RaiseException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var medicine = new Medicine()
            {
                Name = "string",
                GenericMedicineName = "string",
                Composition = "string",
                ExpiryDate = new DateTime(2022, 5, 8),
                PricePerStrip = 1
            };

            Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine));
        }

        [Test]
        [TestCase(1, "2021-03-20", "string", null)]
        public void CreateCartonDetail_IfMedicineIsNull_ReturnNull(int medicineStripCount, DateTime launchDate, string retailerAddress, Medicine medicine)
        {
            var result = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}
