#pragma checksum "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d10d948072d375a7fe6b2b69f37536562f39828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trail_ShowTrail), @"mvc.1.0.view", @"/Views/Trail/ShowTrail.cshtml")]
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
#line 1 "/Users/Jama/Desktop/To-Do-List/src/Views/_ViewImports.cshtml"
using todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Jama/Desktop/To-Do-List/src/Views/_ViewImports.cshtml"
using todo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
using Hike.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d10d948072d375a7fe6b2b69f37536562f39828", @"/Views/Trail/ShowTrail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba3874256156cd1ae0c440ea12051fa4e40a5fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Trail_ShowTrail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Trail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \n<h2>");
#nullable restore
#line 4 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<p>");
#nullable restore
#line 5 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 6 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
Write(Model.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Length: ");
#nullable restore
#line 7 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
      Write(Model.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Starting Elevation: ");
#nullable restore
#line 8 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
                  Write(Model.Low);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Elevation Gain: ");
#nullable restore
#line 9 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
              Write(Model.Ascent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Condition: ");
#nullable restore
#line 10 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
         Write(Model.ConditionDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<img");
            BeginWriteAttribute("src", " src=\"", 256, "\"", 279, 1);
#nullable restore
#line 12 "/Users/Jama/Desktop/To-Do-List/src/Views/Trail/ShowTrail.cshtml"
WriteAttributeValue("", 262, Model.ImgSqSmall, 262, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n\n\n<button>Add</button>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Trail> Html { get; private set; }
    }
}
#pragma warning restore 1591
