namespace Mood_Analyser
{ 
    public class Test1
    {
        [Test]
        public void TestMethod1()
        {
            Mood_Analyser.Analyser analyser = new Mood_Analyser.Analyser();
            string moodInput = "I am in Sad Mood";
            Assert.AreEqual("Sad", analyser.Mood(moodInput));
        }
    }
}