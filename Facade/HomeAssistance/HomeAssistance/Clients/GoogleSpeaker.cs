using HomeAssistance.Services;
using System;
using System.Collections.Generic;

namespace HomeAssistance.Clients
{
    public class GoogleSpeaker
    {
        private readonly IHomeAssistance _homeAssistance;
        //Dictionary<VoiceCommand, string> commands = new Dictionary<VoiceCommand, string>()
        //  {
        //      {VoiceCommand.WokeUp,"Good morning!. Your setup routine it's about to start!"},
        //      {VoiceCommand.ArriveHomme, "Welcome home!"}
        //  };

        public GoogleSpeaker(IHomeAssistance homeAssistance)
        {
            _homeAssistance = homeAssistance;
        }
         

        public void ActivateCommand(VoiceCommand voiceCommand)
        {
            //var message = commands[voiceCommand];
            //Console.WriteLine(message);
            if (voiceCommand == VoiceCommand.WokeUp) {
                Console.WriteLine("Good morning!. Your setup routine it's about to start!");
                _homeAssistance.WakeUp();
            }
              
            if (voiceCommand == VoiceCommand.ArriveHomme)
            {
                Console.WriteLine("Welcome home!");
                _homeAssistance.ArriveHome();
            }               
        }

        //public void WakeUp() {
        //    Console.WriteLine("It's time to wake up. Your setup routine it's about to start!");
        //    //Do some other stuffs
        //    _homeAssistance.WakeUp();
        //}

        //public void ArriveHome()
        //{
        //    Console.WriteLine("Welcome home!");
        //    //Do some other stuffs
        //    _homeAssistance.ArriveHome();
        //}
    }
}
