#pragma checksum "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\Home\People.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b214e80d6e5d9d67bbdbea647204c68dfc999b22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_People), @"mvc.1.0.view", @"/Views/Home/People.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/People.cshtml", typeof(AspNetCore.Views_Home_People))]
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
#line 1 "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\Home\People.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b214e80d6e5d9d67bbdbea647204c68dfc999b22", @"/Views/Home/People.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_People : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 81, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Here are some people!</h1>\r\n");
            EndContext();
#line 5 "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\Home\People.cshtml"
     foreach(var person in Model)
    {

#line default
#line hidden
            BeginContext(172, 42, true);
            WriteLiteral("        <p>person.fname person.lname</p>\r\n");
            EndContext();
#line 8 "C:\Users\weber\OneDrive\Desktop\Coding Dojo Desktop\c#_stack\ASP.NET_Core\ViewModelFun\Views\Home\People.cshtml"
    }

#line default
#line hidden
            BeginContext(221, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
