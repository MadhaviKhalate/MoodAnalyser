namespace MoodAnalyserTesting
{
    public class Tests
    { 

        [Test]
        public void TestMethod()
        {
            Mood_Analyser.Analyser analyser = new Mood_Analyser.Analyser();
            string moodInput = "I am in Sad Mood";
            Assert.AreEqual("Sad", analyser.Mood(moodInput));
        }

        [Test]
        public void TestMethod2()
        {
            Mood_Analyser.Analyser analyser = new Mood_Analyser.Analyser();
            string moodInput = "I am in Any Mood";
            Assert.AreEqual("Happy", analyser.Mood(moodInput));
        }
    }
}