using HomeAssistance.Services;

namespace HomeAssistance.Clients
{
    public class MobilePhone
    {
        private readonly INetflixService _netflixService;
        private readonly ICalendarService _calendarService;
        private readonly ISpotifyService _spotifyService;

        public MobilePhone(INetflixService netflixService, ICalendarService calendarService,  ISpotifyService spotifyService)
        {
            _netflixService = netflixService;
            _calendarService = calendarService;
            _spotifyService = spotifyService;
        }

        

    }
}
