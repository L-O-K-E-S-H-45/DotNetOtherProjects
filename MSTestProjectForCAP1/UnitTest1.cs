using ConsoleAppProject1ForTest;
using System.Diagnostics.Tracing;

namespace MSTestProjectForCAP1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void FindMax_ValidArray_ReturnsMax()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            MSTestProblems problems = new MSTestProblems();
            int maxValue = problems.FindMaxValue(arr);

            // Assert
            Assert.AreEqual(9, maxValue);
        }

        //[TestMethod]
        public void FindMax_EmptyArray_ReturnNegative()
        {
            // Arrange
            int[] arr = { };

            // Act
            //MSTestProblems problems = new MSTestProblems();
            //int maxValue = problems.FindMaxValue(arr);

            //Assert
            //Assert.AreEqual(-1, maxValue);

            // -- OR --
            // Act & assert
            Assert.ThrowsException<ArgumentException>(() => new MSTestProblems().FindMaxValue(arr));


        }

        //[TestMethod]
        public void FindMax_NullArray_ReturnNegative()
        {
            // Arrange
            int[] arr = null;

            // Act
            //MSTestProblems problems = new MSTestProblems();
            //int maxValue = problems.FindMaxValue(arr);

            //Assert
            //Assert.AreEqual(-1, maxValue);

            // ---- OR 
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new MSTestProblems().FindMaxValue(arr));

        }

        //----------------

        //[TestMethod]
        public void TestStartsWithUpper()
        {
            string[] words = { "Abdf", "ABV", "Dcchbh", "G123", "A@43", "G " };

            foreach (var word in words)
            {
                bool result = new MSTestProblems().StartsWithUpper(word);
                //Assert.IsTrue(result);
                Assert.IsTrue(result, string.Format("Expected for '{0}': true, Actual: '{1}'", word, result));
            }
        }

        [DataRow("A")]  // for 1 input
        [DataRow("Bhf")]  // for 1 input
        [DataRow("A213")]  // for 1 input
        [DataRow("J$2")]  // for 1 input
        //[DataRow("ABC","Fg","Hgdh")]  // for 3 inputs
        //[TestMethod]
        public void TestStartsWithUpper2(string word)
        {
            //bool result = new MSTestProblems().StartsWithUpper(word);
            ////Assert.IsTrue(result);
            //Assert.IsTrue(result, string.Format("Expected for '{0}': true, Actual: '{1}'", word, result));

        }


        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            string[] words = { "sad", "a", "aVs", "123", "@f", ".", ";", " ", "", "h12", "h^%#" };
            foreach (var word in words)
            {
                bool result = new MSTestProblems().StartsWithUpper(word);
                Assert.IsFalse(result, string.Format("Expected for {0}: false, Actual: {1}", word, result));
            }
        }

        [TestMethod]
        public void DirectCalWitllNullOrEmpty()
        {
            string?[] words = { string.Empty, null };
            foreach (string word in words)
            {
                bool result = new MSTestProblems().StartsWithUpper(word);
                Assert.IsFalse(result, string.Format("Expected for {0}: false, Actual: {1}", word == null ? "<null>" : word, result));
            }
        }



    }
}