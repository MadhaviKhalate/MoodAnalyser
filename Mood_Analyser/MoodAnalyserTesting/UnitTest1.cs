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
    }
}