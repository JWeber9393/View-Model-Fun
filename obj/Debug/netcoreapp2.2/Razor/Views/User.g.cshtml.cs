#pragma checksum "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb695687d9cd4e6815256348960c6509225dc6e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User), @"mvc.1.0.view", @"/Views/User.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User.cshtml", typeof(AspNetCore.Views_User))]
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
#line 1 "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 2 "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb695687d9cd4e6815256348960c6509225dc6e8", @"/Views/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 82, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Here are some numbers!</h1>\r\n");
            EndContext();
#line 3 "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\User.cshtml"
      
        foreach (var user in ViewBag.Users)
        {

#line default
#line hidden
            BeginContext(146, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(162, 10, false);
#line 6 "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\User.cshtml"
          Write(user.fname);

#line default
#line hidden
            EndContext();
            BeginContext(172, 22, true);
            WriteLiteral(",\" \", user.lname</p>\r\n");
            EndContext();
#line 7 "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\User.cshtml"
        }
    

#line default
#line hidden
            BeginContext(212, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
