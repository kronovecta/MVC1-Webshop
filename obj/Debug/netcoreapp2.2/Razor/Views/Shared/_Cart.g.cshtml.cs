#pragma checksum "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\Shared\_Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c315fd437273beb800e0faab60cb53b5003d84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Cart), @"mvc.1.0.view", @"/Views/Shared/_Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Cart.cshtml", typeof(AspNetCore.Views_Shared__Cart))]
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
#line 1 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\_ViewImports.cshtml"
using Inlämning_2___Webshop;

#line default
#line hidden
#line 2 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\_ViewImports.cshtml"
using Inlämning_2___Webshop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c315fd437273beb800e0faab60cb53b5003d84", @"/Views/Shared/_Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc17ccf9159228d29e34595a22d98d94bd4f521c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Inlämning_2___Webshop.Models.Matratt>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 41, true);
            WriteLiteral("\r\n<h3>Du har beställt: </h3>\r\n\r\n<table>\r\n");
            EndContext();
#line 6 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\Shared\_Cart.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(136, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(167, 19, false);
#line 9 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\Shared\_Cart.cshtml"
           Write(product.MatrattNamn);

#line default
#line hidden
            EndContext();
            BeginContext(186, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(210, 12, false);
#line 10 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\Shared\_Cart.cshtml"
           Write(product.Pris);

#line default
#line hidden
            EndContext();
            BeginContext(222, 26, true);
            WriteLiteral(" SEK</td>\r\n        </tr>\r\n");
            EndContext();
#line 12 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\Shared\_Cart.cshtml"
    }

#line default
#line hidden
            BeginContext(255, 55, true);
            WriteLiteral("\r\n    <tr>\r\n        <td>Totalsumma: </td>\r\n        <td>");
            EndContext();
            BeginContext(311, 22, false);
#line 16 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\Shared\_Cart.cshtml"
       Write(Model.Sum(p => p.Pris));

#line default
#line hidden
            EndContext();
            BeginContext(333, 32, true);
            WriteLiteral(" SEK</td>\r\n    </tr>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Inlämning_2___Webshop.Models.Matratt>> Html { get; private set; }
    }
}
#pragma warning restore 1591
