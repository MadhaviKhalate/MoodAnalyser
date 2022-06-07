namespace MoodAnalyserTesting
{
    public class Tests
    {
        [Test]
        public void ThrowNullException()
        {
            try
            {
                string input = null;
                Mood_Analyser.Analyser analyser = new Mood_Analyser.Analyser(input);
                string output = analyser.Mood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Null Exception", ex.Message);
            }
        }
        [Test]
        public void GivenEmptyAsInput_AnalyseMood_ThrowEmptyException()
        {
            try
            {
                string input = "";
                Mood_Analyser.Analyser analyser = new Mood_Analyser.Analyser(input);
                string output = analyser.Mood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Empty Exception", ex.Message);
            }
        }
    }
}