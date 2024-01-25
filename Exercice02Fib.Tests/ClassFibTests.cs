using Exercice02Fib.Core;

namespace Exercice02Fib.Tests
{
    public class ClassFibTests
    {
        [Fact]
        public void GetFibSeries_WithRangeOne_ShouldNotBeEmpty()
        {
            var fib = new ClassFib.Fib(1);
            var result = fib.GetFibSeries();
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetFibSeries_WithRangeOne_ShouldContainSingleZero()
        {
            var fib = new ClassFib.Fib(1);
            var result = fib.GetFibSeries();
            Assert.Collection(result, item => Assert.Equal(0, item));
        }

        [Fact]
        public void GetFibSeries_WithRangeSix_ShouldContainThree()
        {
            var fib = new ClassFib.Fib(6);
            var result = fib.GetFibSeries();
            Assert.Contains(3, result);
        }

        [Fact]
        public void GetFibSeries_WithRangeSix_ShouldHaveSixElements()
        {
            var fib = new ClassFib.Fib(6);
            var result = fib.GetFibSeries();
            Assert.Equal(6, result.Count);
        }

        [Fact]
        public void GetFibSeries_WithRangeSix_ShouldNotContainFour()
        {
            var fib = new ClassFib.Fib(6);
            var result = fib.GetFibSeries();
            Assert.DoesNotContain(4, result);
        }

        [Fact]
        public void GetFibSeries_WithRangeSix_ShouldMatchExpectedSequence()
        {
            var fib = new ClassFib.Fib(6);
            var expected = new List<int> { 0, 1, 1, 2, 3, 5 };
            var result = fib.GetFibSeries();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetFibSeries_WithRangeSix_ShouldBeSortedAscending()
        {
            var fib = new ClassFib.Fib(6);
            var result = fib.GetFibSeries();
            var sorted = new List<int>(result);
            sorted.Sort();
            Assert.Equal(sorted, result);
        }
    }
}
