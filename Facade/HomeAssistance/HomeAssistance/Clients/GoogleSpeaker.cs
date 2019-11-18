using HomeAssistance.Services;
using System;

namespace HomeAssistance.Clients
{
    public class GoogleSpeaker
    {
        private readonly IHomeAssistance _homeAssistance;

        public GoogleSpeaker(IHomeAssistance homeAssistance)
        {
            _homeAssistance = homeAssistance;
        }


        public void WakeUp() {
            Console.WriteLine("It's time to wake up. Your setup routine it's about to start!");
            //Do some other stuffs
            _homeAssistance.WakeUp();
        }
        public void ArriveHome()
        {
            Console.WriteLine("Welcome home!");
            //Do some other stuffs
            _homeAssistance.ArriveHome();
        }
    }
}
