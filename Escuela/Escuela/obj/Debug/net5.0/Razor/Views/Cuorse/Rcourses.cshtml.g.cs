#pragma checksum "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\Rcourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08aaeaee85af7120743347bfa525ff85cda254a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuorse_Rcourses), @"mvc.1.0.view", @"/Views/Cuorse/Rcourses.cshtml")]
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
#line 1 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08aaeaee85af7120743347bfa525ff85cda254a4", @"/Views/Cuorse/Rcourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5e22073f2e88759b87b4e552f4724e9adf8a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Cuorse_Rcourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\Rcourses.cshtml"
  
    ViewData["Title"] = "Rcourses";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Register or update Courses </h1>\r\n<br />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\Rcourses.cshtml"
 using (Html.BeginForm("SaveC", "Cuorse", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"id\">ID</label>\r\n    <br />\r\n    <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 305, "\"", 324, 1);
#nullable restore
#line 14 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\Rcourses.cshtml"
WriteAttributeValue("", 313, ViewBag.id, 313, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <br />\r\n");
            WriteLiteral("    <label for=\"titulo\"> Título del curso </label>\r\n    <br>\r\n    <input type=\"text\" name=\"titulo\"");
            BeginWriteAttribute("value", " value=\"", 442, "\"", 465, 1);
#nullable restore
#line 19 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\Rcourses.cshtml"
WriteAttributeValue("", 450, ViewBag.titulo, 450, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n    <br>\r\n");
            WriteLiteral("    <label for=\"creditos\">Creditos del curso</label>\r\n    <br>\r\n    <input type=\"text\" name=\"creditos\"");
            BeginWriteAttribute("value", " value=\"", 592, "\"", 617, 1);
#nullable restore
#line 24 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\Rcourses.cshtml"
WriteAttributeValue("", 600, ViewBag.creditos, 600, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n    <br>\r\n");
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-success\" />\r\n");
#nullable restore
#line 28 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\Rcourses.cshtml"

}

#line default
#line hidden
#nullable disable
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
