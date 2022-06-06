namespace MoodAnalyserTesting
{
    public class Tests
    {

        [Test]
        public void GetInputAsSad_AnalyseMood_ReturnSad()
        {
            string moodInput = "I am in Sad Mood";
            Mood_Analyser.Analyser analyser = new Mood_Analyser.Analyser(moodInput);
            Assert.AreEqual("Sad", analyser.Mood());
        }
        [Test]
        public void GetInputAsHappy_AnalyseMood_ReturnHappy()
        {
            string moodInput = "I am in Any Mood";
            Mood_Analyser.Analyser analyser = new Mood_Analyser.Analyser(moodInput);
            Assert.AreEqual("Happy", analyser.Mood());
        }
    }
}