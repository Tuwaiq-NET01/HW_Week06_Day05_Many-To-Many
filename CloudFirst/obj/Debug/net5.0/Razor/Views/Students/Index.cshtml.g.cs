#pragma checksum "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38830d58d061e63cf817b2deef2e724c20d6328c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\_ViewImports.cshtml"
using CloudFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\_ViewImports.cshtml"
using CloudFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38830d58d061e63cf817b2deef2e724c20d6328c", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af53b1282ff5b473acf9341e58c885ee7a143be0", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\Students\Index.cshtml"
  
    var students = (List<Student>)ViewData["students"];
    var greateThantwou = (List<Student>)ViewData["greateThantwou"];
    var seracher = ViewData["findu"];
    var aa = (List<Student>)ViewBag.Student;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <div>
        <h1>This is Student Page</h1>
    </div>
    <br />
    <br />
    <div>
        <table class=""table"">
            <thead>
                <tr>
                    <td>ID</td>
                    <td>FirstName</td>
                    <td>LastName</td>
                    <td>Email</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\Students\Index.cshtml"
                 foreach (var Student in students)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\Students\Index.cshtml"
                       Write(Student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\Students\Index.cshtml"
                       Write(Student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\Students\Index.cshtml"
                       Write(Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\Students\Index.cshtml"
                       Write(Student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 32 "D:\Tuwaiq\ClassWorkDotNet\CloudFirst\CloudFirst\Views\Students\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr><td></td><td></td><td></td><td></td></tr>\r\n");
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral("</div>");
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
