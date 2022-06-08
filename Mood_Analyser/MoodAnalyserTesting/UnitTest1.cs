namespace Mood_Analyser
{
    public class Tests
    {
        [Test]
        public void ThrowNullException()
        {
            try
            {
                string input = null;
                Analyser analyser = new Analyser(input);
                string output = analyser.Mood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Null Exception", ex.Message);
            }
        }
        [Test]
        public void ThrowEmptyException()
        {
            try
            {
                string input = "";
                Analyser analyser = new Analyser(input);
                string output = analyser.Mood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Empty Exception", ex.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string input = null;
            object expected = new Analyser(input);
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("Mood_Analyser.Analyser", "Mood_Analyser.Analyser");
            expected.Equals(actual);
        }
    }
}