using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolie.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Image { get; set; }
        public string? GithubUrl { get; set; }
        public List<string> Technologies { get; set; } = new List<string>();
    }
}
