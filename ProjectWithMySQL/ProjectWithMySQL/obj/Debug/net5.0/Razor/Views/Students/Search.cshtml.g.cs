#pragma checksum "/Users/ahmed/Projects/ProjectWithMySQL/ProjectWithMySQL/Views/Students/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21dcf1c3f7d2c1f2714e5769548aaee04e97bd7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Search), @"mvc.1.0.view", @"/Views/Students/Search.cshtml")]
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
#line 1 "/Users/ahmed/Projects/ProjectWithMySQL/ProjectWithMySQL/Views/_ViewImports.cshtml"
using ProjectWithMySQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ahmed/Projects/ProjectWithMySQL/ProjectWithMySQL/Views/_ViewImports.cshtml"
using ProjectWithMySQL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21dcf1c3f7d2c1f2714e5769548aaee04e97bd7f", @"/Views/Students/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3d17d0e54667537098be101547b61c69c3455b", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ahmed/Projects/ProjectWithMySQL/ProjectWithMySQL/Views/Students/Search.cshtml"
  

    var list = (List<Student>)ViewData["Students"];
   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\n");
#nullable restore
#line 6 "/Users/ahmed/Projects/ProjectWithMySQL/ProjectWithMySQL/Views/Students/Search.cshtml"
         foreach (var item in list)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 9 "/Users/ahmed/Projects/ProjectWithMySQL/ProjectWithMySQL/Views/Students/Search.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -- ");
#nullable restore
#line 9 "/Users/ahmed/Projects/ProjectWithMySQL/ProjectWithMySQL/Views/Students/Search.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n");
#nullable restore
#line 10 "/Users/ahmed/Projects/ProjectWithMySQL/ProjectWithMySQL/Views/Students/Search.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
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
