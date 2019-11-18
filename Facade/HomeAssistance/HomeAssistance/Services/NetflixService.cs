using System;
using System.Collections.Generic;

namespace HomeAssistance.Services
{
    public class NetflixService : INetflixService
    {     

        public List<string> GetProfiles()
        {
            return new List<string> { "User 1" , "User 2" , "User 3" };
        }

        public List<string> GetResourceByGenre(Genre genre)
        {
            return new List<string> { "Movie 1.png", "Movie 2.png", "Movie 3.png", "Serie A.png", "Serie B.png" };
        }

        public Resource GetResource(int resourceId)
        {
            return new Resource
            {
                Title = "Movie",
                Description ="Description of movie",
                Director = "Director 1",
                Sumary = "The short description of this movie"
            };
        }
        public void PlayMovie(int movieId)
        {
            var name = GetResourceName(movieId);
            Console.WriteLine($"We are now playing  {name}.");
        }


        private string GetResourceName(int id)
        {
            var resources = new List<string> { "The BlackList", "Kung Fu Panda", "The Mentalist", "Frozen" };
            return resources[id - 1];
        }


    }
}
