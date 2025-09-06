using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolie.Models
{
    public class Job
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
    }
}