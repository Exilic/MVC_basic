#pragma checksum "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec22eae5069c297738d8f7567139ccabe016976"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/_ViewImports.cshtml"
using MVCBasicsAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec22eae5069c297738d8f7567139ccabe016976", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98d061a4b0e042fdcaaf3144d8b4b6a51747824a", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LifeEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>About</h1>\n\n<h3>Work Experience</h3>\n<table id=\"AboutList\">\n");
#nullable restore
#line 10 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
     foreach (LifeEvent item in Model)
    {
        if (@item.Kind == "Work")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>");
#nullable restore
#line 14 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
               Write(item.Period);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 14 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n");
#nullable restore
#line 15 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
}
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<h3>Educational Degrees</h3>\n<table id=\"AboutList\">\n");
#nullable restore
#line 20 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
     foreach (LifeEvent item in Model)
    {
        if (@item.Kind == "Education")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>");
#nullable restore
#line 24 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
               Write(item.Period);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 24 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n");
#nullable restore
#line 25 "/Users/tobiasengberg/Projects/MVCBasicsAssignment/Views/About/Index.cshtml"
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LifeEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591