using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class CabInvoiceTest
    {
        InvoiceGenerator invoice = new InvoiceGenerator();

        [TestMethod]
        [DataRow(5,5,55,RideType.NORMAL)]
        [DataRow(5,5,85,RideType.PREMIUM)]
        public void Given_Distance_And_Time_Return_Total_Fare(double distance, int time , double expected , RideType rideType)
        {
            //Arrange
            invoice = new InvoiceGenerator();
            Ride ride= new Ride(distance, time, rideType);
            //Act
            double actual = invoice.CalculateFare(ride);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
