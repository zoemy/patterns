using HomeAssistance.Clients;
using HomeAssistance.Services;
using Moq;
using NUnit.Framework;

namespace HomeAssistance.Tests
{
    [TestFixture]
    public class GoogleSpekerTests
    {
        private GoogleSpeaker _googleSpeaker; 
        private Mock<IHomeAssistance> _homeAssistance; 
        
        [SetUp]
        public void Init()
        {
            _homeAssistance = GetHomeAssistance();
            _googleSpeaker = new GoogleSpeaker(_homeAssistance.Object);
        }

        [Test]
        public void ArriveHome() {          
            _googleSpeaker.ArriveHome();
            _homeAssistance.Verify(assistance => assistance.ArriveHome(), Times.Once);
        }

        [Test]
        public void WakeUpHome()
        {
            _googleSpeaker.WakeUp();
            _homeAssistance.Verify(assistance => assistance.WakeUp(), Times.Once);
        }

        private Mock<IHomeAssistance> GetHomeAssistance()
        {
            var homeAssistance = new Mock<IHomeAssistance>();
            homeAssistance.Setup(assistance => assistance.ArriveHome())
                          .Verifiable();
            homeAssistance.Setup(assistance => assistance.WakeUp())
                          .Verifiable();
            return homeAssistance;
        }

    }
}
