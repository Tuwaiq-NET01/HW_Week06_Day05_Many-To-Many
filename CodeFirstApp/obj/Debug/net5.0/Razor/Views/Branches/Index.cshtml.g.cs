#pragma checksum "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/Branches/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1469c4891c22cc8fd6aecf996d60ba1e0a50446f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branches_Index), @"mvc.1.0.view", @"/Views/Branches/Index.cshtml")]
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
#line 1 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/_ViewImports.cshtml"
using CodeFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/_ViewImports.cshtml"
using CodeFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1469c4891c22cc8fd6aecf996d60ba1e0a50446f", @"/Views/Branches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85771d2b7276b2da9518a094c9e5d2f1d0585e62", @"/Views/_ViewImports.cshtml")]
    public class Views_Branches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/Branches/Index.cshtml"
  
    var Branches = (List<BranchModel>)ViewData["Branches"];
    //var aa = (List<BranchModel>)ViewData["aa"];


#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\n    <thead>\n        <tr>\n            <td>id</td>\n            <td>Name</td>\n            <td>Adress</td>\n            <td>Area</td>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 16 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/Branches/Index.cshtml"
         foreach (var Branch in Branches)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td> ");
#nullable restore
#line 19 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/Branches/Index.cshtml"
                Write(Branch.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td> ");
#nullable restore
#line 20 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/Branches/Index.cshtml"
                Write(Branch.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td> ");
#nullable restore
#line 21 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/Branches/Index.cshtml"
                Write(Branch.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td> ");
#nullable restore
#line 22 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/Branches/Index.cshtml"
                Write(Branch.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 24 "/Users/afra/Projects/CodeFirstApp/CodeFirstApp/Views/Branches/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
