#pragma checksum "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aca0e3a60965f6de59486f98315bd5c970b5d829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IST_Faculty), @"mvc.1.0.view", @"/Views/IST/Faculty.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\_ViewImports.cshtml"
using RITFacultyV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\_ViewImports.cshtml"
using RITFacultyV1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca0e3a60965f6de59486f98315bd5c970b5d829", @"/Views/IST/Faculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ba83fcc7a6590bc6959c8a5b1927d6a433aa54", @"/Views/_ViewImports.cshtml")]
    public class Views_IST_Faculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RITFacultyV1.ViewModels.FacultyViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery-3.4.1.min.js"" integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="" crossorigin=""anonymous""></script>
<link href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">

<link");
            BeginWriteAttribute("href", " href=\"", 726, "\"", 763, 1);
#nullable restore
#line 8 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
WriteAttributeValue("", 733, Url.Content("~/css/site.css"), 733, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n<h2 class=\"pageHeading\">");
#nullable restore
#line 10 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
 foreach (var faculty in Model.Faculty)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-3 col-lg-3 col-md-3\">\r\n        <div class=\"thumbnail\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 988, "\"", 1012, 1);
#nullable restore
#line 16 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
WriteAttributeValue("", 994, faculty.imagePath, 994, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1013, "\"", 1019, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"caption\">\r\n                <h3 class=\"topicGrads\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
               Write(faculty.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <h3 class=\"captionDegree\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
               Write(faculty.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <h3 style=\"font-size:small\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
               Write(faculty.office);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <h3 style=\"font-size:small\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
               Write(faculty.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <h3 style=\"font-size:small\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
               Write(faculty.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Faculty.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RITFacultyV1.ViewModels.FacultyViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
