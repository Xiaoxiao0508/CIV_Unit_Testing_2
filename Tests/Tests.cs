using System;
using Xunit;
using MiscLib;
namespace Tests
{
    public class MiscLibTests
    {
        // ------------------------method 1-----------------------------------------------------
        [Theory]
        [InlineData(12, 2, 4)]
        [InlineData(22, 5, 6)]
        [InlineData(8, 3, 1)]
        public void CalcRectPerimeter_test(int expection, int length, int width)
        {
            GroupTwoFunctions G1 = new GroupTwoFunctions();
            Assert.Equal(expection, G1.CalcRectPerimeter(length, width));
        }
        // ----------------------------------method 2----------------------------------------------
        [Theory]
        [InlineData(true, 3)]
        [InlineData(true, 6)]
        [InlineData(false, 2)]
        [InlineData(false, 20)]
        public void IsTriangularNum_test(bool expected, int input)
        {
            GroupTwoFunctions G1 = new GroupTwoFunctions();
            var result = G1.IsTriangularNum();
            Assert.Equal(expected, result);
        }
        // --------------------------method 3-------------------------------------------------------

        [Theory]
        [InlineData(0, 32)]
        [InlineData(38, 100)]
        [InlineData(82, 180)]
        [InlineData(-73, -100)]
        public void FarenheitToCelcius_test(int expected, int input)
        {
            GroupTwoFunctions G1 = new GroupTwoFunctions();
            ;
            Assert.Equal(expected, G1.FarenheitToCelcius());
        }
        // ---------------------------------method 4-------------------------------------------------
        [Theory]
        [InlineData(true, "Iamhere ")]
        [InlineData(true, " Iamhere")]
        [InlineData(false, "Iamhere")]
        [InlineData(false, "Iam here")]
        public void CheckWhiteSpace_test(bool expected, int input)
        {
            GroupTwoFunctions G1 = new GroupTwoFunctions();
            ;
            var result = G1.CheckWhiteSpace();
            Assert.Equal(expected, result);
        }
        // --------------------------------------method 5------------------------------------------------------
        [Theory]
        [InlineData("YeS", "yes")]
        [InlineData("WeAtHeR", "weather")]
        [InlineData("LuNcH", "LuNCH")]
        [InlineData("Tests", "TEST")]
        public void CamelString_test(string expected, string input)
        {
            GroupTwoFunctions G1 = new GroupTwoFunctions();
            ;
            Assert.Equal(expected, G1.CamelString());
        }
        // -------------------------------------------method 6----------------------------------------

        [Theory]
        [InlineData(3, "yes")]
        [InlineData(7, "WEATHER")]
        [InlineData(8, "LuNCH123")]
        [InlineData(5, "12345")]
        public void CountDigits_test(int expected, string input)
        {
            GroupTwoFunctions G1 = new GroupTwoFunctions();
            ;
            Assert.Equal(expected, G1.CountDigits());
        }

    }
}
