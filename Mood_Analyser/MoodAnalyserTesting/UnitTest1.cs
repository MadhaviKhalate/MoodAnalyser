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
                Assert.AreEqual("Mood should not be Null", ex.Message);
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
                Assert.AreEqual("Mood should not be Empty", ex.Message);
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
        [Test]
        public void GivenImproperClassName_ShouldthrowNoSuchClassException()
        {
            try
            {
                string input = null;
                object expected = new Analyser(input);
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("Mood_Analyser.Anal", "Mood_Analyser.Analyser");
                expected.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Class Not Found", ex.Message);
            }

        }
        [Test]
        public void GivenImproperConstructorName_ShouldthrowNoSuchMethodException()
        {
            try
            {
                string message = null;
                object expected = new Analyser(message);
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("Mood_Analyser.Analyser", "Mood_Analyser.Anal");
                expected.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Constructor Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassNameAsInput_ShouldReturnMoodAnalyserObject_usingParametrisedConstructor()
        {
            object expected = new Analyser("Happy");
            object actual = MoodAnalyserFactory.MoodAnalyserUsingParamaterisedConstructor("Mood_Analyser.Analyser", "Analyser", "Happy");
            expected.Equals(actual);
        }
        [Test]
        public void GivenImproperClassName_ShouldthrowNoSuchClassException_usingParameterisedConstructor()
        {
            try
            {
                object expected = new Analyser("Happy");
                object actual = MoodAnalyserFactory.MoodAnalyserUsingParamaterisedConstructor("MoodAnalyser.Anal", "Analyser", "Happy");
                expected.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Class Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenImproperConstructorName_ShouldthrowNoSuchMethodException_usingParameterisedConstructor()
        {
            try
            {
                object expected = new Analyser("Happy");
                object actual = MoodAnalyserFactory.MoodAnalyserUsingParamaterisedConstructor("Mood_Analyser.Analyser", "Anal", "Happy");
                expected.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Constructor Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenHappyAsInput_shouldReturnHappy_UsingReflection()
        {
            string expected = "Happy";
            object actual = MoodAnalyserFactory.InvokeMoodAnalyser("Happy", "Mood");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenImproperMethodName_shouldThrowNoSuchMethodException_UsingReflection()
        {
            try
            {
                string expected = "Happy";
                object actual = MoodAnalyserFactory.InvokeMoodAnalyser("Happy", "Analyser");
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Method is Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenHappyAsInput_shouldReturnHappy_UsingDynamicMethod()
        {
            string expected = "Happy";
            string actual = MoodAnalyserFactory.DynamicMood("Happy", "message");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenImproperSetField_shouldthrowNoSuchFieldException_UsingDynamicMethod()
        {
            try
            {
                string expected = "Happy";
                string actual = MoodAnalyserFactory.DynamicMood("Happy", "messa");
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Field Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenNullAsMessage_shouldthrowNoSuchFieldException_UsingDynamicMethod()
        {
            try
            {
                Console.WriteLine("checking problem");
                string expected = "Happy";
                string actual = MoodAnalyserFactory.DynamicMood(null, "message");
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }
    }
}