using Xunit;

namespace CSharpPerformancePlaybook.Code.Tests
{
    public class StringTests
    {
        [Fact]
        public void BuildStringBadly()
        {
            var s = new StringWorker().BuildStringBadly("test");

            Assert.Equal("test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test", s);
        }

        [Fact]
        public void BuildStringBetter()
        {
            var s = new StringWorker().BuildStringBetter("test");

            Assert.Equal("test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test", s);
        }

        [Fact]
        public void FunctionsAreEquivalent()
        {
            var stringWorker = new StringWorker();

            var stringBad = stringWorker.BuildStringBadly("test");
            var stringBetter = stringWorker.BuildStringBetter("test");

            Assert.Equal(stringBad, stringBetter);
        }

        [Fact]
        public void NaiveSplitName()
        {
            var name = "Mujkic, Nisvet";
            var worker = new StringWorker();

            var lastName = worker.NaiveSplitName(name).lastName;
            var firstName = worker.NaiveSplitName(name).firstName;

            Assert.Equal("Mujkic", lastName);
            Assert.Equal("Nisvet", firstName);
        }

        [Fact]
        public void SplitSplitName()
        {
            var name = "Mujkic, Nisvet";
            var worker = new StringWorker();

            var lastName = worker.SplitSplitName(name).lastName;
            var firstName = worker.SplitSplitName(name).firstName;

            Assert.Equal("Mujkic", lastName);
            Assert.Equal("Nisvet", firstName);
        }

        [Fact]
        public void SpanSplitName()
        {
            var name = "Mujkic, Nisvet";
            var worker = new StringWorker();

            var lastName = worker.SpanSplitName(name).lastName;
            var firstName = worker.SpanSplitName(name).firstName;

            Assert.Equal("Mujkic", lastName);
            Assert.Equal("Nisvet", firstName);
        }
    }
}