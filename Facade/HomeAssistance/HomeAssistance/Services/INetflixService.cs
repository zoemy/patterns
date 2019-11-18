using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAssistance.Services
{
    public interface INetflixService
    {
        List<string> GetProfiles();
        List<string> GetResourceByGenre(Genre genre);
        Resource GetResource(int resourceId);
        void PlayMovie(int movieId);
    }
}
