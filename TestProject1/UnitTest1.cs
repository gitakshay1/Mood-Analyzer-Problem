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
            MoodAnalyzer moodAnalyzer=new MoodAnalyzer();

            //Act
            string ActualOutPut=moodAnalyzer.Analyzer("I am in sad Mood");
            string ExpectedOutPut = "SAD";

            //Assert
            Assert.AreEqual(ExpectedOutPut, ActualOutPut);
        }
        [TestMethod]
        public void CheckMoodAnalyzerRetunHappy()
        {
            //Arrange
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

            //Act
            string ActualOutPut = moodAnalyzer.Analyzer("I am in Any Mood");
            string ExpectedOutPut = "HAPPY";

            //Assert
            Assert.AreEqual(ExpectedOutPut, ActualOutPut);
        }
    }
}