using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolie.Models
{
    public class Profile
    {
        public string Name { get; set; } = string.Empty;
        public string HeroText { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}