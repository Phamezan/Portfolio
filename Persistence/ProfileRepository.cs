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
                Language = "DK",
                HeroText = "Michael Pham",
                Description = "Hej mit navn er Michael og jeg studere på datamatiker uddannelse på UCL i Odense, Danmark",
                JobExperiences = new List<Job> {
                    new Job {
                        Title = "April 2024 - Juli 2024",
                        Company = "TelefonInterviewer hos Norstat | Odense",
                        Description = "B2B og B2C opgaver som gik ud på at foretage undersøgelser med kunderne.",
                        Image = "/images/norstat.jpg"
                    },
                    new Job {
                        Title = "August 2024 - Februar 2025",
                        Company = "TelefonInterviewer hos Wilke | Odense",
                        Description = "B2B og B2C opgaver der både foregik telefonisk med kunderne, men der var også 'in-person' opgaver med f.eks. smagsprøver",
                        Image = "/images/wilke.jpg"
                    },
                    new Job {
                        Title = "2025 Februar - Nu",
                        Company = "",
                        Description = "Fuldtidsstuderende, men på udkig efter et studierelevant deltidsjob"
                    }
                }
            },
              new Profile {
                Language = "EN",
                HeroText = "Michael Pham",
                Description = "Hello my name is Michael Pham and i currently study computerscience at UCL in Odense, Denmark ",
                JobExperiences = new List<Job> {
                    new Job {
                        Title = "April 2024 - July 2024",
                        Company = "Telephone Interviewer at Norstat | Odense",
                        Description = "B2B and B2C tasks that involved conducting surveys with customers."
                    },
                    new Job {
                        Title = "August 2024 - February 2025",
                        Company = "Telephone Interviewer at Wilke | Odense",
                        Description = "B2B and B2C tasks that were both conducted by phone with customers, but there were also 'in-person' tasks such as taste tests."
                    },
                    new Job {
                        Title = "February 2025 - Present",
                        Company = "",
                        Description = "Full-time student, but looking for a part-time job relevant to my studies"
                    }
                }
              }
        };

        public List<Profile> GetProfiles => profiles;

        public Profile GetProfileByLanguage(string language) => profiles.FirstOrDefault(p => p.Language == language);
    }
}