#pragma checksum "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed930d5c51ecd72e6363e00df0adb3e7e39329a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Workers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Workers/Index.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed930d5c51ecd72e6363e00df0adb3e7e39329a", @"/Areas/Admin/Views/Workers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Workers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Workers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">

    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">İşçilər</h4>

                <div class=""table-responsive"">
                    <table id=""myTable"" class=""table table-striped"">
                        <thead>
                            <tr>

                                <th>
                                    İşçi
                                </th>
                                <th>
                                    Adı
                                </th>

                                <th>
                                    Şöbəsi
                                </th>
                                <th>
                                    Maaşı
                                </th>

                                <th>
                                    Ünvanı
                                </th>
                                <th>
 ");
            WriteLiteral("                                   Əlaqə telefonu\r\n                                </th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml"
                             foreach (Workers workers in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 42 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml"
                                   Write(workers.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 46 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml"
                                   Write(workers.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 50 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml"
                                   Write(workers.Duties.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n\r\n");
            WriteLiteral("                                    <td>\r\n                                        ");
#nullable restore
#line 58 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml"
                                   Write(workers.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 61 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml"
                                   Write(workers.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n\r\n                                        ");
#nullable restore
#line 65 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml"
                                   Write(workers.Contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Workers\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/buttons/1.6.2/js/dataTables.buttons.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.6.2/js/buttons.flash.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.6.2/js/buttons.html5.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.6.2/js/buttons.print.min.js""></script>

    <script>
        $(function () {
            $(""#myTable"").dataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        })
    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Workers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
