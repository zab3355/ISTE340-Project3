using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMultiPlatform.Models
{
    public class UnderGradMajors
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
    }
}
