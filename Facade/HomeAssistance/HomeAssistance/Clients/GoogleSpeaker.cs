using HomeAssistance.Services;
using System;

namespace HomeAssistance.Clients
{
    public class GoogleSpeaker
    {
        private readonly INetflixService _netflixService;
        private readonly ICalendarService _calendarService;
        private readonly ISpotifyService _spotifyService;

        public GoogleSpeaker(INetflixService netflixService, ICalendarService calendarService, ISpotifyService spotifyService)
        {
            _netflixService = netflixService;
            _calendarService = calendarService;
            _spotifyService = spotifyService;
        }


        public void GoodMorningCommand() {
            _calendarService.GetEvents(DateTime.Today);
            _calendarService.GetReminders(DateTime.Today);
            int morningPlaylist = 1;
            _spotifyService.Play(morningPlaylist);
        }

    }
}
