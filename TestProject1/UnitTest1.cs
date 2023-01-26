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
    }
}