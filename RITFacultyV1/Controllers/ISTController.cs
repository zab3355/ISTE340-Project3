using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RITFacultyV1.Models;
using RITFacultyV1.ViewModels;
using RITFacultyV1.Services;

namespace RITFacultyV1.Controllers
{
    public class ISTController : Controller
    {
        //Faculty Controller 
        public async Task<IActionResult> Faculty()
        {
            var getallFaculty = new GetFaculty();
            var allFaculty = await getallFaculty.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var facultyViewModel = new FacultyViewModels()
            {
                Faculty = allFaculty.ToList(),
                Title = "This is your Faculty"
            };
            return View(facultyViewModel);
        }

        //About Controller
         public async Task<IActionResult> About()
         {
            var getAbout = new GetAbout();
            var about = await getAbout.GetAboutData();
            var aboutViewModel = new AboutViewModels()
            {
                About = about,
                Title = "About RIT Information Technologies",
                aboutTitle = about.title,
                aboutDescription = about.description,
                aboutQuote = about.quote,
                aboutQuoteAuthor = about.quoteAuthor
            };

            return View(aboutViewModel);
         }
          
          //Employment Table Controller
          public async Task<IActionResult> EmploymentTable()
          {
            var getEmployment = new GetEmploy();
            var employment = await getEmployment.GetEmployment();
            var employmentViewModel = new EmploymentViewModels()
            {
                 EmploymentTable = employment.ToList(),
                 Title = "Employment Table"
            };

                  return View(employmentViewModel);
              }

        //Co-Op Table Controller
          public async Task<IActionResult> CoOpTable()
              {
                  var getCoOp = new GetCoOp();
                  var coop = await getCoOp.GetCoOpEmployment();

                  var coOpViewModel = new CoOpViewModels()
                  {
                      CoOpTable = coop.ToList(),
                      Title = "Co-Op Table"
                  };

                  return View(coOpViewModel);
              }
              

        //used for both undergrad and grad (to combine pages)
        public async Task<IActionResult> Grad()
        {
            //GetGraduate() is in the Services folder
            var getGrad = new GetGraduate();
            var grad = await getGrad.GetGradDegrees();
            //calls to the ViewModels GradViewModel()
            var gradViewModel = new GradViewModels()
            {
                Grads = grad,
                Title = "Graduate Programs"
            };
            //Nothing here yet - Want YOU to populate it with the api call to undergrad (and need to build the view and model!)
            return View(gradViewModel);
        }
        //Old Undergrad view
        /*
public async Task<IActionResult> Under()
{
    //GetUndergraduate() is in the Services folder
    var getUnder = new GetUndergraduate();
    var under = await getUnder.GetUnderGradDegrees();
    //calls to the ViewModels UndergradViewModel()
    var underViewModel = new UndergradViewModels()
    {
        UnderGrads = under,
        Title = "Undergraduate Programs"
    };
   //Nothing here yet - Want YOU to populate it with the api call to undergrad (and need to build the view and model!)
    return View(underViewModel);
}
*/

    }
}
