#pragma checksum "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d4dbaa8e49551aaa54a262ec14d5b4017d216a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IST_Grad), @"mvc.1.0.view", @"/Views/IST/Grad.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d4dbaa8e49551aaa54a262ec14d5b4017d216a2", @"/Views/IST/Grad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ba83fcc7a6590bc6959c8a5b1927d6a433aa54", @"/Views/_ViewImports.cshtml")]
    public class Views_IST_Grad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RITFacultyV1.ViewModels.GradViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery-3.4.1.min.js"" integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="" crossorigin=""anonymous""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
<link");
            BeginWriteAttribute("href", " href=\"", 622, "\"", 659, 1);
#nullable restore
#line 6 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
WriteAttributeValue("", 629, Url.Content("~/css/site.css"), 629, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n<h2 class=\"pageHeading\">Undergraduate and Graduate Programs</h2>\r\n\r\n<div class=\"col-sm-12 col-lg-12 col-md-12\">\r\n");
#nullable restore
#line 11 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
     foreach (var grad in Model.Grads)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"topicGrads\">\r\n            ");
#nullable restore
#line 14 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
       Write(grad.degreeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n        <h3 class=\"captionDegree\">\r\n            ");
#nullable restore
#line 17 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
       Write(grad.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
       Write(grad.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n");
#nullable restore
#line 20 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
        if (grad.concentrations != null)
        {
            foreach (var conc in grad.concentrations)
            {
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul>\r\n                        <li>");
#nullable restore
#line 26 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
                       Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n");
#nullable restore
#line 28 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
                }
            }
        }
        else
        {

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 36 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Grad.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RITFacultyV1.ViewModels.GradViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
