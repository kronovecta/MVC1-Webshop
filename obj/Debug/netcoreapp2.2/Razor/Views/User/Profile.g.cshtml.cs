#pragma checksum "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df4c31c221fa37eead313bb14c81c3de6eb2e23e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Profile.cshtml", typeof(AspNetCore.Views_User_Profile))]
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
#line 1 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\User\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\User\Profile.cshtml"
using Inlämning_2___Webshop.IdentityData;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df4c31c221fa37eead313bb14c81c3de6eb2e23e", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc536a28b20e83e882abe5dbff60c8b19d371a3", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(190, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\User\Profile.cshtml"
  
    ViewData["Title"] = "View Profile";

#line default
#line hidden
            BeginContext(240, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(247, 11, false);
#line 11 "H:\Robert\Nackademin\ASPNET MVC1\Inlämningar\Inlämning 2 - Webshop\Views\User\Profile.cshtml"
Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(258, 5, true);
            WriteLiteral("</h1>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
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
