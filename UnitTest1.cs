using ExceptionsAndExceptionHandeling;

namespace ExceptionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodReturnSAD()
        {
            string expected = "SAD";

            string message = "I am in Sad Mood";

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string actual = moodAnalyser.analyseMood();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NullMoodReturnsHappy()
        {
            string expected = "HAPPY";

            string message = null;

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string actual = moodAnalyser.analyseMood();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GivenEmptyMoodThrowsEmptyMoodException()
        {
            try
            {
                string message = " ";

                MoodAnalyser moodAnalyser = new MoodAnalyser(message);

                string actual = moodAnalyser.analyseMood();
            }
            catch (MoodAnalyserExceptions e)
            {
                Assert.AreEqual("Message cannot be Empty", e.Message);
            }


        }

        [TestMethod]
        public void GivenNullMoodThrowsNullMoodException()
        {
            try
            {
                //string message = null;

                MoodAnalyser moodAnalyser = new MoodAnalyser(null);

                string actual = moodAnalyser.analyseMood();
            }
            catch (MoodAnalyserExceptions e)
            {
                Assert.AreEqual("Invalid Mood", e.Message);
            }
        }
    }
}