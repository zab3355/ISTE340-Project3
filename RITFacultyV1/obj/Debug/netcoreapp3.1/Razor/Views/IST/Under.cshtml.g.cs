#pragma checksum "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "877af8bcd92eacbd36c2e47a1df34ef8ad7f5cf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IST_Under), @"mvc.1.0.view", @"/Views/IST/Under.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877af8bcd92eacbd36c2e47a1df34ef8ad7f5cf2", @"/Views/IST/Under.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30ba83fcc7a6590bc6959c8a5b1927d6a433aa54", @"/Views/_ViewImports.cshtml")]
    public class Views_IST_Under : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RITFacultyV1.ViewModels.UndergradViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery-3.4.1.min.js"" integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="" crossorigin=""anonymous""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
<link");
            BeginWriteAttribute("href", " href=\"", 627, "\"", 664, 1);
#nullable restore
#line 6 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
WriteAttributeValue("", 634, Url.Content("~/css/site.css"), 634, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n<h2 class=\"pageHeading\">");
#nullable restore
#line 8 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"col-sm-12 col-lg-12 col-md-12\">\r\n");
#nullable restore
#line 11 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
     foreach (var under in Model.UnderGrads)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"topicGrads\">\r\n            ");
#nullable restore
#line 14 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
       Write(under.degreeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n        <h3 class=\"captionDegree\">\r\n            ");
#nullable restore
#line 17 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
       Write(under.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
       Write(under.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n");
#nullable restore
#line 20 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
        foreach (var conc in under.concentrations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul>\r\n                <li>");
#nullable restore
#line 23 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
               Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n");
#nullable restore
#line 25 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 27 "C:\Users\zab33\Google Drive\4 Fourth Year\ISTE-340\Projects\Project3-ZachBrown\P3 Start Files\RITFacultyV1\Views\IST\Under.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RITFacultyV1.ViewModels.UndergradViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
