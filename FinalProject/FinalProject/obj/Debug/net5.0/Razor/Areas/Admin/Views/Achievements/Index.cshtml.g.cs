#pragma checksum "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Achievements\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14230d6595309d1226ea4030bcd5533b839a2d1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Achievements_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Achievements/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14230d6595309d1226ea4030bcd5533b839a2d1c", @"/Areas/Admin/Views/Achievements/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Achievements_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Achievements>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""row"">

        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Nailiyyətlər</h4>

                    <div class=""table-responsive"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>

                                    <th>
                                        Nailiyyətlər
                                    <th>
                                        Haqqında
                                    </th>



                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 25 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Achievements\Index.cshtml"
                                 foreach (Achievements achievements in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 29 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Achievements\Index.cshtml"
                                   Write(achievements.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 32 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Achievements\Index.cshtml"
                                   Write(achievements.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 36 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Achievements\Index.cshtml"
                                   Write(achievements.Information);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n\r\n");
            WriteLiteral("\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\HP\source\repos\FinalProject\FinalProject\Areas\Admin\Views\Achievements\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Achievements>> Html { get; private set; }
    }
}
#pragma warning restore 1591
