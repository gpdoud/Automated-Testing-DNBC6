using NUnit.Framework;

namespace Tests {
    public class Tests {

        AutomatedTestingLibraryProject.Functions f;

        [SetUp]
        public void Setup() {
            f = new AutomatedTestingLibraryProject.Functions();
        }

        [Test]
        public void Test1() {
            var ans = f.Add1(3);
            Assert.AreEqual(4, ans);
        }
    }
}