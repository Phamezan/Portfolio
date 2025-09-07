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
                        Description = "Michael her {wave}. Jeg studerer datamatiker på UCL i Danmark og har en stor interesse for fullstack-udvikling og problemløsning. Jeg arbejder især med teknologier som C#, .NET, SQL og WPF på mit studie, og jeg udvider løbende mine kompetencer inden for softwarearkitektur og systemintegration. Mit mål er at udvikle effektive, pålidelige og brugervenlige løsninger, der gør en reel forskel. Jeg søger i øjeblikket muligheder, hvor jeg kan anvende min viden, udvikle mig som programmør og bidrage til spændende projekter.",
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
                },
                Projects = new List<Project> {
                    new Project {
                        Title = "Håndværkergården",
                        Description = "Til vores eksamensprojekt samarbejdede vi med håndværkerfirmaet 'Håndværkergården' for at udvikle en WPF applikation som simulerede en applikation til at håndtere deres kørende projekter og fakturaer",
                        Image = "/images/håndværkergården.png",
                        GithubUrl = "",
                        Technologies = new List<string> { "C#", "WPF", "MVVM", "SCRUM", "SSMS" }
                    },
                    new Project {
                        Title = "Fjernvarmefyn",
                        Description = "I samarbejde med fjernvarmefyn udviklede vi et spændende projekt til at løse en af deres mange problemstillinger hvor de kunne modtage feedback fra deres kollegaer",
                        Image = "/images/Fjernvarme-fyn.jpg",
                        GithubUrl = "",
                        Technologies = new List<string> { "C#", "WPF", "MVVM", "SCRUM", "SSMS" }
                    },
                    new Project {
                        Title = "Dive Deep",
                        Description = "Kørende projekt hvor vi udvikler en hjemmeside for en fiktiv virksomhed der udlejer dykkerudstyr",
                        Image = "/images/placeholder.jpeg",
                        GithubUrl = "",
                        Technologies = new List<string> { "JavaScript", "HTML", "CSS", "ENTITY FRAMEWORK", "C#", "ASP.NET MVC" }
                    },
                }
            },
              new Profile {
                        Language = "EN",
                        HeroText = "Michael Pham",
                        Description = "Michael here {wave}. I'm studying Computer Science (Datamatiker) at UCL in Denmark and have a strong interest in full-stack development and problem-solving. At my studies, I mainly work with technologies such as C#, .NET, SQL, and WPF, and I'm continuously expanding my skills within software architecture and system integration. My goal is to develop efficient, reliable, and user-friendly solutions that make a real difference. I'm currently looking for opportunities where I can apply my knowledge, grow as a developer, and contribute to exciting projects.",
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
                },
                Projects = new List<Project> {
                    new Project {
                        Title = "Håndværkergården",
                        Description = "For our exam project we collaborated with the craftsman company 'Håndværkergården' to develop a WPF application that simulated an application for handling their ongoing projects and invoices",
                        Image = "/images/håndværkergården.png",
                        GithubUrl = "",
                        Technologies = new List<string> { "C#", "WPF", "MVVM", "SCRUM" }
                    },
                    new Project {
                        Title = "Fjernvarmefyn",
                        Description = "In collaboration with Fjernvarmefyn, we developed an exciting project to solve one of their many challenges, enabling them to receive feedback from their colleagues.",
                        Image = "/images/Fjernvarme-fyn.jpg",
                        GithubUrl = "",
                        Technologies = new List<string> { "C#", "WPF", "MVVM", "SCRUM", "SSMS" }
                    },
                    new Project {
                        Title = "Dive Deep",
                        Description = "Ongoing project where we are developing a website for a fictional company that rents out diving equipment.",
                        Image = "/images/placeholder.jpeg",
                        GithubUrl = "",
                        Technologies = new List<string> { "JavaScript", "HTML", "CSS", "ENTITY FRAMEWORK", "C#", "ASP.NET MVC" }
                    },
                }
              }
        };

        public List<Profile> GetProfiles => profiles;

        public Profile GetProfileByLanguage(string language) => profiles.FirstOrDefault(p => p.Language == language);
    }
}