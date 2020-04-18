using System;
using Xunit;

namespace JosephusProblem.Tests
{
    public class josephus
    {
        [Fact]
        public void last_person()
        {
            var numOfPeople = 10;
            var killingInterval = 3;
            int[] expectedResult = new int[] { 4 };
            var lastPersonStanding = new LastPersonStanding();

            var actualResult = lastPersonStanding.Kill(numOfPeople, killingInterval);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
