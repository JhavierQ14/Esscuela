#pragma checksum "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1925a84f497d23b36db963fa5c262ae251388a76"
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
#line 1 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1925a84f497d23b36db963fa5c262ae251388a76", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5e22073f2e88759b87b4e552f4724e9adf8a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Escuela.Dominio.Enrollment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome School</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n\n");
#nullable restore
#line 11 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
Write(Html.ActionLink("Insertar", "Insert", new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral(@"
<hr />




<table id=""mitabla"" class=""table table-dark table-striped"">

    <thead>
        <tr>
            <th>Enrollemnt ID</th>
            <th>Student ID</th>
            <th>Course ID</th>
            <th>LastName</th>
            <th>FirstMidName</th>
            <th>Curso</th>
        </tr>
    </thead>


    <tbody>
");
#nullable restore
#line 69 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
         foreach (var iteracion in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 72 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
               Write(iteracion.EnrollmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 73 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
               Write(iteracion.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 74 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
               Write(iteracion.Course.CouserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 75 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
               Write(iteracion.Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 76 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
               Write(iteracion.Student.FirstMiName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 77 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
               Write(iteracion.Course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 79 "C:\Users\carlj\Documents\GitHub\Escuela\Escuela\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n</table>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n\n    <script src=\"https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js\"></script>\n    <script>\n        $(document).ready(function () {\n            var tabla = $(\'#mitabla\').DataTable();\n        });\n\n\n    </script>\n\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Escuela.Dominio.Enrollment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
