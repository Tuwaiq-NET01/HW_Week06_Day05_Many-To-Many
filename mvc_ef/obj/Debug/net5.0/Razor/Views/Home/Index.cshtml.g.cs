#pragma checksum "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ea320016df847d672f72b5a6b8daf13d238280"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/_ViewImports.cshtml"
using mvc_ef;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/_ViewImports.cshtml"
using mvc_ef.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ea320016df847d672f72b5a6b8daf13d238280", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f5dc9cfdf4e5aa0f32accd73ea1dbd3f594d29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var teacher = (List<Teacher>)ViewData["teacher_name"] ;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 7 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/Home/Index.cshtml"
     foreach (var item in teacher)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 10 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/Home/Index.cshtml"
       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/Home/Index.cshtml"
                 Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/Home/Index.cshtml"
                                 Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 12 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/Home/Index.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5> ");
#nullable restore
#line 14 "/home/z/tuwaiq/dotnet/mvc/mvc_ef/Views/Home/Index.cshtml"
    Write(teacher.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
