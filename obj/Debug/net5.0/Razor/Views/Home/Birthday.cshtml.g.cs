#pragma checksum "D:\School\Avans\Jaar2\SSWF\SSWFHuiswerk\BirthdayCalculator\BirthdayCalculator\Views\Home\Birthday.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18e7bd10da33025696113ca95f1534751a70d325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Birthday), @"mvc.1.0.view", @"/Views/Home/Birthday.cshtml")]
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
#line 1 "D:\School\Avans\Jaar2\SSWF\SSWFHuiswerk\BirthdayCalculator\BirthdayCalculator\Views\_ViewImports.cshtml"
using BirthdayCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\School\Avans\Jaar2\SSWF\SSWFHuiswerk\BirthdayCalculator\BirthdayCalculator\Views\_ViewImports.cshtml"
using BirthdayCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e7bd10da33025696113ca95f1534751a70d325", @"/Views/Home/Birthday.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"278963edab66d39f208f81ca3259c126726313d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Birthday : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BirthdayCalculator.Models.BirthDateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\School\Avans\Jaar2\SSWF\SSWFHuiswerk\BirthdayCalculator\BirthdayCalculator\Views\Home\Birthday.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1>Je bent jarig! ");
#nullable restore
#line 6 "D:\School\Avans\Jaar2\SSWF\SSWFHuiswerk\BirthdayCalculator\BirthdayCalculator\Views\Home\Birthday.cshtml"
                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BirthdayCalculator.Models.BirthDateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
