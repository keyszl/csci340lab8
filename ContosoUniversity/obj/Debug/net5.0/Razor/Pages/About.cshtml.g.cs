#pragma checksum "C:\Users\User\source\repos\csci340lab8\ContosoUniversity\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "552e487b5fff0bfc14647e4691201d97a9a99832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TriadCollege.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace TriadCollege.Pages
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
#line 1 "C:\Users\User\source\repos\csci340lab8\ContosoUniversity\Pages\_ViewImports.cshtml"
using TriadCollege;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552e487b5fff0bfc14647e4691201d97a9a99832", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda63bbd3553eafacc70790a6656aeb48423942d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\source\repos\csci340lab8\ContosoUniversity\Pages\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Student Body Statistics</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\User\source\repos\csci340lab8\ContosoUniversity\Pages\About.cshtml"
     foreach (var item in Model.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\User\source\repos\csci340lab8\ContosoUniversity\Pages\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\User\source\repos\csci340lab8\ContosoUniversity\Pages\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\User\source\repos\csci340lab8\ContosoUniversity\Pages\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TriadCollege.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TriadCollege.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TriadCollege.Pages.AboutModel>)PageContext?.ViewData;
        public TriadCollege.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
