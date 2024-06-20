using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace FindDuplicateWords.TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFindDuplicateWords_NoDuplicates()
        {
            string input = "this test will work fine";
            var result = DuplicateWords.FindDuplicateWords(input);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TestFindDuplicateWords_WithDuplicates()
        {
            string input = "this test is good this test will work fine";
            var expected = new Dictionary<string, int>
            {
                { "this", 2 },
                { "test", 2 }
            };
            var result = DuplicateWords.FindDuplicateWords(input);
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}