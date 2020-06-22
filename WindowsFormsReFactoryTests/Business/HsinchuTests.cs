using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsReFactory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsReFactory.Model;

namespace WindowsFormsReFactory.Business.Tests
{
    [TestClass()]
    public class HsinchuTests
    {
        /// <summary>
        ///GetILogistics 的測試
        ///</summary>
        [TestMethod()]
        public void GetILogisticsTest_Get新竹貨運()
        {
            //arrange
            string p = "2";
            Product product = new Product();
            ILogistics expected = new Hsinchu();

            ILogistics actual;

            //act
            actual = FactoryRepository.GetILogistics(p, product);

            //assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod()]
        public void HsinchuTest()
        {
           
        }

        [TestMethod()]
        public void CalculateTest()
        {
            Hsinchu target = new Hsinchu()
            {
                ShipProduct = new Product
                {
                    IsNeedCool = true,
                    Name = "商品測試1",
                    Size = new Size
                    {
                        Height = 10,
                        Length = 30,
                        Width = 20
                    },
                    Weight = 10
                }
            };

            //act
            target.Calculate();

            //assert
            var expectedName = "新竹貨運";
            var expectedFee = 254.16;

            var actualName = target.GetsComapanyName();
            var actualFee = target.GetsFee();

            //assert
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedFee, actualFee);
        }

        [TestMethod()]
        public void GetsComapanyNameTest()
        {
            Hsinchu target = new Hsinchu();
            string expected = "新竹貨運";
            string actual;
            actual = target.GetsComapanyName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetsFeeTest()
        {
            Hsinchu target = new Hsinchu();
            double expected = 0F;
            double actual;
            actual = target.GetsFee();
            Assert.AreEqual(expected, actual);
        }
    }
}