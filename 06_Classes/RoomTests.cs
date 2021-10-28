using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Classes
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        // Functionality_Goal
        // Check constructor properly sets properties
        public void ConstructRoom_ShouldSetProperties()
        {
            Room room = new Room(8, 8, 10);

            Assert.AreEqual(8, room.Length);
            Assert.AreEqual(8, room.Width);
            Assert.AreEqual(10, room.Height);
        }

        // Check Square Footage
        [TestMethod]
        public void SquareFootage_ShouldReturnCorrectDouble()
        {
            Room room = new Room(10, 7, 10);
            // 10* 7 =70
            double expected = 70;
            double actual = room.CalculateSquareFootage();

            Assert.AreEqual(expected, actual);

            Console.WriteLine($"Expected value: {expected}");
            Console.WriteLine($"Actual value: {actual}");
        }

        // Check LSA output
        [TestMethod]
        public void CheckLateralSurfaceArea_ShouldReturnCorrectDouble()
        {
            Room room = new Room(10, 7, 10);
            // L* 2 * (H + W)
            // 10 * 2 (10 + 7) = 340
            Assert.AreEqual(340, room.CalculateLateralSurfaceArea());
        }

        // Check Invalid Length
        [DataTestMethod]
        [DataRow(31,10,10)]
        [DataRow(2,10,10)]
        public void CreateInvalidLength_ShouldThrowException(double l, double w, double h)
        {
            // Instantiating an exception so I can store one later
            Exception thrownException = null;
            try
            {
                // Code to try running
                Room room = new Room(l, w, h);
            }
            // catch the exception if thrown
            catch (Exception err)
            {
                // work with the error
                thrownException = err;
            }
            Assert.IsNotNull(thrownException);
            Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
        }

        // Check Invalid Width
        [DataTestMethod]
        [DataRow(10,25,10)]
        [DataRow(10,4,10)]
        public void CreateInvalidWidth_ShouldThrowException(double l, double w, double h)
        {
            Exception thrownException = null;

            try
            {
                Room room = new Room(l, w, h);
            }
            catch(Exception err)
            {
                thrownException = err;
            }
            finally
            {
                Assert.IsNotNull(thrownException);
                Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
            }
        } 

        // Check Invalid Height
        [DataTestMethod]
        [DataRow(10,7,17)]
        [DataRow(10,7,7)]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateInvalidHeight_ShouldThrowException(double l, double w, double h)
        {
            Room room = new Room(l, w, h);
        }
    }
}
