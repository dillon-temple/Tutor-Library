#pragma checksum "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be94a23a36441327b43f7e725bda6f6186e84c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "/Users/momo/Desktop/TutorLibrary/Views/_ViewImports.cshtml"
using LandR;

#line default
#line hidden
#line 2 "/Users/momo/Desktop/TutorLibrary/Views/_ViewImports.cshtml"
using LandR.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be94a23a36441327b43f7e725bda6f6186e84c0", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aecdc30a165aa4854e47665aa0af97b1bb45670", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(13, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(56, 178, true);
            WriteLiteral("\n<img src=\"\" class=\"profile_main_pic\"></div>\n<div class=\"meeting_spot\">Building 3 Library</div>\n<div class=\"profile_details\">\n    <div class=\"profile_details_header\">Details for ");
            EndContext();
            BeginContext(235, 15, false);
#line 11 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                               Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(250, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(252, 14, false);
#line 11 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                                                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(266, 89, true);
            WriteLiteral(" \n        \n    </div>\n    <div class=\"rates_box\">\n        <div class=\"rates_text\">Rates: ");
            EndContext();
            BeginContext(356, 10, false);
#line 15 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                  Write(Model.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(366, 49, true);
            WriteLiteral("</div>\n        <div class=\"rates_text\">Schedule: ");
            EndContext();
            BeginContext(416, 14, false);
#line 16 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                     Write(Model.Schedule);

#line default
#line hidden
            EndContext();
            BeginContext(430, 51, true);
            WriteLiteral("</div>\n        <div class=\"rates_text\">Speciality: ");
            EndContext();
            BeginContext(482, 13, false);
#line 17 "/Users/momo/Desktop/TutorLibrary/Views/Home/Profile.cshtml"
                                       Write(Model.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(495, 309, true);
            WriteLiteral(@"</div>
    </div>
    <div class=""button_box"">
        <div>        
            <a class=""button"" href="""">Post a Review!</a>
        </div>
        <div>        
            <a class=""button"" href="""">Book this Tutor</a>
        </div>
    </div>
</div>
<div class=""review_component_container""></div>
</div>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591