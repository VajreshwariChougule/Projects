#pragma checksum "C:\Projects\CodeBase_5\CodeBase_5\CodeBase_5\Views\Home\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "915310080662e7034f96435cae11ede22f809137"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactUs), @"mvc.1.0.view", @"/Views/Home/ContactUs.cshtml")]
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
#line 1 "C:\Projects\CodeBase_5\CodeBase_5\CodeBase_5\Views\_ViewImports.cshtml"
using CodeBase_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\CodeBase_5\CodeBase_5\CodeBase_5\Views\_ViewImports.cshtml"
using CodeBase_5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915310080662e7034f96435cae11ede22f809137", @"/Views/Home/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"106732aaeebf171d87f2b2dbc092edf9fcf814ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 1 "C:\Projects\CodeBase_5\CodeBase_5\CodeBase_5\Views\Home\ContactUs.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<table>
    <tr>
        <td>Name</td>
        <td><input type=""text"" name=""Name"" /></td>
    </tr>
    <tr>
        <td>Subject:</td>
        <td><input type=""text"" name=""Subject"" /></td>
    </tr>
    <tr>
        <td>Email:</td>
        <td><input type=""text"" name=""Email"" /></td>
    </tr>
    <tr>
        <td valign=""top"">Body:</td>
        <td><textarea cols=""20"" rows=""5"" name=""Body""></textarea></td>
    </tr>
    <tr>
        <td>Attachment:</td>
        <td><input type=""file"" name=""Attachment"" /></td>
    </tr>
    <tr>
        <td></td>
        <td><input type=""submit"" value=""Send"" /></td>
    </tr>
</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
