using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RITFacultyV1.Models;

namespace RITFacultyV1.ViewModels
{
    public class EmploymentViewModels
    {
        public List<ProfessionalEmploymentInformation> EmploymentTable { get; set; }

        public string Title { get; set; }
    }
}
