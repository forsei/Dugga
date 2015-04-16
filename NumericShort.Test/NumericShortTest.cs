using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericShortcut;

namespace NumericShort.Test
{
    [TestClass]
    public class NumericShortTest
    {

        private INumericShortcut _numericShortcut = new NumericShorts();


        [TestMethod]
        public void NumericShortcutsConvertor()
        {
            //Arrange
            string value = "1k";
            string expected = "1000";

            //Act
            string actual = _numericShortcut.ChangeNumericShortcut(value);



            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void NumericShortcutsConvertorNullInputException()
        {
            //Arrange
            string value = null;
            

            //Act
            string actual = _numericShortcut.ChangeNumericShortcut(value);

        }



        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NumericShortcutsConvertorEmptyStringArgumentException()
        {
            //Arrange
            string value = "";
           

            //Act
            string actual = _numericShortcut.ChangeNumericShortcut(value);



        }
    }
}
