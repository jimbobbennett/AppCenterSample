using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AppCenterSample.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void CanIncrementCounter()
        {
            app.Screenshot("Before incrementing");
            app.Tap("ChangeNumberButton");
            app.Screenshot("After incrementing");

            var text = app.Query("NumberLabel").Single().Text;
            Assert.AreEqual("Number: 1",
                            text,
                            $"Number should be 1 but is {text}");
        }
    }
}
