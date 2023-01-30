using Mood_Analyzer_Problem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckMoodAnalyzerretunSad()
        {
            //Arrange
            MoodAnalyzer moodAnalyzer=new MoodAnalyzer("I am in sad Mood");

            //Act
            string ActualOutPut=moodAnalyzer.Analyzer();
            string ExpectedOutPut = "SAD";

            //Assert
            Assert.AreEqual(ExpectedOutPut, ActualOutPut);
        }
        [TestMethod]
        public void CheckMoodAnalyzerRetunHappy()
        {
            //Arrange
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Any Mood");

            //Act
            string ActualOutPut = moodAnalyzer.Analyzer();
            string ExpectedOutPut = "HAPPY";

            //Assert
            Assert.AreEqual(ExpectedOutPut, ActualOutPut);
        }
        [TestMethod]
        public void ExceptionHandle()
        {
            //Arrange
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("a");

            //Act
            string ActualOutPut = moodAnalyzer.Analyzer();
            string ExpectedOutPut = "HAPPY";

            //Assert
            Assert.AreEqual(ExpectedOutPut, ActualOutPut);
        }
        
        [TestMethod]
        public void GivenMoodAnalyzerClassName_WhenImproper_ShouldThrowMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyzerReflector.CreateMoodAnalyse("MoodAnalyzerProblem.Mood", "Mood","Parmerties Constructor");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        
        [TestMethod]
        public void GivenMoodAnalyzerConstructorName_WhenImproper_ShouldThrowMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyzerReflector.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "Mood", "Parmerties Constructor");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// <summary>
        /// TestCase 6.1
        /// </summary>
        [TestMethod]
        public void GivenHappyMessageUsingReflection_WhenProper_ShouldReturnHappy()
        {
            string expected = "happy";
            string actual = MoodAnalyzerReflector.InvokeAnalyseMood("I am happy", "MoodAnalyzer");
            expected.Equals(actual);
        }

        /// <summary>
        /// TestCase 6.2
        /// </summary>
        [TestMethod]
        public void GivenMethodname_WhenImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Method not found";
            string actual = MoodAnalyzerReflector.InvokeAnalyseMood("I am happy", "Mood");
            Assert.AreEqual(expected, actual);
        }
    }
}