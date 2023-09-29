using MoodAnalyserDemo;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadMessageShouldReturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in a Sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            // Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HappyMessageShouldReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in a Happy mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            // Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NullMessageReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            // Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyMessagethrowsCustomException()
        {
            try
            {
                string message = "";
                MoodAnalyser mood = new MoodAnalyser(message);
                string actual = mood.AnalyseMood();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("mood should not be empty", e.Message);
            }
        }
    }
}