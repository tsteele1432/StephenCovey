#pragma checksum "C:\Users\tstee\Source\Repos\StephenCovey2\Views\Home\Quadrants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6d0b78513208bcf5e3397c1d83f9ecce9acfc69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Quadrants), @"mvc.1.0.view", @"/Views/Home/Quadrants.cshtml")]
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
#line 1 "C:\Users\tstee\Source\Repos\StephenCovey2\Views\_ViewImports.cshtml"
using Covey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tstee\Source\Repos\StephenCovey2\Views\_ViewImports.cshtml"
using Covey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d0b78513208bcf5e3397c1d83f9ecce9acfc69", @"/Views/Home/Quadrants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df601c381ce6d4b64006dd397719f2fb48db6412", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Quadrants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Covey.Models.Task>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tstee\Source\Repos\StephenCovey2\Views\Home\Quadrants.cshtml"
  
    ViewData["Title"] = "Quadrants";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row"">
    <h1>Stephen Covey's Time Managament Matrix</h1>
</div>


<table class=""table table-bordered"">
    <thead class=""font-weight-bold"">
        <tr class=""text-center"">
            <td></td>
            <td>Urgent</td>
            <td>Not Urgent</td>
        </tr>
    </thead>

    <tbody class=""text-center"">
        <tr>
            <td class=""font-weight-bold"">Important</td>
            <td class=""font-weight-bold"">
                Quadrant I
");
            WriteLiteral(@"            </td>
            <td class=""font-weight-bold"">Quadrant II</td>
        </tr>
        <tr>
            <td class=""font-weight-bold"">Not Important</td>
            <td class=""font-weight-bold"">Quadrant III</td>
            <td class=""font-weight-bold"">Quadrant IV</td>
        </tr>
    </tbody>
</table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Covey.Models.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591
