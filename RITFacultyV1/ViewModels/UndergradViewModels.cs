using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RITFacultyV1.Models;

namespace RITFacultyV1.ViewModels
{
    public class UndergradViewModels
    {
        public List<UnderGradMajors> UnderGrads { get; set; }

        public List<GradMajors> Grads { get; set; }

        public string Title { get; set; }
    }
}
