using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolie.Models;

namespace Portfolie.Persistence
{
    public class ProfileRepository
    {
        private static List<Profile> profiles = new List<Profile> {
            new Profile {
                Name = "DK",
                HeroText = "Hej, Jeg er Michael Pham",
                Description = "Hej mit navn er Michael og jeg studere på datamatiker uddannelse på UCL i Odense, Danmark"
            },
              new Profile {
                Name = "EN",
                HeroText = "Hello I'm Michael Pham",
                Description = "Hello my name is Michael Pham and i currently study computerscience at UCL in Odense, Denmark "
              }
        };

        public List<Profile> GetProfiles => profiles;

        public Profile GetProfileByLanguage(string language) => profiles.FirstOrDefault(p => p.Name == language);
    }
}