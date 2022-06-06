namespace MoodAnalyserTesting
{
    public class Tests
    {

        [Test]
        public void CheckSad()
        {
            string moodInput = "I am in Sad Mood";
            Mood_Analyser.Analyser analyser = new Mood_Analyser.Analyser(moodInput);
            Assert.AreEqual("Sad", analyser.Mood());
        }
    }
}