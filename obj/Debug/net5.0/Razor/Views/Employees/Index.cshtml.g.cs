#pragma checksum "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "361b5f3bc612ea9d0c6133fa5214ea2782725cad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
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
#line 1 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\_ViewImports.cshtml"
using ASPNETMVCCRUD1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\_ViewImports.cshtml"
using ASPNETMVCCRUD1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361b5f3bc612ea9d0c6133fa5214ea2782725cad", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc153193d9728ceee2ac1a3cf76815892f6da4d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASPNETMVCCRUD1.Models.Domain.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1>Employee List</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Email</th>
            <th>Salary</th>
            <th>Date Of Birth</th>
            <th>Department</th>
            <th> </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
         foreach (var employee in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
           Write(employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
           Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
           Write(employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
           Write(employee.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
           Write(employee.DateOfBirth.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
           Write(employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 725, "\"", 759, 2);
            WriteAttributeValue("", 732, "Employees/View/", 732, 15, true);
#nullable restore
#line 29 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
WriteAttributeValue("", 747, employee.Id, 747, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Puja\source\repos\ASPNETMVCCRUD1\Views\Employees\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASPNETMVCCRUD1.Models.Domain.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
