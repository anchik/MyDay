using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDay;

namespace Tests
{
    [TestClass]
    public class DayTest
    {
        [TestMethod]
        public void WakeUp_WhenActualTimeIsLaterThanRequired_ShouldReturnLateWakeUpTimeMessage()
        {
            // arrange
            Day day = new Day();
            day.SetRequiredWakeUpTime(7, 0);


            // act
            string result = day.WakeUp(8, 0);
            
            // assert
            StringAssert.Contains(result, Day.LateWakeUpTimeMessage);
                
        }

        [TestMethod]
        public void WakeUp_WhenActualTimeIsearlierThanRequired_ShouldReturnCorrectWakeUpTimeMessage()
        {
            // arrange
            Day day = new Day();
            day.SetRequiredWakeUpTime(7, 0);


            // act
            string result = day.WakeUp(6, 0);

            // assert
            StringAssert.Contains(result, Day.CorrectWakeUpTimeMessage);

        }

        
    }
}
