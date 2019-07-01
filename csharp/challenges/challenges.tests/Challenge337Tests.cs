using Xunit;

namespace challenges.tests
{
    public class Challenge337Tests
    {
        [Fact]
        public void TestFit()
        {
            Assert.True(challenge_337.Fit.FitBoxes(25, 18, 6, 5) == 12);
            Assert.True(challenge_337.Fit.FitBoxes(10, 10, 1, 1) == 100);
            Assert.True(challenge_337.Fit.FitBoxes(12, 34, 5, 6) == 10);
            Assert.True(challenge_337.Fit.FitBoxes(12345, 678910, 1112, 1314) == 5676);
            Assert.True(challenge_337.Fit.FitBoxes(5, 100, 6, 1) == 0);
        }

        [Fact]
        public void FitWithRotation()
        {
            Assert.True(challenge_337.Fit.RotatedFit(25, 18, 6, 5) == 15);
            Assert.True(challenge_337.Fit.RotatedFit(12, 34, 5, 6) == 12);
            Assert.True(challenge_337.Fit.RotatedFit(12345, 678910, 1112, 1314) == 5676);
            Assert.True(challenge_337.Fit.RotatedFit(5, 5, 3, 2) == 2);
            Assert.True(challenge_337.Fit.RotatedFit(5, 100, 6, 1) == 80);
            Assert.True(challenge_337.Fit.RotatedFit(5, 5, 6, 1) == 0);
        }

        [Fact]
        public void FitVolume1()
        {
            Assert.True(challenge_337.Fit.RotatedFit(10, 10, 10, 1, 1, 1) == 1000);
            Assert.True(challenge_337.Fit.RotatedFit(12, 34, 56, 7, 8, 9) == 32);
            Assert.True(challenge_337.Fit.RotatedFit(123, 456, 789, 10, 11, 12) == 32604);
            Assert.True(challenge_337.Fit.RotatedFit(1234567, 89101112, 13141516, 171819, 202122, 232425) == 174648);
        }

        [Fact]
        public void Shift()
        {
            Assert.Equal(new int[] { 2, 1 }, challenge_337.Fit.Shift(new int[] { 1, 2 }, 1));
            Assert.Equal(new int[] { 2, 1 }, challenge_337.Fit.Shift(new int[] { 1, 2 }, -1));
        }

        [Fact]
        public void FitBoxesArray()
        {
            Assert.True(challenge_337.Fit.FitBoxes(new int[] { 25, 18 }, new int[] { 6, 5 }) == 12);
            Assert.True(challenge_337.Fit.FitBoxes(new int[] { 10, 10 }, new int[] { 1, 1 }) == 100);
            Assert.True(challenge_337.Fit.FitBoxes(new int[] { 12, 34 }, new int[] { 5, 6 }) == 10);
            Assert.True(challenge_337.Fit.FitBoxes(new int[] { 12345, 678910 }, new int[] { 1112, 1314 }) == 5676);
            Assert.True(challenge_337.Fit.FitBoxes(new int[] { 5, 100 }, new int[] { 6, 1 }) == 0);
        }

        [Fact]
        public void RotatedFixBoxesArray()
        {
            Assert.True(challenge_337.Fit.RotatedFit(new int[] { 3, 4 }, new int[] { 1, 2 }) == 6);
            Assert.True(challenge_337.Fit.RotatedFit(new int[] { 123, 456, 789 }, new int[] { 10, 11, 12 }) == 32604);
            Assert.True(challenge_337.Fit.RotatedFit(new int[] { 123, 456, 789, 1011, 1213, 1415 }, new int[] { 16, 17, 18, 19, 20, 21 }) == 1883443968);
            /*fitn([3, 4], [1, 2]) => 6
            fitn([123, 456, 789], [10, 11, 12]) => 32604
            fitn([123, 456, 789, 1011, 1213, 1415], [16, 17, 18, 19, 20, 21]) => 1883443968*/
        }
    }
}
