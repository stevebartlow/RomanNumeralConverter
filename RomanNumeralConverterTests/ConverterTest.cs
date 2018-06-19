using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralConverter;
using System;
using System.Diagnostics.CodeAnalysis;

namespace RomanNumeralConverterTests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void Convert20ToXX()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("XX", converter.Convert(20));
        }
        [TestMethod]
        public void Convert25ToXXV()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("XXV", converter.Convert(25));
        }
        [TestMethod]
        public void Convert26ToXXVI()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("XXVI", converter.Convert(26));
        }
        [TestMethod]
        public void Convert19ToIX()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("XIX", converter.Convert(19));
        }
        [TestMethod]
        public void Convert14ToIX()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("XIV", converter.Convert(14));
        }
        [TestMethod]
        public void Convert24ToIX()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("XXIV", converter.Convert(24));
        }
        [TestMethod]
        public void Convert45ToXLV()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("XLV", converter.Convert(45));
        }
        [TestMethod]
        public void Convert81ToLXXXI()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("LXXXI", converter.Convert(81));
        }
        [TestMethod]
        public void Convert99ToXCIX()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("XCIX", converter.Convert(99));
        }
        [TestMethod]
        public void Convert399ToCCCXCIX()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("CCCXCIX", converter.Convert(399));
        }
        [TestMethod]
        public void Convert400ToCD()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("CD", converter.Convert(400));
        }
        [TestMethod]
        public void Convert451ToCDLI()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("CDLI", converter.Convert(451));
        }
        [TestMethod]
        public void Convert999ToCMXCIX()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("CMXCIX", converter.Convert(999));
        }
        [TestMethod]
        public void Convert3999ToMMMCMXCIX()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("MMMCMXCIX", converter.Convert(3999));
        }
        [TestMethod]
        public void Convert0ToNulla()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual("nulla", converter.Convert(0));
        }



        ///Number to Numeral
        [TestMethod]
        public void Convert1FromI()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual(1, converter.Convert("I"));
        }
        [TestMethod]
        public void Convert1Fromi()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual(1, converter.Convert("i"));
        }
        [TestMethod]
        public void Convert0FromNulla()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual(0, converter.Convert("nulla"));
        }
        [TestMethod]
        public void Convert4FromIV()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual(4, converter.Convert("IV"));
        }
        [TestMethod]
        public void Convert6FromVI()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual(6, converter.Convert("VI"));
        }
        [TestMethod]
        public void ConvertMMMCMXCIXTo3999()
        {
            RomanConverter converter = new RomanConverter();
            Assert.AreEqual(3999, converter.Convert("MMMCMXCIX"));
        }

        ///Number out of range
        [TestMethod]
        public void Convert4000ToFail()
        {
            RomanConverter converter = new RomanConverter();
            Assert.ThrowsException<NotImplementedException>(() => converter.Convert(4000));
        }
        [TestMethod]
        public void ConvertNeg10ToFail()
        {
            RomanConverter converter = new RomanConverter();
            Assert.ThrowsException<NotImplementedException>(() => converter.Convert(-10));
        }
        [TestMethod]
        public void ConvertMMMMCMXCIXToFail()
        {
            RomanConverter converter = new RomanConverter();
            Assert.ThrowsException<Exception>(() => converter.Convert("MMMMCMXCIX")); //This is not a valid roman numeral, techincally 4000 is IV
        }

        //Invalid string
        [TestMethod]
        public void ConvertABCToFail()
        {
            RomanConverter converter = new RomanConverter();
            Assert.ThrowsException<Exception>(() => converter.Convert("ABC"));
        }


    }
}
